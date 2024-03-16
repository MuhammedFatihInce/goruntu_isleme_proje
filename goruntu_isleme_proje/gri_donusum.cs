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
	public partial class gri_donusum : Form
	{
		public gri_donusum()
		{
			InitializeComponent();
		}
		public Bitmap asilGoruntu;
		public Bitmap griGoruntu;

		private void goruntuAlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "İşlem için bir görüntü seçin!";
			openFileDialog1.ShowDialog();
			pictureBox1.ImageLocation = openFileDialog1.FileName;
			asilGoruntu = new Bitmap(pictureBox1.ImageLocation);
			griGoruntu = new Bitmap(pictureBox1.ImageLocation);
		}

		private void goruntuyuGriYapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Color renkBilgisi;
			byte griDeger, kirmizi, yesil, mavi;

			for (int i = 0; i < asilGoruntu.Width; i++)
			{
				for (int j = 0; j < asilGoruntu.Height; j++)
				{
					renkBilgisi = asilGoruntu.GetPixel(i, j);
					kirmizi = renkBilgisi.R;
					yesil = renkBilgisi.G;
					mavi = renkBilgisi.B;

					griDeger = Convert.ToByte((kirmizi + yesil + mavi) / 3);
					griGoruntu.SetPixel(i, j, Color.FromArgb(griDeger, griDeger, griDeger));
				}
			}
			pictureBox2.Image = griGoruntu;
		}
	}
}
