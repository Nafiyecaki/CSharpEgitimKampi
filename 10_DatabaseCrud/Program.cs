﻿using System;
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

            // Crud-->Create-read-update-delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection(" Data Source= NAFIYE; " +
            //    "initial catalog = EgitimKampiDb; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi ");


            #endregion

            #region Ürün Ekleme İşlemi
            // string productName;
            // decimal productPrice;
            //// bool productStatus;

            // Console.Write("Ürün Adı: ");
            // productName=Console.ReadLine();
            // Console.Write("Ürün Fiyatı: ");
            // productPrice=decimal.Parse(Console.ReadLine());

            // SqlConnection connection = new SqlConnection("Data Source=NAFIYE; initial catalog=EgitimKampiDb;" +
            //     "integrated security=true");
            // connection.Open();
            // SqlCommand command = new SqlCommand("insert into TblProduct(ProductName, ProductPrice,ProductStatus) values" +
            //     "(@productName, @productPrice,@productStatus)", connection);
            // command.Parameters.AddWithValue("@productName", productName);
            // command.Parameters.AddWithValue("@productPrice", productPrice);
            // command.Parameters.AddWithValue("@productStatus", true);
            // connection.Close();
            // Console.Write("Ürün eklemesi başarılı!");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=NAFIYE; initial catalog=EgitimKampiDb;" +
            // "integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);


            //foreach (DataRow row in dt.Rows)
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

            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());    

            //SqlConnection connection = new SqlConnection("Data Source=NAFIYE; initial catalog=EgitimKampiDb;" +
            // "integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı!");


            #endregion

            #region 
            #endregion

            Console.Read();


        }
    }
}