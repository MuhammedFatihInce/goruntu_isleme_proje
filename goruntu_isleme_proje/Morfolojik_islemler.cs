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
    public partial class Morfolojik_islemler : Form
    {
        public Morfolojik_islemler()
        {
            InitializeComponent();
        }
        Bitmap GirisResmi, CikisResmi, CikisResmi_2, CikisResmiMedian;
        int ResimGenisligi, ResimYuksekligi;

        int R = 0, G = 0, B = 0;

       

        Color KendiRengi, KomsuRengi;
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "İşlem için bir görüntü seçin!";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            GirisResmi = new Bitmap(pictureBox1.ImageLocation);
            ResimGenisligi = GirisResmi.Width;
            ResimYuksekligi = GirisResmi.Height;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int x, y, i, j;
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            //***********************BEYAZLARI ERİTECEK- SİYAHLARI GENİŞLETECEK
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi  taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    bool KomsulardaBeyazRenkVar = false;
                    KendiRengi = GirisResmi.GetPixel(x, y);
                    if (KendiRengi.R < 128) //Kendi rengi siyahsa, komşuları tara beyaz bulabilecek  misin ?
                    {
                        for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                        {
                            for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                            {
                                KomsuRengi = GirisResmi.GetPixel(x + i, y + j);
                                if (KomsuRengi.R > 128) //Komsu rengi beyaz ise
                                    KomsulardaBeyazRenkVar = true;
                            }
                        }
                        if (KomsulardaBeyazRenkVar == true) //Madem komsularda beyaz renk var, o zaman kendi rengini de beyaz yap.
                        {

                            CikisResmi.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                            //CikisResmi.SetPixel(x, y, Color.FromArgb(255, 0, 0));
                        }
                        else //komşularda siyah yok ise kendi rengi yine aynı beyaz kalmalı.
                        {
                            CikisResmi.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                    }
                    else //Kendi rengi beyaz ise beyaz kal..
                    {
                        CikisResmi.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            pictureBox2.Image = CikisResmi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CikisResmi_2 = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int x, y, i, j;
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            //***********************BEYAZLARI ERİTECEK- SİYAHLARI GENİŞLETECEK
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi  taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    bool KomsulardaSiyahVar = false;
                    KendiRengi = GirisResmi.GetPixel(x, y);
                    if (KendiRengi.R > 128)
                    {
                        for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                        {
                            for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                            {
                                KomsuRengi = GirisResmi.GetPixel(x + i, y + j);
                                if (KomsuRengi.R < 128)
                                    KomsulardaSiyahVar = true;
                            }
                        }
                        if (KomsulardaSiyahVar == true) //Madem komsularda beyaz renk var, o zaman kendi  rengini de beyaz yap.
                        {
                            CikisResmi_2.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                            //CikisResmi.SetPixel(x, y, Color.FromArgb(255, 0, 0));
                        }
                        else //komşularda siyah yok ise kendi rengi yine aynı beyaz kalmalı.
                        {
                            CikisResmi_2.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                    }
                    else //Kendi rengi beyaz ise beyaz kal..
                    {
                        CikisResmi_2.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            pictureBox3.Image = CikisResmi_2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CikisResmi = new Bitmap(GirisResmi.Width, GirisResmi.Height);
            //int threshold = Convert.ToInt32(textBox1.Text);
            //for (int y = 0; y < GirisResmi.Height; y++)
            //{
            //    for (int x = 0; x < GirisResmi.Width; x++)
            //    {
            //        Color originalColor = GirisResmi.GetPixel(x, y);

            //        int averageColor = (originalColor.R + originalColor.G + originalColor.B) / 3;

            //        Color newColor = (averageColor >= threshold) ? Color.White : Color.Black;

            //        CikisResmi.SetPixel(x, y, newColor);
            //    }
            //}


            //int width = image.Width;
            //int height = image.Height;
            //Bitmap result = new Bitmap(width, height);

            //for (int y = 1; y < height - 1; y++)
            //{
            //    for (int x = 1; x < width - 1; x++)
            //    {
            //        bool erodePixel = true;

            //        for (int j = -1; j <= 1; j++)
            //        {
            //            for (int i = -1; i <= 1; i++)
            //            {
            //                Color pixelColor = image.GetPixel(x + i, y + j);
            //                if (pixelColor.R > 0)
            //                {
            //                    erodePixel = false;
            //                    break;
            //                }
            //            }
            //            if (!erodePixel) break;
            //        }

            //        result.SetPixel(x, y, erodePixel ? Color.Black : Color.White);
            //    }
            //}

        }

    }
}
