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
			Color pixelColor = GirisResmi.GetPixel(10, 10);
			int r = pixelColor.R;
			int g = pixelColor.G;
			int b = pixelColor.B;

			double min = Math.Min(Math.Min(r, g), b);
			double max = Math.Max(Math.Max(r, g), b);
			double delta = max - min;

			double hue = 0;
			if (delta != 0)
			{
				if (max == r) hue = ((g - b) / delta) % 6;
				else if (max == g) hue = (b - r) / delta + 2;
				else hue = (r - g) / delta + 4;
				hue *= 60;
			}

			double saturation = max == 0 ? 0 : delta / max;
			double value = max / 255;

			//return (hue, saturation, value);
		}
	}
}
