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
	public partial class resmi_dondurme : Form
	{
		public resmi_dondurme()
		{
			InitializeComponent();
		}
		Color OkunanRenk;
		Bitmap GirisResmi, CikisResmi;
		private void görüntüAlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "İşlem için bir görüntü seçin!";
			openFileDialog1.ShowDialog();
			pictureBox1.ImageLocation = openFileDialog1.FileName;
			GirisResmi = new Bitmap(pictureBox1.ImageLocation);
		}
		private void görüntüyüDöndürToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int ResimGenisligi = GirisResmi.Width;
			int ResimYuksekligi = GirisResmi.Height;

			CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

			int Aci = Convert.ToInt16(textBox1.Text);
			double RadyanAci = Aci * 2 * Math.PI / 360;
			double x2 = 0, y2 = 0;

			//Resim merkezini buluyor. Resim merkezi etrafında döndürecek.
			int x0 = ResimGenisligi / 2;
			int y0 = ResimYuksekligi / 2;
			if (Aci == 180)
			{
				for (int x1 = 0; x1 < (ResimGenisligi); x1++)
				{
					for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
					{
						OkunanRenk = GirisResmi.GetPixel(x1, y1);
						//Döndürme Formülleri
						x2 = Math.Cos(RadyanAci) * (x1 - x0) - Math.Sin(RadyanAci) * (y1 - y0) + x0;
						y2 = Math.Sin(RadyanAci) * (x1 - x0) + Math.Cos(RadyanAci) * (y1 - y0) + y0;

						if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
							CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
					}
				}
				pictureBox2.Image = CikisResmi;
			}
			else
			{
				for (int x1 = 0; x1 < (ResimGenisligi); x1++)
				{
					for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
					{
						OkunanRenk = GirisResmi.GetPixel(x1, y1);
						//Aliaslı Döndürme -Sağa Kaydırma
						x2 = (x1 - x0) - Math.Tan(RadyanAci / 2) * (y1 - y0) + x0;
						y2 = (y1 - y0) + y0;
						x2 = Convert.ToInt16(x2);
						y2 = Convert.ToInt16(y2);
						//Aliaslı Döndürme -Aşağı kaydırma
						x2 = (x2 - x0) + x0;
						y2 = Math.Sin(RadyanAci) * (x2 - x0) + (y2 - y0) + y0;
						x2 = Convert.ToInt16(x2);
						y2 = Convert.ToInt16(y2);
						//Aliaslı Döndürme -Sağa Kaydırma
						x2 = (x2 - x0) - Math.Tan(RadyanAci / 2) * (y2 - y0) + x0;
						y2 = (y2 - y0) + y0;
						x2 = Convert.ToInt16(x2);
						y2 = Convert.ToInt16(y2);
						if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
							CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
					}
				}
				pictureBox2.Image = CikisResmi;
			}
			
		}
	}
}
