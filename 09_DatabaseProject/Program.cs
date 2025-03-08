using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Ado.net c# içerisinde sql yapılarını kullanmamızı sağlayan çerçevedir

			Console.WriteLine("********* C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *********");
			Console.WriteLine();
			Console.WriteLine();

			string tableNumber;

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("1-Kategoriler");
			Console.WriteLine("2-Ürünler");
			Console.WriteLine("3-Siparişler");
			Console.WriteLine("4-Çıkış Yap");
			Console.Write("Lütfen yapmak istediğiniz işlem numarasını giriniz: ");
			tableNumber = Console.ReadLine();
			Console.WriteLine("---------------------------------------");

			// SINIF       NESNE      Bu nesne ile ilgili kullanılanlar da PROPERTYLERDİR
			SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GJCHEVE\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security = true;");
			connection.Open();

			SqlCommand command = new SqlCommand("Select * From Tbl_Category", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);

			connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
				Console.WriteLine();
            }


            Console.Read();
		}
	}
}
