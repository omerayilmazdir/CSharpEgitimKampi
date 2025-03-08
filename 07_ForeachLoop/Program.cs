using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Foreach Döngüsü

			// Foreach(1;2;3;4)
			/*
			1: Değişken türü
			2: Değişken adı
			3: In
			4: Liste, Koleksiyon, Dizi
			 
			*/
			//string[] cities = { "İstanbul", "Ankara", "Kocaeli", "İzmir", "Kars", "Bursa", "Balıkesir", "Yalova" };
			//foreach (var city in cities)
			//{
			//	Console.WriteLine(city);
			//}

			// Listelerle foreach

			//List<int> numbers = new List<int>()
			//{
			//	1,2, 3, 4, 5, 6, 7
			//};

			//foreach (var number in numbers)
			//{
			//	Console.WriteLine(number);
			//}

			// Kelimeyi harflerine ayırma

			//string word = "Merhaba";
			//foreach (char c in word)
			//{
			//	Console.Write(" " + c);
			//}



			#endregion

			#region Örnek Sınav Sistemi Uygulaması

			//Console.WriteLine("*********** SINAV SİSTEMİ UYGULAMASI ***********");
			//Console.WriteLine();
			//Console.WriteLine();
			//Console.WriteLine();
			//Console.WriteLine();

			//// Kullanıcıdan öğrenci sayısı alma
			//Console.WriteLine("-------------------------------------------------");
			//Console.Write("Sınıftaki öğrenci sayısı kaç: ");
			//int studentCount = int.Parse(Console.ReadLine());
			//Console.WriteLine("-------------------------------------------------");

			//// Öğrenci isimlerini ve not ortalamaları al
			//string[] studentNames = new string[studentCount];
			//double[] studentExamAvg = new double[studentCount];

			//for (int i = 0; i < studentCount; i++)
			//{
			//	Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
			//	studentNames[i] = Console.ReadLine();

			//	double totalExamResult = 0;

			//	// Her öğrenci için 3 sınav notu girişi
			//	for (int j = 0; j < 3; j++)
			//	{
			//		Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
			//		double value = double.Parse(Console.ReadLine());
			//		totalExamResult += value;
			//	}
			//	Console.WriteLine();

			//	studentExamAvg[i] = totalExamResult / 3;
			//}

			//// Öğrencilerin ortalaması ile geçip kalma durumu 

			//for (int i = 0; i < studentCount; i++)
			//{
			//	Console.WriteLine("-------------------------------------------------");
			//	Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

			//	if (studentExamAvg[i] >= 50)
			//	{
			//		Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti");
			//	}
			//	else
			//	{
			//		Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı");
			//	}
			//	Console.WriteLine("-------------------------------------------------");
			//}



			#endregion

			Console.Read();
		}
	}
}
