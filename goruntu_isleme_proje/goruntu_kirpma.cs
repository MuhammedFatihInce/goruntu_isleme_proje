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
	public partial class goruntu_kirpma : Form
	{
		public goruntu_kirpma()
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
			int width = GirisResmi.Width;
			int height = GirisResmi.Height;

			int startX = Convert.ToInt32(textBox1.Text);
			int startY = Convert.ToInt32(textBox2.Text);
			// Yeni boyutlarda boş bir Bitmap nesnesi oluştur
			Bitmap CikisResmi = new Bitmap(width, height);

			int x2 = 0, y2 = 0;
			// Kırpılmış resmi oluşturma
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					// Orijinal resimdeki piksel değerini al
					Color pixelColor = GirisResmi.GetPixel(x, y);

					x2 = x + startX;
					y2 = y + startY;


					// Kırpılmış resimdeki pikseli ayarla
					if (x2 > 0 && x2 < width && y2 > 0 && y2 < height)
						CikisResmi.SetPixel(x2, y2, pixelColor);
				}
			}

			// Kırpılmış resmi döndür
			pictureBox2.Image = CikisResmi;
		}

	}
}
