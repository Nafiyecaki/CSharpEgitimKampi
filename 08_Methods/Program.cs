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
            #region Void metotlar
            //geriye değer döndürmeyen metotlar
            //customer -->listele,ekle,sil,güncelle
            //void

            //void customerList()
            //{
            //    Console.WriteLine("ali yıldız");
            //    Console.WriteLine("ayşe yıldız");
            //    Console.WriteLine("hakan öztürk");
            //    Console.WriteLine("merve çınar");
            //}

            //customerList();

            //void sum() 
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();




            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("mehmet yıldırım");


            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("müşteri: " + name + " " + surname);
            //}
            //CustomerCard("mehmet", "yıldız");
            //CustomerCard("ayşegül", "kaya");

            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void sum(int number1, int number2,int number3) 
            // {
            // int result=number1+number2+number3;
            //     Console.WriteLine(result);
            // }
            // sum(4, 5, 6);
            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "buse yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "yıldız";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region geriye değer döndüren parametreli metotlar

            // string CountryCard(string countryName,string capital, string flagColor)
            // {
            //     string cardInfo = "ülke: " + countryName + "- başkent:" + capital + "-bayrak rengi: " + flagColor;
            //     return cardInfo;
            // }
            // string x, y, z;
            // Console.Write("ülke adını giriniz: ");
            // x=Console.ReadLine();

            // Console.Write("başkenti giriniz: ");
            // y=Console.ReadLine();

            // Console.Write("bayrak rengini giriniz: ");
            // z=Console.ReadLine();

            //Console.WriteLine( CountryCard(x, y, z));

            // Console.WriteLine(CountryCard("türkiye", "ankara", "kırmızı-beyaz"));
            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int sum(int number1,int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(45, 98));
            //Console.WriteLine(sum(36, 25));
            //Console.WriteLine(sum(44, 36));
            //Console.WriteLine(sum(14, 20));

            #endregion

            #region öğrenci sınav sistemi
            string examResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti " + "ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavdan kaldı" + " ortalama: " + result;
                }
            }
            Console.WriteLine(examResult("ali", 25, 41, 5));
            Console.WriteLine(examResult("ayşe", 36, 88, 33));


            #endregion
            Console.Read();
        }
    }
}