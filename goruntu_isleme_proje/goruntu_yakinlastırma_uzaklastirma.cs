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
	public partial class goruntu_yakinlastırma_uzaklastirma : Form
	{
		public goruntu_yakinlastırma_uzaklastirma()
		{
			InitializeComponent();
		}
		Color OkunanRenk, DonusenRenk;
		Bitmap GirisResmi, CikisResmi;
		int R = 0, G = 0, B = 0;

		

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "İşlem için bir görüntü seçin!";
			openFileDialog1.ShowDialog();
			pictureBox1.ImageLocation = openFileDialog1.FileName;
			GirisResmi = new Bitmap(pictureBox1.ImageLocation);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
			int ResimYuksekligi = GirisResmi.Height;
			CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resminin boyutları
			int x2 = 0, y2 = 0; //Çıkış resminin x ve y si olacak.
			int KucultmeKatsayisi = 2;
			for (int x1 = 0; x1 < ResimGenisligi; x1 = x1 + KucultmeKatsayisi)
			{
				y2 = 0;
				for (int y1 = 0; y1 < ResimYuksekligi; y1 = y1 + KucultmeKatsayisi)
				{
					//x ve y de ilerlerken her atlanan pikselleri okuyacak ve ortalama değerini alacak.
					R = 0; G = 0; B = 0;
					try //resim sınırının dışına çıkaldığında hata vermesin diye
					{
						for (int i = 0; i < KucultmeKatsayisi; i++)
						{
							for (int j = 0; j < KucultmeKatsayisi; j++)
							{
								OkunanRenk = GirisResmi.GetPixel(x1 + i, y1 + j);
								R = R + OkunanRenk.R;
								G = G + OkunanRenk.G;
								B = B + OkunanRenk.B;
							}
						}
					}
					catch { }
					//Renk kanallarının ortalamasını alıyor
					R = R / (KucultmeKatsayisi * KucultmeKatsayisi);
					G = G / (KucultmeKatsayisi * KucultmeKatsayisi);
					B = B / (KucultmeKatsayisi * KucultmeKatsayisi);
					DonusenRenk = Color.FromArgb(R, G, B);
					CikisResmi.SetPixel(x2, y2, DonusenRenk);
					y2++;
				}
				x2++;
			}
			pictureBox2.Image = CikisResmi;

		}

		private void button3_Click(object sender, EventArgs e)
		{
			int BuyutmeKatsayisi = Convert.ToInt32(textBox1.Text);
			int ResimGenisligi = GirisResmi.Width * BuyutmeKatsayisi;
			int ResimYuksekligi = GirisResmi.Height * BuyutmeKatsayisi;
			CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
		

			int x2 = 0, y2 = 0;
			for (int x = 0; x < ResimGenisligi; x++)
			{

				for (int y = 0; y < ResimYuksekligi; y++)
				{
					int originalX = x / BuyutmeKatsayisi;
					int originalY = y / BuyutmeKatsayisi;

					OkunanRenk = GirisResmi.GetPixel(originalX, originalY);
					CikisResmi.SetPixel(x, y, OkunanRenk);

				}

			}
			pictureBox2.Image = CikisResmi;
		}
	}
}
