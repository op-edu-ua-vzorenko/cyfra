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

            // --- ИНИЦИАЛИЗАЦИЯ (Запускается при старте) ---

            // Настраиваем ограничители для ползунков (от 0 до 255) через код
            SetupTrackBar(trackBarRed);
            SetupTrackBar(trackBarGreen); // Убедись, что в дизайнере ты переименовал его в trackBarGreen!
            SetupTrackBar(trackBarBlue);

            // Устанавливаем "правильные" веса по умолчанию
            SetStandardWeights();
        }

        /// <summary>
        /// Вспомогательный метод для настройки свойств TrackBar
        /// </summary>
        private void SetupTrackBar(TrackBar bar)
        {
            bar.Minimum = 0;
            bar.Maximum = 255;
            bar.TickFrequency = 10; // Визуальные засечки каждые 10 единиц
        }

        /// <summary>
        /// Устанавливает ползунки в стандартные значения (NTSC формула)
        /// </summary>
        private void SetStandardWeights()
        {
            trackBarRed.Value = 77;
            trackBarGreen.Value = 150;
            trackBarBlue.Value = 29;
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
                        buttonConvert.Enabled = true; // Активируем кнопку преобразования
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Метод №1: Считает ТОЛЬКО стандартное ч/б изображение (77, 150, 29)
        /// и выводит его в средний PictureBox.
        /// </summary>
        private void UpdateStandardImage()
        {
            if (_originalBitmap == null) return;

            int w = _originalBitmap.Width;
            int h = _originalBitmap.Height;

            Bitmap bmpStandard = new Bitmap(w, h);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Color pixel = _originalBitmap.GetPixel(x, y);

                    // Стандартная формула: (77R + 150G + 29B) / 256
                    int grayStd = (77 * pixel.R + 150 * pixel.G + 29 * pixel.B) / 256;

                    Color newColor = Color.FromArgb(pixel.A, grayStd, grayStd, grayStd);
                    bmpStandard.SetPixel(x, y, newColor);
                }
            }

            pictureBoxGrayscale.Image = bmpStandard;
            pictureBoxGrayscale.SizeMode = PictureBoxSizeMode.Zoom;
            buttonSaveGrayscale.Enabled = true;
        }

        /// <summary>
        /// Метод №2: Считает ТОЛЬКО кастомное ч/б изображение
        /// на основе текущих значений ползунков.
        /// </summary>
        private void UpdateCustomImage()
        {
            if (_originalBitmap == null) return;

            int w = _originalBitmap.Width;
            int h = _originalBitmap.Height;

            Bitmap bmpCustom = new Bitmap(w, h);

            // Получаем веса
            int kR = trackBarRed.Value;
            int kG = trackBarGreen.Value;
            int kB = trackBarBlue.Value;

            int sumWeights = kR + kG + kB;
            if (sumWeights <= 0) sumWeights = 1; // Защита от деления на 0

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Color pixel = _originalBitmap.GetPixel(x, y);

                    // Формула из задания 2.2: (Kr*R + Kg*G + Kb*B) / Sum
                    long numerator = (long)kR * pixel.R + (long)kG * pixel.G + (long)kB * pixel.B;
                    int grayCust = (int)(numerator / sumWeights);

                    // Ограничение диапазона (клиппинг)
                    if (grayCust > 255) grayCust = 255;
                    if (grayCust < 0) grayCust = 0;

                    Color newColor = Color.FromArgb(pixel.A, grayCust, grayCust, grayCust);
                    bmpCustom.SetPixel(x, y, newColor);
                }
            }

            pictureBoxGrayscaleCustom.Image = bmpCustom;
            pictureBoxGrayscaleCustom.SizeMode = PictureBoxSizeMode.Zoom;
            buttonSaveGrayscaleCustom.Enabled = true;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetStandardWeights();
            UpdateCustomImage();
        }
        /// <summary>
        /// Обработчик кнопки "Convert".
        /// Выполняет преобразование исходного изображения в полутоновое (Grayscale)
        /// с использованием стандартных весовых коэффициентов.
        /// </summary>
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Вызываем методы по очереди
            UpdateStandardImage();
            UpdateCustomImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // --- СОХРАНЕНИЕ (Helper метод) ---
        private void SaveImageToFile(Image image)
        {
            if (image == null) return;
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "BMP|*.bmp|JPG|*.jpg|PNG|*.png";
                if (sfd.ShowDialog() == DialogResult.OK)
                    image.Save(sfd.FileName);
            }
        }

        // Кнопка сохранения СТАНДАРТНОГО результата
        private void buttonSaveGrayscale_Click(object sender, EventArgs e)
        {
            SaveImageToFile(pictureBoxGrayscale.Image);
        }

        // Кнопка сохранения ПОЛЬЗОВАТЕЛЬСКОГО результата
        private void buttonSaveGrayscaleCustom_Click(object sender, EventArgs e)
        {
            SaveImageToFile(pictureBoxGrayscaleCustom.Image);
        }

        private void buttonResreshPicture_Click(object sender, EventArgs e)
        {
            // Просто вызываем наш готовый метод
            UpdateCustomImage();
        }
    }
}
