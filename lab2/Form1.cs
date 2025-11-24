using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class FormPicConvertGrayscale : Form
    {
        /// <summary>
        /// Хранит исходное загруженное изображение для дальнейшей обработки.
        /// </summary>
        private Bitmap _originalBitmap;

        public FormPicConvertGrayscale()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку загрузки изображения.
        /// Открывает диалоговое окно, загружает файл и отображает его в PictureBox.
        /// </summary>
        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                // Ограничиваем выбор только поддерживаемыми графическими форматами
                dialog.Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg;*.jpeg;*.png";
                dialog.Title = "Выберите изображение";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Используем промежуточный поток/объект для загрузки файла.
                        // Это необходимо для обхода блокировки файла (File Lock) процессом GDI+.
                        // Если загрузить напрямую через new Bitmap(filename), файл останется заблокированным
                        // до вызова Dispose() у битмапа.
                        using (var tempBitmap = new Bitmap(dialog.FileName))
                        {
                            // Создаем копию изображения в памяти, не связанную с файловым дескриптором
                            _originalBitmap = new Bitmap(tempBitmap);
                        }

                        // Отображение исходного изображения
                        pictureBoxSrc.Image = _originalBitmap;
                        pictureBoxSrc.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Обработчик кнопки "Convert".
        /// Выполняет преобразование исходного изображения в полутоновое (Grayscale)
        /// с использованием стандартных весовых коэффициентов.
        /// </summary>
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // Проверка на наличие загруженного изображения перед обработкой
            if (_originalBitmap == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем размеры изображения для создания пустого холста того же размера
            int width = _originalBitmap.Width;
            int height = _originalBitmap.Height;

            // Создаем новый Bitmap для результата.
            // Используем тот же размер, что и у оригинала.
            Bitmap grayImage = new Bitmap(width, height);

            // Проходим по каждому пикселю изображения.
            // Вложенные циклы по ширине (x) и высоте (y).
            // Примечание: GetPixel/SetPixel работают медленно на больших изображениях,
            // но являются самым безопасным и понятным способом доступа к пикселям в Windows Forms.
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Получаем цвет текущего пикселя
                    Color originalColor = _originalBitmap.GetPixel(x, y);

                    // Вычисляем значение яркости (gray) по стандартной формуле.
                    // Формула: (77*R + 150*G + 29*B) / 256.
                    // Используется целочисленное деление, сумма коэффициентов равна 256.
                    int grayValue = (77 * originalColor.R + 150 * originalColor.G + 29 * originalColor.B) / 256;

                    // Создаем новый цвет.
                    // Для оттенков серого значения R, G и B должны быть равны вычисленному grayValue.
                    // Альфа-канал (прозрачность) сохраняем от оригинала.
                    Color newColor = Color.FromArgb(originalColor.A, grayValue, grayValue, grayValue);

                    // Записываем полученный пиксель в результирующее изображение
                    grayImage.SetPixel(x, y, newColor);
                }
            }

            // Выводим результат во второй PictureBox
            pictureBoxGrayscale.Image = grayImage;
            pictureBoxGrayscale.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
