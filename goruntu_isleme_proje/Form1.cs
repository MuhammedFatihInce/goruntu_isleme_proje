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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			gri_donusum g = new gri_donusum();
			g.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			resmi_dondurme r = new resmi_dondurme();
			r.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			binary_donusum b = new binary_donusum();
			b.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			goruntu_yakinlastırma_uzaklastirma g = new goruntu_yakinlastırma_uzaklastirma();
			g.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			goruntu_kirpma g = new goruntu_kirpma();
			g.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			renk_uzayi r = new renk_uzayi();
			r.Show();
		}
	}
}
