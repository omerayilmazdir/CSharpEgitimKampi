using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region If Else

			// sınav sonuçlarına göre harf notu

			//int exam1, exam2, exam3, average;
			//string result;

			//Console.Write("Sınav 1: ");
			//exam1 = int.Parse(Console.ReadLine());
			//Console.Write("Sınav 2: ");
			//exam2 = int.Parse(Console.ReadLine());
			//Console.Write("Sınav 3: ");
			//exam3 = int.Parse(Console.ReadLine());

			//average = (exam1 + exam2 + exam3) / 3;
			//Console.Write("Sınav ortlaması: " + average);
			//Console.WriteLine();

			//if (average > 0 && average <= 30)
			//{
			//	Console.Write("Harf Notu: C");
			//}
			//else if (average > 30 && average <= 60)
			//{
			//	Console.Write("Harf Notu: B");
			//}
			//else if (average > 60 && average <= 100)
			//{
			//	Console.Write("Harf Notu: A");
			//}
			//else
			//{
			//	Console.Write("Hatalı not girişi");
			//}



			#endregion

			#region Mod İşlemleri
			//int number = 26;
			//int result = number % 5;
			//Console.WriteLine(result);


			// Bölümünden kalanı bulma
			//int sayi1, sayi2, sonuc;

			//Console.Write("Sayı1 :");
			//sayi1 = int.Parse(Console.ReadLine());

			//Console.Write("Sayı2 :");
			//sayi2 = int.Parse(Console.ReadLine());

			//sonuc = sayi1%sayi2;

			//Console.WriteLine(sayi1 + " in " + sayi2 + " ye bölümünden kalan: " + sonuc);

			//Console.Read();

			#endregion

			#region Örnek Proje Uygulaması

			//Console.WriteLine("****** C# Restoran ******");
			//Console.WriteLine();
			//Console.WriteLine("-------------------------");
			//Console.WriteLine("1-Ana Yemekler");
			//Console.WriteLine("2-Çorbalar");
			//Console.WriteLine("3-İçecekler");
			//Console.WriteLine("4-Tatlılar");
			//Console.WriteLine("-------------------------");
			//Console.WriteLine();

			//string menuItem;
			//Console.Write("Menü seçimi yapınız: ");
			//menuItem = Console.ReadLine();

			//if (menuItem == "1") 
			//{
			//	Console.WriteLine("---------- Ana Yemekler ---------");
			//	Console.WriteLine("1-Izgara Köfte");
			//	Console.WriteLine("2-Tavuk");
			//	Console.WriteLine("3-Fasulye");
			//	Console.WriteLine("---------- Ana Yemekler ---------");
			//}
			//else if (menuItem == "2")
			//{
			//	Console.WriteLine("---------- Çorbalar ---------");
			//	Console.WriteLine("1-Mercimek");
			//	Console.WriteLine("2-Tarhana");
			//	Console.WriteLine("3-Ezogelin");
			//	Console.WriteLine("4-Tavuksuyu");
			//	Console.WriteLine("---------- Çorbalar ---------");
			//}
			//else if (menuItem == "3")
			//{
			//	Console.WriteLine("---------- İçecekler ---------");
			//	Console.WriteLine("1-Kola");
			//	Console.WriteLine("2-Soda");
			//	Console.WriteLine("3-Ayran");
			//	Console.WriteLine("4-Limonata");
			//	Console.WriteLine("---------- İçecekler ---------");
			//}
			//else if (menuItem == "4")
			//{
			//	Console.WriteLine("---------- Tatlılar ---------");
			//	Console.WriteLine("1-Trileçe");
			//	Console.WriteLine("2-Baklava");
			//	Console.WriteLine("3-Sütlaç");
			//	Console.WriteLine("---------- Tatlılar ---------");
			//}
			//else
			//{
			//	Console.WriteLine("Yanlış seçim yaptınız!");
			//}

			#endregion

			#region Switch Case

			//Console.Write("Ay seçimi yapınız: ");
			//int monthSelect = int.Parse(Console.ReadLine());

			//switch (monthSelect)
			//{
			//	case 1:
			//		Console.WriteLine("Ocak");
			//		break;
			//	case 2:
			//		Console.WriteLine("Şubat");
			//		break;
			//	case 3:
			//		Console.WriteLine("Mart");
			//		break;
			//	case 4:
			//		Console.WriteLine("Nisan");
			//		break;
			//	case 5:
			//		Console.WriteLine("Mayıs");
			//		break;
			//	case 6:
			//		Console.WriteLine("Haziran");
			//		break;
			//	case 7:
			//		Console.WriteLine("Temmuz");
			//		break;
			//	case 8:
			//		Console.WriteLine("Ağustos");
			//		break;
			//	case 9:
			//		Console.WriteLine("Eylül");
			//		break;
			//	case 10:
			//		Console.WriteLine("Ekim");
			//		break;
			//	case 11:
			//		Console.WriteLine("Kasım");
			//		break;
			//	case 12:
			//		Console.WriteLine("Aralık");
			//		break;
			//	default:
			//		break;
			//}

			#endregion

			#region Switch Case Hesap Makinesi

			//double number1, number2, result;
			//Console.Write("1. Sayı: ");
			//number1 = double.Parse(Console.ReadLine());
			//Console.Write("2.Sayı: ");
			//number2 = double.Parse(Console.ReadLine());

			//Console.Write("Yapmak istediğiniz işlemin sembolünü girin: ");
			//char symbol = char.Parse(Console.ReadLine());

			//switch (symbol)
			//{
			//	case '/':
			//		result = number1 / number2;
			//		Console.WriteLine("İşleminizin sonucu: "+result);
			//		break;
			//	case '*':
			//		result = number1 * number2;
			//		Console.WriteLine("İşleminizin sonucu: " + result);
			//		break;
			//	case '-':
			//		result = number1 - number2;
			//		Console.WriteLine("İşleminizin sonucu: " + result);
			//		break;
			//	case '+':
			//		result = number1 + number2;
			//		Console.WriteLine("İşleminizin sonucu: " + result);
			//		break;
			//	default:
			//		break;
			//}

			


			#endregion


			Console.Read();

		}
	}
}
