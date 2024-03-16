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
	public partial class binary_donusum : Form
	{
		public binary_donusum()
		{
			InitializeComponent();
		}
		Bitmap GirisResmi, CikisResmi;
		private void goruntuyuAlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "İşlem için bir görüntü seçin!";
			openFileDialog1.ShowDialog();
			pictureBox1.ImageLocation = openFileDialog1.FileName;
			GirisResmi = new Bitmap(pictureBox1.ImageLocation);
		}
		private void binaryDonusumUygulaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			 CikisResmi = new Bitmap(GirisResmi.Width, GirisResmi.Height);
			int threshold = Convert.ToInt32(textBox1.Text);
			for (int y = 0; y < GirisResmi.Height; y++)
			{
				for (int x = 0; x < GirisResmi.Width; x++)
				{
					Color originalColor = GirisResmi.GetPixel(x, y);

					int averageColor = (originalColor.R + originalColor.G + originalColor.B) / 3;

					Color newColor = (averageColor >= threshold) ? Color.White : Color.Black;

					CikisResmi.SetPixel(x, y, newColor);
				}
			}
			pictureBox2.Image = CikisResmi;
		}

		
	}
}
