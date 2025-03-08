using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Temel Dizi Örnekleri

			// Aynı veri tipindeki çok sayıda verileri bir arada toplamaktır
			// DeğişkenTürü [] diziAdı = new DeğişkenTürü[ElemanSayısı]

			//int[] numbers = new int[10];
			//numbers[0] = 50;
			//numbers[1] = 60;
			//numbers[8] = 100;

			//Console.WriteLine(numbers[3]); // tam sayı tipindeki dizilerde tanımlanmamış indis 0 değerini alır.

			//char[] symbols = { 'A', '#', '^', '*', '/' };
			//for (int i = 0; i < symbols.Length; i++)
			//{
			//	Console.WriteLine(symbols[i]);
			//}

			// Dizideki en büyük elemanı bulan algoritma

			//int[] sayilar = { 12, 56, 78, 42, 96, 78, 41, 654, 3259, 87, 4521 };
			//int sayi = 0;

			//for (int i = 0; i < sayilar.Length; i++)
			//{
			//	if (sayilar[i] > sayi)
			//	{
			//		sayi = sayilar[i];
			//	}
			//}

			//Console.WriteLine(sayi);

			#endregion

			#region Dizi Metotları

			// int[] sayilar = { 256, 22, 78, 89, 45, 63, 112, 459, 548 };
			// Console.WriteLine(sayilar.Length);
			// Array.Sort(sayilar); // Dizi elemanlarını küçükten büyüğe sıralar
			// Array.Reverse(sayilar); // Diziyi tersten sıralar
			//for (int i = 0; i < sayilar.Length; i++)
			//{
			//	Console.WriteLine(sayilar[i]);
			//}

			//Console.WriteLine("Dizinin en büyük elemanı: "+ sayilar.Max() + "\nDizinin en küçük elemanı: " + sayilar.Min());

			//string[] customers = { "Ali", "Ahmet", "Mehmet", "Ayşe", "Fatma" };
			//int index = Array.IndexOf(customers, "ahmet"); 



			#endregion

			#region Kullanıcıdan Değer Alma

			//string[] cities = new string[5];

			//for (int i = 0; i < cities.Length; i++)
			//{
			//	Console.Write($"Lütfen {i + 1}. Şehri giriniz: "); // $ işareti çift tırnak içerisinde parametresel ifadeler kullanmamızı sağlar, {} içerine parametre 
			//	cities[i] = Console.ReadLine();
			//}

			//Console.WriteLine();
			//Console.WriteLine("----------------------");

			//for (int i = 0; i < cities.Length; i++)
			//{
			//	Console.WriteLine(cities[i]);
			//}

			// Kullancıdan alınan tam sayıların toplamını veren program

			//int[] sayilar = new int[5];
			//for (int i = 0; i < sayilar.Length; i++)
			//{
			//	sayilar[i] = int.Parse(Console.ReadLine());
			// }

			//Console.WriteLine("+_____\n"+sayilar.Sum());

			// Dizi içerisindeki tek ve çift sayıları ayrı ayrı listeleyen program

			//int[] sayilar = new int[10];
			//for (int i = 0; i < sayilar.Length; i++)
			//{
			//	sayilar[i] = int.Parse(Console.ReadLine());
			//}

			//Console.WriteLine("Çift sayılar: ");
			//for (int i = 0; i < sayilar.Length; i++)
			//{
			//	if (sayilar[i] % 2 == 0)
			//	{
			//		Console.WriteLine(sayilar[i]);
			//	}
			//}

			//Console.WriteLine("Tek sayılar: ");
			//for (int i = 0; i < sayilar.Length; i++)
			//{
			//	if (sayilar[i] % 2 != 0)
			//	{
			//		Console.WriteLine(sayilar[i]);
			//	}
			//}

			#endregion

			Console.Read();
		}
	}
}
