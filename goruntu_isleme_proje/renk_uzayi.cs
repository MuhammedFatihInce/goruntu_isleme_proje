using System;
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
	public partial class renk_uzayi : Form
	{
		public renk_uzayi()
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

		private void button2_Click(object sender, EventArgs e)
		{
			// Resmin boyutlarını al
			int width = GirisResmi.Width;
			int height = GirisResmi.Height;

			// Resmin piksel değerlerini dönüştür ve ikinci picturebox'ta göster
			Bitmap CikisResmi = new Bitmap(width, height);
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					// Picturebox'tan RGB değerlerini al
					Color pixelColor = GirisResmi.GetPixel(x, y);
					int r = pixelColor.R;
					int g = pixelColor.G;
					int b = pixelColor.B;

					// RGB'den HSV'ye dönüşüm
					(double hue, double saturation, double value) = RGBtoHSV(r, g, b);




					CikisResmi.SetPixel(x, y, ColorFromHSV(hue, saturation, value));


				}
			}

			// İkinci picturebox'a dönüştürülmüş resmi ata
			pictureBox2.Image = CikisResmi;


		}
		
		public static (double hue, double saturation, double value) RGBtoHSV(int r, int g, int b)
		{
			double min = Math.Min(Math.Min(r, g), b);
			double max = Math.Max(Math.Max(r, g), b);
			double delta = max - min;

			double hue = 0;
			if (delta != 0)
			{
				if (max == r)
					hue = ((g - b) / delta) % 6;
				else if
					(max == g) hue = (b - r) / delta + 2;
				else
					hue = (r - g) / delta + 4;
				hue *= 60;
			}

			double saturation = max == 0 ? 0 : delta / max;
			double value = max / 255;

			return (hue, saturation, value);
		}
		public static Color ColorFromHSV(double hue, double saturation, double value)
		{
			int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
			double f = hue / 60 - Math.Floor(hue / 60);

			value *= 255;
			int v = Convert.ToInt32(value);
			int p = Convert.ToInt32(value * (1 - saturation));
			int q = Convert.ToInt32(value * (1 - f * saturation));
			int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

			switch (hi)
			{
				case 0: return Color.FromArgb(255, v, t, p);
				case 1: return Color.FromArgb(255, q, v, p);
				case 2: return Color.FromArgb(255, p, v, t);
				case 3: return Color.FromArgb(255, p, q, v);
				case 4: return Color.FromArgb(255, t, p, v);
				default: return Color.FromArgb(255, v, p, q);
			}
		}

	}
}
