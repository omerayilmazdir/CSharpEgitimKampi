﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Yıldızlarla işlemler

			// 10 tane alt alta

			//for (int i = 1; i <=10; i++)
			//{
			//    Console.WriteLine("*");
			//}

			// 10 tane yan yana

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.Write("*");
			//}




			#endregion

			#region Dik üçgen

			//for (int i = 1; i <= 5; i++)
			//{
			//    for (int j = 1; j <= i; j++)
			//    {
			//        Console.Write("*");
			//    }
			//    Console.WriteLine();
			//}


			#endregion

			#region Ters Dik Üçgen

			//for (int i = 5; i >= 1; i--)
			//{
			//    for (int j = 1; j <= i; j++)
			//    {
			//        Console.Write("*");
			//    }
			//    Console.WriteLine();
			//}

			#endregion

			#region Dik ve Ters Beraber

			//for (int i = 1; i <= 5; i++)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			//for (int i = 4; i >= 1; i--)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Piramit

			//int n = 5;

			//for (int i = 1; i <= n; i++)
			//{
			//	for (int j = n - i; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	for (int k = 1; k <= 2 * i - 1; k++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Ters Piramit

			//int n = 5;

			//for (int i = n; i >= 1; i--)
			//{
			//	for (int j = n - i; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	for (int k = 1; k <= 2 * i - 1; k++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();

			//}

			#endregion

			#region Baklava Dilimi

			//int n = 5;

			//for (int i = 1; i <= n; i++)
			//{
			//	for (int j = n - i; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	for (int k = 1; k <= 2 * i - 1; k++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}



			//int m = 5;

			//for (int i = m; i >= 1; i--)
			//{
			//	for (int j = m - i; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	for (int k = 1; k <= 2 * i - 1; k++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();

			//}

			#endregion


			Console.Read();
		}
	}
}
