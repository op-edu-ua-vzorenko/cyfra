using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class FormPictureFX : Form
    {
        /// <summary>
        /// Хранит исходное загруженное изображение для дальнейшей обработки.
        /// </summary>
        private Bitmap _originalBitmap;

        // --- ПЕРЕМЕННЫЕ ДЛЯ ЭФФЕКТОВ (Lab 3) ---
        private int _stripesInterval = 5;       // Интервал между полосами (пиксели)
        private Color _stripesColor = Color.Red; // Цвет полос
        private bool _stripesVertical = true;    // Ориентация полос (true - вертикальные)

        private int _glassCoeff = 10;            // Коэффициент "мутности" стекла (1-25)

        // Коэффициенты для волны (v1, v2, v3, v4)
        private int _waveV1 = 10;
        private int _waveV2 = 60;
        // v3, v4 нужны для сложной волны (формула 3.5), пока используем простую (3.3/3.4)

        public FormPictureFX()
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
                        buttonMakeFX.Enabled = true; // Активируем кнопку эффектов

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


        private void buttonRefreshPicture_Click(object sender, EventArgs e)
        {
            // Просто вызываем наш готовый метод
            UpdateCustomImage();
        }

        // --- ЭФФЕКТ 1: НЕГАТИВ ---
        // Формула: New = 255 - Old
        private void ApplyNegative()
        {
            if (_originalBitmap == null) return;
            int w = _originalBitmap.Width;
            int h = _originalBitmap.Height;
            Bitmap bmp = new Bitmap(w, h);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Color p = _originalBitmap.GetPixel(x, y);
                    // Инвертируем каждый канал
                    Color newColor = Color.FromArgb(p.A, 255 - p.R, 255 - p.G, 255 - p.B);
                    bmp.SetPixel(x, y, newColor);
                }
            }
            pictureBoxNegative.Image = bmp;
            pictureBoxNegative.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // --- ЭФФЕКТ 2: ПОЛОСЫ (Stripes) ---
        // Накладывает цветную сетку
        private void ApplyStripes()
        {
            if (_originalBitmap == null) return;
            int w = _originalBitmap.Width;
            int h = _originalBitmap.Height;

            // Клонируем оригинал, чтобы рисовать поверх него
            Bitmap bmp = new Bitmap(_originalBitmap);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    bool drawStripe = false;

                    if (_stripesVertical)
                    {
                        // Вертикальные полосы: проверяем координату X
                        if (x % _stripesInterval == 0) drawStripe = true;
                    }
                    else
                    {
                        // Горизонтальные полосы: проверяем координату Y
                        if (y % _stripesInterval == 0) drawStripe = true;
                    }

                    if (drawStripe)
                    {
                        bmp.SetPixel(x, y, _stripesColor);
                    }
                }
            }
            pictureBoxStripes.Image = bmp;
            pictureBoxStripes.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // --- ЭФФЕКТ 3: СТЕКЛО (Glass) ---
        // Случайное смещение пикселей
        private void ApplyGlass()
        {
            if (_originalBitmap == null) return;
            int w = _originalBitmap.Width;
            int h = _originalBitmap.Height;
            Bitmap bmp = new Bitmap(w, h);
            Random rnd = new Random();

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    // Формула (3.2): x = x + (random - 0.5) * v
                    // Генерируем сдвиг в диапазоне [-coeff/2 ... +coeff/2]
                    int dx = (int)((rnd.NextDouble() - 0.5) * _glassCoeff);
                    int dy = (int)((rnd.NextDouble() - 0.5) * _glassCoeff);

                    int newX = x + dx;
                    int newY = y + dy;

                    // Проверка границ: если вышли за край картинки, берем граничный пиксель
                    if (newX < 0) newX = 0;
                    if (newX >= w) newX = w - 1;
                    if (newY < 0) newY = 0;
                    if (newY >= h) newY = h - 1;

                    Color p = _originalBitmap.GetPixel(newX, newY);
                    bmp.SetPixel(x, y, p);
                }
            }
            pictureBoxGlass.Image = bmp;
            pictureBoxGlass.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // --- ЭФФЕКТ 4: ВОЛНЫ (Waves) ---
        // Синусоидальное смещение
        private void ApplyWaves()
        {
            if (_originalBitmap == null) return;
            int w = _originalBitmap.Width;
            int h = _originalBitmap.Height;
            Bitmap bmp = new Bitmap(w, h);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    // Формула (3.4) для вертикальной волны (вдоль Y):
                    // x_new = x
                    // y_new = y + v1 * sin(2*PI * x / v2)

                    int newX = x;
                    int newY = (int)(y + _waveV1 * Math.Sin(2 * Math.PI * x / _waveV2));

                    // Проверка границ (чтобы не упало с ошибкой)
                    if (newY < 0) newY = 0;
                    if (newY >= h) newY = h - 1;

                    Color p = _originalBitmap.GetPixel(newX, newY);
                    bmp.SetPixel(x, y, p);
                }
            }
            pictureBoxWave.Image = bmp;
            pictureBoxWave.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void buttonMakeFX_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null)
            {
                MessageBox.Show("Загрузите картинку!");
                return;
            }

            // Вызываем все 4 эффекта по очереди
            ApplyNegative();
            buttonSaveNegative.Enabled = true;
            
            ApplyStripes();
            buttonSaveStripes.Enabled = true;

            ApplyGlass();
            buttonSaveGlass.Enabled = true;

            ApplyWaves();
            buttonSaveWave.Enabled = true;
        }

        private void buttonSaveNegative_Click(object sender, EventArgs e)
        {
            // Передаем картинку из бокса "Негатив" в наш универсальный метод
            SaveImageToFile(pictureBoxNegative.Image);
        }

        private void buttonSaveStripes_Click(object sender, EventArgs e)
        {
            SaveImageToFile(pictureBoxStripes.Image);
        }

        private void buttonSaveGlass_Click(object sender, EventArgs e)
        {
            SaveImageToFile(pictureBoxGlass.Image);
        }

        private void buttonSaveWave_Click(object sender, EventArgs e)
        {
            SaveImageToFile(pictureBoxWave.Image);
        }
    }
}
