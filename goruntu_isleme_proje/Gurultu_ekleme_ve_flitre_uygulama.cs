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
    public partial class Gurultu_ekleme_ve_flitre_uygulama : Form
    {
        public Gurultu_ekleme_ve_flitre_uygulama()
        {
            InitializeComponent();
        }
        Bitmap GirisResmi, CikisResmi, CikisResmiMean, CikisResmiMedian;
        int ResimGenisligi, ResimYuksekligi;
        int R = 0, G = 0, B = 0;

       
        Color OkunanRenk;
        private void btnResimAl_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "İşlem için bir görüntü seçin!";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            GirisResmi = new Bitmap(pictureBox1.ImageLocation);
            ResimGenisligi = GirisResmi.Width;
            ResimYuksekligi = GirisResmi.Height;
        }

        private void btnGurultuEkle_Click(object sender, EventArgs e)
        {
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            try
            {
                Random rand = new Random();

                for (int i = 0; i < ResimGenisligi; i++)
                {
                    for (int j = 0; j < ResimYuksekligi; j++)
                    {
                        int num = rand.Next(1, 75);
                        OkunanRenk = GirisResmi.GetPixel(i, j);
                        R = Math.Abs(Convert.ToInt32(OkunanRenk.R) - Convert.ToInt32(OkunanRenk.R) / num);
                        G = Math.Abs(Convert.ToInt32(OkunanRenk.G) - Convert.ToInt32(OkunanRenk.R) / num);
                        B = Math.Abs(Convert.ToInt32(OkunanRenk.B) - Convert.ToInt32(OkunanRenk.R) / num);

                        Color renk = Color.FromArgb(255, R, G, B);

                        CikisResmi.SetPixel(i, j, renk);
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
            catch
            {
                MessageBox.Show("Lütfen Fotoğraf Seçiniz!");
            }
        }

        private void btnMeanFiltre_Click(object sender, EventArgs e)
        {
            CikisResmiMean = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu = Convert.ToInt32(textBox1.Text);
            //şablon boyutu 3 den büyük tek rakam olmalıdır(3, 5, 7 gibi).
            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = CikisResmi.GetPixel(x + i, y + j);
                            toplamR = toplamR + OkunanRenk.R;
                            toplamG = toplamG + OkunanRenk.G;
                            toplamB = toplamB + OkunanRenk.B;
                        }
                    }
                    ortalamaR = toplamR / (SablonBoyutu * SablonBoyutu);
                    ortalamaG = toplamG / (SablonBoyutu * SablonBoyutu);
                    ortalamaB = toplamB / (SablonBoyutu * SablonBoyutu);
                    CikisResmiMean.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                }
            }
            pictureBox3.Image = CikisResmiMean;


        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            CikisResmiMedian = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu = 0;
            try
            {
                SablonBoyutu = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                SablonBoyutu = 3;
            }
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int[] R = new int[ElemanSayisi];
            int[] G = new int[ElemanSayisi];
            int[] B = new int[ElemanSayisi];
            int[] Gri = new int[ElemanSayisi];
            int x, y, i, j;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                    int k = 0;
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = CikisResmi.GetPixel(x + i, y + j);
                            R[k] = OkunanRenk.R;
                            G[k] = OkunanRenk.G;
                            B[k] = OkunanRenk.B;
                            Gri[k] = Convert.ToInt16(R[k] * 0.299 + G[k] * 0.587 + B[k] * 0.114); //Gri ton formülü
                            k++;
                        }

                    }

                    //Gri tona göre sıralama yapıyor. Aynı anda üç rengide değiştiriyor.
                    int GeciciSayi = 0;
                    for (i = 0; i < ElemanSayisi; i++)
                    {
                        for (j = i + 1; j < ElemanSayisi; j++)
                        {
                            if (Gri[j] < Gri[i])
                            {
                                GeciciSayi = Gri[i];
                                Gri[i] = Gri[j];
                                Gri[j] = GeciciSayi;
                                GeciciSayi = R[i];
                                R[i] = R[j];
                                R[j] = GeciciSayi;
                                GeciciSayi = G[i];
                                G[i] = G[j];
                                G[j] = GeciciSayi;
                                GeciciSayi = B[i];
                                B[i] = B[j];
                                B[j] = GeciciSayi;
                            }
                        }
                    }
                    //Sıralama sonrası ortadaki değeri çıkış resminin piksel değeri olarak atıyor.
                    CikisResmiMedian.SetPixel(x, y, Color.FromArgb(R[(ElemanSayisi - 1) / 2], G[(ElemanSayisi - 1) /
                   2], B[(ElemanSayisi - 1) / 2]));
                }
            }
            pictureBox4.Refresh();
            pictureBox4.Image = CikisResmiMedian;
        }
    }
}
