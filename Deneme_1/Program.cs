using System;
using System.Drawing;

namespace Deneme_1
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Bitmap GirisResmi, CikisResmi;
			GirisResmi = new Bitmap();

			int ResimGenisligi = GirisResmi.Width;
			int ResimYuksekligi = GirisResmi.Height;
			int[,] imageMatrix = new int[ResimYuksekligi, ResimGenisligi];

			// Her piksel için döngü
			for (int y = 0; y < ResimYuksekligi; y++)
			{
				for (int x = 0; x < ResimGenisligi; x++)
				{
					// Pikselin rengini al
					Color pixelColor = GirisResmi.GetPixel(x, y);

					// Piksel değerini 0-255 arasında bir gri tonuna dönüştür
					int grayValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);

					// Resim matrisine piksel değerini ata
					imageMatrix[y, x] = grayValue;
				}
			}

			// Resim matrisini yazdır
			for (int y = 0; y < ResimYuksekligi; y++)
			{
				for (int x = 0; x < ResimGenisligi; x++)
				{
					Console.Write(imageMatrix[y, x] + " ");
				}
				Console.WriteLine();
			}

		}
	}
	}
}
