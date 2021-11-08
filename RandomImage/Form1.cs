using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace RandomImage
{
    public partial class MainForm : MetroForm
    {
        private Random random = new Random();
        private Bitmap bitmap;
        private string seed = "";

        public MainForm()
        {
            InitializeComponent();
            FillComboBox();
            saveButton.Enabled = false;
        }

        private void FillComboBox()
        {
            int width = pictureBox.Width, height = pictureBox.Height;

            for(int i = 1; i < height; i++)
            {
                if ((width % i == 0) && (height % i == 0)) pixelSizeComboBox.Items.Add(i);
            }

            pixelSizeComboBox.SelectedIndex = 0;
        }


        private void GenerateImage(object sender, EventArgs e)
        {
            saveButton.Enabled = true;

            if (!seedTextBox.Text.Equals(string.Empty))
            {
                seed = seedTextBox.Text;
                random = new Random(seed.GetHashCode());
            }

            int width = pictureBox.Width, height = pictureBox.Height;
            bitmap = new Bitmap(width, height);

            int a, r, g, b;
            a = 255;
            r = g = b = 0;

            int pixelSize = Convert.ToInt32(pixelSizeComboBox.SelectedItem);
            for (int z = 0; z < (height / pixelSize); z++)
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = z * pixelSize; j < pixelSize + pixelSize * z; j++)
                    {
                        if (j % pixelSize == 0 && i % pixelSize == 0)
                        {
                            if (alphaToggle.Checked) a = random.Next(256);
                            r = random.Next(256);
                            g = random.Next(256);
                            b = random.Next(256);
                        }

                        bitmap.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                    }
                }
            }
            pictureBox.Image = bitmap;
        }

        private void SaveImage(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";

            if (seed.Equals(string.Empty)) saveFileDialog.FileName = "randomImage_seedless";
            else saveFileDialog.FileName = $"randomImage_{seed}";

            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string extension = System.IO.Path.GetExtension(saveFileDialog.FileName);
                if (extension.Equals(".jpg")) format = ImageFormat.Jpeg;
                else if (extension.Equals(".bmp")) format = ImageFormat.Bmp;

                pictureBox.Image.Save(saveFileDialog.FileName, format);
            }
        }
    }
}
