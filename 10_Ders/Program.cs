using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CRUD İşlemleri --> Create-Read-Update-Delete

            //Console.WriteLine("|----- Menü Sipariş İşlem Paneli -----|");
            //Console.WriteLine();

            //Console.WriteLine("--------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GHP8JEF; initial catalog=EgitimKampiDB; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", 
            //    connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi!");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Eklemek İstediğiniz Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GHP8JEF; initial catalog=EgitimKampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true); //Default olarak true ataması yaptık.
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürünler başarıyla eklendi!");


            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GHP8JEF; initial catalog=EgitimKampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID'si: ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GHP8JEF; initial catalog=EgitimKampiDB; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductID=@productID", connection);

            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürünler başarıyla silindi!");

            #endregion

            #region Ürün Güncelleme İşlemi
            
            //Console.Write("Güncellenecek Ürün ID'si: ");
            //int productID = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GHP8JEF; initial catalog=EgitimKampiDB; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductID=@productID",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürünler başarıyla güncellendi!");

            #endregion

            Console.Read();
        }
    }
}
