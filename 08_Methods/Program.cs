using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Void Metotlar

			// Geriye değer döndüren ve döndürmeyen metotlar olarak ayrılır
			// Geriye değer döndürmeyen >> void

			//void CustomerList()
			//{
			//	Console.WriteLine("Ömer");
			//	Console.WriteLine("Ayılmazıdr");
			//	Console.WriteLine("İstanbul/Pendik");
			//}

			//CustomerList();




			#endregion

			#region Geriye Değer Döndürmeyen Parametreli Metotlar

			//void WriteMethod(string customerName)
			//{
			//	Console.WriteLine(customerName);
			//}

			//WriteMethod("Ömer Ayılmazdır");

			//void CustomerCard(string name, string surName)
			//{
			//	Console.WriteLine("Müşteri: " + name + " " + surName);
			//}

			//CustomerCard("Ömer", "Ayılmazdır");
			//CustomerCard("Ali", "Demir");

			//void Sum(int x, int y,int z)
			//{
			//	Console.WriteLine(x + y + z);
			//}

			//Sum(11, 45, 89);

			#endregion

			#region Geriye Değer Döndüren Metotlar

			// Metodun başında geriye dönecek olan değerin veri tipi yazılır

			//string CustomerName()
			//{
			//	return "Ömer Ayılmazdır"; // değer olarak döneceği için ekrana bir şey yazdırmaz
			//}

			//CustomerName();

			// Geriye dönen değeri ekrana yazdırma
			//string StudentCard()
			//{
			//	string name = "Ömer";
			//	string surName = "Ayılmazdır";
			//	return name + " " + surName;
			//}

			//Console.WriteLine(StudentCard());

			#endregion

			#region Geriye Değer Döndüren Parametreli Metotlar

			//string StudentCard(string name, int age, string school)
			//{
			//	string cardInfo = "İsim: " + name + " Yaş: " + age + " Okul: " + school;
			//	return cardInfo;
			//}

			//string x,z;
			//int y;
			//Console.Write("İsim: ");
			//x = Console.ReadLine();
			//Console.Write("Yaş: ");
			//y = int.Parse(Console.ReadLine());
			//Console.Write("Okul: ");
			//z = Console.ReadLine();

			//Console.WriteLine(StudentCard(x,y,z));


			//string ExamResult(string name, int ex1, int ex2, int ex3)
			//{
			//	int result = (ex1 + ex2 + ex3) / 3;
			//	if (result >= 50)
			//	{
			//		return name + " dersi geçti." + "\nOrtalama: " + result;
			//	}
			//	else
			//	{
			//		return name + " dersten kaldı!" + "\nOrtalama: " + result;
			//	}
			//}

			//Console.WriteLine(ExamResult("Ömer", 50, 75, 92));


			#endregion

			Console.Read();

		}
	}
}
