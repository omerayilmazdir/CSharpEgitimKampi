using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region For Döngüsü

			//for (int i = 0;i <= 5; i++)
			//{
			//    Console.WriteLine("c# eğitim kampi");
			//}

			//for (int i = 3; i < 100; i+=3)
			//{
			//    Console.WriteLine(i);
			//}

			//Console.Write("Kaç defa yazılsın: ");
			//int finishValue= int.Parse(Console.ReadLine());

			//for (int i = 0; i < finishValue; i++)
			//{
			//    Console.WriteLine(i+1 + "-)c# eğitim kampı");
			//}

			//int totalValue = 0;

			//for (int i = 1; i <=10; i++)
			//{
			//    totalValue += i;
			//}

			//Console.WriteLine(totalValue);

			// 1-50 arasında 7 tam bölünen kaç sayı olduğunu bul

			//int sayac = 0;

			//for (int i = 1; i < 50; i++)
			//{
			//    if (i % 7 == 0)
			//    {
			//        Console.WriteLine(i);
			//        sayac++;
			//    }
			//}


			//Console.WriteLine("7 ye tam bölünen sayı adedi: "+sayac);

			// bir bakteri türü her saatin sonunda 2 ye bölünerek çoğalıyor, 24 saatte kaç bakteri olur?

			//int bakteri = 1;

			//for (int i = 1; i <= 24; i++)
			//{
			//    bakteri *= 2;
			//    Console.WriteLine(i+" .saat sonunda: "+bakteri);
			//}



			#endregion

			#region While Döngüsü



			#endregion

			#region Örnek Soru

			// Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu

			//Console.Write("3 Basamaklı sayıyı giriniz: ");
			//int sayi = int.Parse(Console.ReadLine());

			//int birler = sayi % 10;
			//int yuzler = sayi / 100;
			//int onlar = (sayi % 100) / 10;
			//int toplam = birler + onlar + yuzler;
			//Console.WriteLine(yuzler + "+" + onlar + "+" + birler + " = " + toplam);


			#endregion


			Console.Read();
		}
	}
}
