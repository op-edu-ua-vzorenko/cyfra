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
    }
}
