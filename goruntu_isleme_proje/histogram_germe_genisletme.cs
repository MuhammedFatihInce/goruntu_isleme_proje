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
    public partial class histogram_germe_genisletme : Form
    {
        public histogram_germe_genisletme()
        {
            InitializeComponent();
        }

        Bitmap GirisResmi;
        Bitmap CikisResmi;
        Bitmap CikisResmi_2;
        int ResimGenisligi, ResimYuksekligi;

        private void button1_Click(object sender, EventArgs e)
        {         
            openFileDialog1.Title = "İşlem için bir görüntü seçin!";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            GirisResmi = new Bitmap(pictureBox1.ImageLocation);
            ResimGenisligi = GirisResmi.Width;
            ResimYuksekligi = GirisResmi.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grafik_ciz(pictureBox3, GirisResmi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grafik_ciz(pictureBox4, CikisResmi);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int X1, X2, Y1, Y2;
            X1 = Convert.ToInt16(X1txt.Text);
            X2 = Convert.ToInt16(X2txt.Text);
            Y1 = Convert.ToInt16(Y1txt.Text);
            Y2 = Convert.ToInt16(Y2txt.Text);

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    int Gri = (R + G + B) / 3;

                    //*********** Kontras Formülü ***************
                    int X = Gri;
                    int Y = ((((X - X1) * (Y2 - Y1)) / (X2 - X1)) + Y1);
                    if (Y > 255) Y = 255;
                    if (Y < 0) Y = 0;
                    DonusenRenk = Color.FromArgb(Y, Y, Y);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox2.Refresh();
            pictureBox2.Image = null;
            pictureBox2.Image = CikisResmi;
           
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            CikisResmi_2 = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int X1, X2, Y1, Y2;
            X1 = Convert.ToInt16(X1txt.Text);
            X2 = Convert.ToInt16(X2txt.Text);
            Y1 = Convert.ToInt16(Y1txt.Text);
            Y2 = Convert.ToInt16(Y2txt.Text);

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    int Gri = (R + G + B) / 3;

                    //*********** Kontras Formülü ***************
                    int X = Gri;
                    int Y = ((X - X1) * Y2 / (X2 - X1));
                    if (Y > 255) Y = 255;
                    if (Y < 0) Y = 0;
                    DonusenRenk = Color.FromArgb(Y, Y, Y);
                    CikisResmi_2.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox5.Refresh();
            pictureBox5.Image = null;
            pictureBox5.Image = CikisResmi_2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grafik_ciz(pictureBox6, CikisResmi_2);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox5.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox6.Image = null;
        }

        private void grafik_ciz(PictureBox pictureBox, Bitmap resim)
        {
            
            ArrayList DiziPiksel = new ArrayList();
            int OrtalamaRenk = 0;
            Color OkunanRenk;

            for (int x = 0; x < resim.Width; x++)
            {
                for (int y = 0; y < resim.Height; y++)
                {
                    OkunanRenk = resim.GetPixel(x, y);
                    OrtalamaRenk = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3;
                    DiziPiksel.Add(OrtalamaRenk); //Resimdeki tüm noktaları diziye atıyor.
                }
            }
            int[] DiziPikselSayilari = new int[256];
            for (int r = 0; r < 255; r++) //256 tane renk tonu için dönecek.
            {
                int PikselSayisi = 0;
                for (int s = 0; s < DiziPiksel.Count; s++) //resimdeki piksel sayısınca dönecek.
                {
                    if (r == Convert.ToInt16(DiziPiksel[s])) PikselSayisi++;
                }
                DiziPikselSayilari[r] = PikselSayisi;
            }

            int RenkMaksPikselSayisi = 0; //Grafikte y eksenini ölçeklerken kullanılacak.
            int EnKucukRenkDegeri = 255;
            int EnBuyukRenkDegeri = 0;
            for (int k = 0; k <= 255; k++)
            {
                if (DiziPikselSayilari[k] > 10)
                {
                    if (k > EnBuyukRenkDegeri)
                        EnBuyukRenkDegeri = k;
                    if (k < EnKucukRenkDegeri)
                        EnKucukRenkDegeri = k;
                }
                listBox1.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]);
                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                }
            }

            X1txt.Text = EnKucukRenkDegeri.ToString();
            X2txt.Text = EnBuyukRenkDegeri.ToString();
            Y1txt.Text = "0";
            Y2txt.Text = "255";

            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.DarkRed, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.White, 2);
            pictureBox.Refresh();
            CizimAlani = pictureBox.CreateGraphics();

            int GrafikYuksekligi = 400;
            double OlcekY = (double)ResimYuksekligi / (double)RenkMaksPikselSayisi;
            double OlcekX = (double)ResimGenisligi / 255.0;
            int X1 = 0, Y1 = 0, X2 = 0, Y2 = 0;
            for (int x = 0; x <= 255; x++)
            {
                X1 = Convert.ToInt16(x * OlcekX);
                Y1 = ResimYuksekligi + 30;
                X2 = X1;
                Y2 = ResimYuksekligi - (int)(DiziPikselSayilari[x] * OlcekY);
                CizimAlani.DrawLine(Kalem1, X1, Y1 - 45, ResimYuksekligi, Y1 - 45);
                CizimAlani.DrawLine(Kalem1, X1, Y1 - 45, X2, Y2 - 45);
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, X1, Y1, X2, 0);
            }
        }
    }

    
}
