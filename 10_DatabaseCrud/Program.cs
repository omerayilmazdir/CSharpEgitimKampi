using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// CRUD --> Create, Read, Update, Delete

			Console.WriteLine("******* Menü Sipariş İşlem Paneli ********");
			Console.WriteLine();

			Console.WriteLine("-----------------------------------------");

			#region Ürün Ekleme İşlemi

			//string productName;
			//decimal productPrice;
			//// bool productStatus;

			//Console.Write("Ürün adı: ");
			//productName = Console.ReadLine();
			//Console.Write("Ürün fiyatı: ");
			//productPrice = decimal.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GJCHEVE\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security = true;");
			//connection.Open();

			//SqlCommand command = new SqlCommand("insert into Tbl_Product (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)",connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productStatus", true);
			//command.ExecuteNonQuery();

			//connection.Close();

			//Console.Write("Ürün eklemesi başarılı!");


			#endregion

			#region Kategori Ekleme İşlemi

			//Console.Write("Eklemek İstediğiniz Kategori Adı: ");
			//string categoryName = Console.ReadLine();

			//// SQL bağlantısı oluşturma
			//// Data nın kaynağı ---  Veritabanı ismi  --- güvenilir mi?
			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GJCHEVE\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security = true;");
			//connection.Open();

			//// Ekleme işlemi yapalım
			//// öncelikle SqlCommand ile sorgumuzu yazıyoruz
			//SqlCommand command = new SqlCommand("insert into Tbl_Category (CategoryName) values (@p1)", connection); 
			//// ekleme işlemi için parametreye denk gelen değişkene atıyoruz
			//command.Parameters.AddWithValue("@p1", categoryName);
			//// koşulsuz bir şekilde sorguyu çalıştır diyoruz
			//command.ExecuteNonQuery();

			//connection.Close();

			//Console.Write("Kategori başarıyla eklendi!");

			#endregion

			#region Ürün Listeleme İşlemi

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GJCHEVE\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security = true;");
			//connection.Open();

			//SqlCommand command = new SqlCommand("select * from Tbl_Product", connection);
			//SqlDataAdapter adapter = new SqlDataAdapter(command); // sql deki verileri c# tarafına çeken köprüdür
			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);

			//// satır ve sütunları dönelim
			//foreach (DataRow row in dataTable.Rows)
			//{
			//	foreach (var item in row.ItemArray)
			//	{
			//		Console.Write(item.ToString() + " ");
			//	}
			//	Console.WriteLine();
			//}

			//connection.Close();

			#endregion

			#region Ürün Silme İşlemi

			//Console.Write("Silinecek Ürün Id: ");
			//int productId = int.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GJCHEVE\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security = true;");
			//connection.Open();

			//SqlCommand command = new SqlCommand("delete from Tbl_Product where ProductID=@productId", connection);
			//command.Parameters.AddWithValue("@productId", productId);
			//command.ExecuteNonQuery();

			//connection.Close();

			//Console.WriteLine("Ürün başarıyla silindi.");

			#endregion

			#region Ürün Güncelleme İşlemi

			//Console.Write("Güncellenecek Ürün Id: ");
			//int productId = int.Parse(Console.ReadLine());
			//Console.Write("Güncellenecek Ürün Adı: ");
			//string productName = Console.ReadLine();
			//Console.Write("Güncellenecek Ürün Fiyatı: ");
			//decimal productPrice = decimal.Parse(Console.ReadLine());	

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GJCHEVE\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security = true;");
			//connection.Open();

			//SqlCommand command = new SqlCommand("update Tbl_Product set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productId", productId);
			//command.ExecuteNonQuery();


			//connection.Close();

			//Console.WriteLine("Güncelleme işlemi başarıyla gerçekleştirilmiştir.");
			#endregion

			Console.Read();

		}
	}
}
