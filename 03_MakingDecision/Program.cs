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
            #region if else
            //Console.Write("lütfen şifreyi giriniz");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd" ) 
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}


            //string capital,country;
            //Console.Write(" başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" && country=="türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}


            //int number;
            //Console.Write("sayıyı giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5) {
            //    Console.WriteLine("sayı doğru");

            //}
            //else
            //{
            //    Console.WriteLine("hatalı sayı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "hata";
            //Console.Write("sınav1: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("ortalama: "+average);

            //if(average>0 && average <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if(average>50 && average <= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if(average<70 && average <= 84)
            //{
            //    result = "sonuç iyi";
            //}
            //if (average >84)
            //{
            //    result = "sonuç çok iyi";
            //}
            //Console.WriteLine(result);


            //string city;
            //Console.Write("lütfen şehir girişi yapınız ");
            //city = Console.ReadLine();

            //if(city=="adana"| city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("lütfen kullanıcı adı giriniz ");
            //string username=Console.ReadLine();
            //if(username != "admin") 
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");

            //}
            //else
            //{
            //    Console.WriteLine("hoş geldiniz");
            //}




            #endregion

            #region mod işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("lütfen 1. sayıyı giriniz ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sayıyı giriniz ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result=number1%number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: "+result);


            //Console.Write("lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else {
            //    Console.WriteLine("sayı tektir");
            //}
            #endregion

            #region char değişkenler ile karar yapıları
            //char team;
            //Console.WriteLine("lütfen takım sembolünü giriniz ");
            //team=char.Parse(Console.ReadLine());

            //if(team=='f' | team == 'F')
            //{
            //    Console.WriteLine("fenerbahçe");
            //}

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("galatasaray");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("beşiktaş");
            //}

            //if (team == 't' | team == 'T')
            //{
            //    Console.WriteLine("trabzonspor");
            //}
            #endregion

            #region örnek proje uygulaması
            //Console.WriteLine("*****C# eğitim kampı restoran*****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("4- Tatlılar");
            //Console.WriteLine("------------------");
            //Console.WriteLine();


            //string menuItem;
            //Console.WriteLine("detayını görmek istediğiniz menü seçimi ");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Ana Yemekler---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma tabağı");
            //    Console.WriteLine("3-Fasulye pilav");
            //    Console.WriteLine("4-Fırında somon");
            //    Console.WriteLine("5-Patlıcan musakka");
            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Çorbalar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin çorba");             
            //    Console.WriteLine();

            //}

            #endregion

            #region switch case
            //Console.Write("lütfen ay girişi yapın: ");
            //int monthNumber=int.Parse(Console.ReadLine()); 

            //switch(monthNumber)
            //{
            //    case 1:Console.Write("ocak"); break;
            //    case 2:Console.Write("şubat"); break;
            //    case 3:Console.Write("mart"); break;
            //    case 4:Console.Write("nisan"); break;
            //    case 5:Console.Write("mayıs"); break;
            //    case 6:Console.Write("haziran"); break;
            //    case 7:Console.Write("temmuz"); break;
            //    case 8:Console.Write("ağustos"); break;
            //    case 9:Console.Write("eylül"); break;
            //    case 10:Console.Write("ekim"); break;
            //    case 11:Console.Write("kasım"); break;
            //    case 12:Console.Write("aralık"); break;
            //    default: Console.WriteLine("hatalı veri girişi"); break;
            //}
            #endregion

            #region switch case hesap makinesi
            int number1, number2, result;
            char symbol;
            Console.Write("1.sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());



            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("toplam: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("fark : " + result);
                    break;

                case '*':
                    result = number1 * number2; ;
                    Console.WriteLine("çarpım: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("bölüm: " + result); break;
            }

            #endregion
            Console.Read();

            }
        }
    }