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
            //()
            //Geriye değer döndürmeyen metotlar (Void)
            //Customer --> Listele, Ekle, Sil, Güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Doğukan Koç");
            //    Console.WriteLine("Batuhan Koç");
            //    Console.WriteLine("Emirhan Koç");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Doğukan Koç");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("Doğukan", "Koç");
            //CustomerCard("Batuhan", "Koç");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,  int number2, int number3) 
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);
            #endregion


            #region Geriye Değer Döndüren Metotlar
            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());


            #endregion


            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int Sum(int x, int y)
            //{
            //    int result = x + y;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));



            #endregion

            #region Örnek Senaryo
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    Console.WriteLine(result);
                    return "Öğrenci sınavı geçti";
                }
                else
                {
                    Console.WriteLine(result);
                    return "Öğrenci başarısız oldu";
                }
            }
            string name;
            int s1, s2, s3;
            Console.Write("Öğrenci ismini giriniz: ");
            name = Console.ReadLine();
            Console.Write("1. Sınav notunu giriniz: ");
            s1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sınav notunu giriniz: ");
            s2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sınav notunu giriniz: ");
            s3 = int.Parse(Console.ReadLine());
            Console.WriteLine(ExamResult(name, s1, s2, s3));
            #endregion




            Console.Read();
        }
    }
}