namespace lab1
{
    public partial class Form1 : Form
    {
        private Bitmap? _original;
        private string? _originalPath;
        private Bitmap? _imgR, _imgG, _imgB;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Choose image",
                Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|All files (*.*)|*.*",
                FilterIndex = 1,
                CheckFileExists = true,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            // освобождаем прошлое изображение
            _original?.Dispose();
            pictureBoxOriginal.Image = null;

            _originalPath = dialog.FileName;

            // читаем и клонируем, чтобы НЕ держать файл залоченным
            using (var temp = Image.FromFile(_originalPath))   // temp владеет дескриптором файла
            {
                _original = new Bitmap(temp);                  // клон уже в памяти, без блокировки файла
            }

            pictureBoxOriginal.Image = _original;
            buttonConvert.Enabled = true;          // включим следующий шаг
        }

        private void DisposeChannelBitmaps()
        {
            pictureBoxR.Image = null;
            pictureBoxG.Image = null;
            pictureBoxB.Image = null;

            _imgR?.Dispose(); _imgR = null;
            _imgG?.Dispose(); _imgG = null;
            _imgB?.Dispose(); _imgB = null;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (_original == null) return;

            // очистим любые старые результаты
            DisposeChannelBitmaps();

            int w = _original.Width;
            int h = _original.Height;

            _imgR = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            _imgG = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            _imgB = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // простая версия через GetPixel/SetPixel (для лабы ок)
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    var c = _original.GetPixel(x, y);
                    int a = c.A; // сохраним альфу

                    _imgR.SetPixel(x, y, Color.FromArgb(a, c.R, 0, 0));
                    _imgG.SetPixel(x, y, Color.FromArgb(a, 0, c.G, 0));
                    _imgB.SetPixel(x, y, Color.FromArgb(a, 0, 0, c.B));
                }
            }

            // показать превью
            pictureBoxR.Image = _imgR;
            pictureBoxG.Image = _imgG;
            pictureBoxB.Image = _imgB;

            // активировать кнопки скачивания
            buttonSaveR.Enabled = true;
            buttonSaveG.Enabled = true;
            buttonSaveB.Enabled = true;
        }



        private void SaveChannel(Bitmap? bmp, string suffix)
        {
            if (bmp == null)
            {
                MessageBox.Show($"Канал {suffix} ещё не сформирован.", "Nothing to save",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string baseName = _originalPath is null ? "image" : Path.GetFileNameWithoutExtension(_originalPath);

            using var sfd = new SaveFileDialog
            {
                Title = $"Save channel {suffix}",
                FileName = $"{baseName}_{suffix}.bmp",      // дефолт — BMP (как в методичке)
                Filter = "BMP (*.bmp)|*.bmp|PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg",
                FilterIndex = 1,
                RestoreDirectory = true,
                AddExtension = true
            };

            if (sfd.ShowDialog(this) != DialogResult.OK) return;

            // выбор формата по расширению
            var ext = Path.GetExtension(sfd.FileName).ToLowerInvariant();
            var fmt = System.Drawing.Imaging.ImageFormat.Bmp;
            if (ext == ".png") fmt = System.Drawing.Imaging.ImageFormat.Png;
            else if (ext == ".jpg" || ext == ".jpeg") fmt = System.Drawing.Imaging.ImageFormat.Jpeg;

            // сохранение
            bmp.Save(sfd.FileName, fmt);
        }

        private void buttonSaveR_Click(object sender, EventArgs e) => SaveChannel(_imgR, "R");
        private void buttonSaveG_Click(object sender, EventArgs e) => SaveChannel(_imgG, "G");
        private void buttonSaveB_Click(object sender, EventArgs e) => SaveChannel(_imgB, "B");
    }
}
