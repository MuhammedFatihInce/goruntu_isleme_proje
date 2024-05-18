using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goruntu_isleme_proje
{
    public partial class kontrast_azaltma : Form
    {
        public kontrast_azaltma()
        {
            InitializeComponent();
        }
        Bitmap GirisResmi;
        

       

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "İşlem için bir görüntü seçin!";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            GirisResmi = new Bitmap(pictureBox1.ImageLocation);
        }


       

        private void btnKontrast_Click(object sender, EventArgs e)
        {
            double faktör = Convert.ToDouble(textBox1.Text);
            Bitmap CikisResmi = KarşıtlıkAzalt(GirisResmi, faktör);
            pictureBox2.Image = CikisResmi;
        }

        public static Bitmap KarşıtlıkAzalt(Bitmap image, double faktör)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int newRed = (int)(pixelColor.R * faktör);
                    int newGreen = (int)(pixelColor.G * faktör);
                    int newBlue = (int)(pixelColor.B * faktör);

                    // Renk değerleri sınırların dışına çıkarsa sınır değer alınır
                    newRed = Math.Max(0, Math.Min(255, newRed));
                    newGreen = Math.Max(0, Math.Min(255, newGreen));
                    newBlue = Math.Max(0, Math.Min(255, newBlue));

                    Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
                    result.SetPixel(x, y, newColor);
                }
            }

            return result;
        }


    }
}
