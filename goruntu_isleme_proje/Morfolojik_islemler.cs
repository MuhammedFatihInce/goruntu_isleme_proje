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
        Bitmap GirisResmi;


        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "İşlem için bir görüntü seçin!";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            GirisResmi = new Bitmap(pictureBox1.ImageLocation);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap genislemisResim = Genisleme(GirisResmi);

            Bitmap kapanmisResim = Asınma(genislemisResim);
            pictureBox5.Image = kapanmisResim;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap genislemisResim = Genisleme(GirisResmi);
            
            pictureBox2.Image = genislemisResim;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap asınmısResim = Asınma(GirisResmi);

            pictureBox3.Image = asınmısResim;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Bitmap asınmısResim = Asınma(GirisResmi); ;

            Bitmap acılmisResim = Genisleme(asınmısResim);

            pictureBox4.Image = acılmisResim;


        }

        public static Bitmap Genisleme(Bitmap image)
        {
            Color KendiRengi, KomsuRengi;

            int iterations = 4;

            int width = image.Width;
            int height = image.Height;

            Bitmap result = new Bitmap(width, height);

            int SablonBoyutu = 3;

            for (int iter = 0; iter < iterations; iter++)
            {
                for (int x = (SablonBoyutu - 1) / 2; x < width - (SablonBoyutu - 1) / 2; x++)
                {
                    for (int y = (SablonBoyutu - 1) / 2; y < height - (SablonBoyutu - 1) / 2; y++)
                    {
                        bool KomsulardaBeyazRenkVar = false;
                        KendiRengi = image.GetPixel(x, y);
                        if (KendiRengi.R < 128) 
                        {
                            for (int i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                            {
                                for (int j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                                {
                                    KomsuRengi = image.GetPixel(x + i, y + j);
                                    if (KomsuRengi.R > 128) 
                                        KomsulardaBeyazRenkVar = true;
                                }
                            }
                            if (KomsulardaBeyazRenkVar == true)
                            {

                                result.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                                
                            }
                            else
                            {
                                result.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                            }
                        }
                        else 
                        {
                            result.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                    }
                }
                image = result.Clone() as Bitmap;
            }
          
            return result;
        }
        public static Bitmap Asınma(Bitmap image)
        {
            int iterations = 4;
            int width = image.Width;
            int height = image.Height;
            
            Bitmap result = new Bitmap(width, height);

            int SablonBoyutu = 3;
            int yarimSablon = (SablonBoyutu - 1) / 2;

            
            for (int iter = 0; iter < iterations; iter++)
            {
                for (int x = yarimSablon; x < width - yarimSablon; x++)
                {
                    for (int y = yarimSablon; y < height - yarimSablon; y++)
                    {
                        Color KendiRengi = image.GetPixel(x, y);
                        if (KendiRengi.R > 128)
                        {
                            bool KomsulardaSiyahVar = false;
                            for (int i = -yarimSablon; i <= yarimSablon; i++)
                            {
                                for (int j = -yarimSablon; j <= yarimSablon; j++)
                                {
                                    Color KomsuRengi = image.GetPixel(x + i, y + j);
                                    if (KomsuRengi.R < 128)
                                    {
                                        KomsulardaSiyahVar = true;
                                        break;
                                    }
                                }
                                if (KomsulardaSiyahVar) break;
                            }
                            if (KomsulardaSiyahVar)
                            {
                                result.SetPixel(x, y, Color.FromArgb(0, 0, 0)); 
                            }
                            else
                            {
                                result.SetPixel(x, y, Color.FromArgb(255, 255, 255)); 
                            }
                        }
                        else
                        {
                            result.SetPixel(x, y, Color.FromArgb(0, 0, 0)); 
                        }
                    }
                }
                image = result.Clone() as Bitmap;
            }
           
            return result;
        }
    }
}
