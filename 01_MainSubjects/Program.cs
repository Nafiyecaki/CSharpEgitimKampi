
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _01_MainSubjects
    {
        internal class Program
        {
            static void Main(string[] args)
            {


                #region yazdırmaKomutları

                //1. ders ilk kısım

                //Console.WriteLine("Merhaba Dünya");
                //Console.Write("Selam");


                //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
                //Console.WriteLine();
                //Console.WriteLine("1- Çorbalar");
                //Console.WriteLine("2- Ana Yemekeler");
                //Console.WriteLine("3- Soğuk Başlangıçlar");
                //Console.WriteLine("4- salatalar");
                //Console.WriteLine("5- Tatlılar");
                //Console.WriteLine("6- İçecekler");
                //Console.WriteLine();
                //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
                #endregion


                #region stringDeğişkenler

                //String

                //string name;
                //name = "Esma";
                //Console.WriteLine(name);

                ////string customerName;
                ////string customerSurname;
                ////string customerPhone;
                ////string customerEmail, district, city;

                ////customerName = "Esmanur";
                ////customerSurname = "Beyaz";
                ////customerPhone = "+90 500 400 30 20";
                ////customerEmail = "deneme@gmail.com";
                ////district = "Boğazlıyan";
                ////city = "Yozgat";

                ////Console.WriteLine("***** REZERVASYON KARTI *****");
                ////Console.WriteLine( );
                ////Console.WriteLine("-----------------------------------");
                ////Console.WriteLine("");
                ////Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
                ////Console.WriteLine("İletişim : " + customerPhone);
                ////Console.WriteLine("Email Adresi : " + customerEmail);
                ////Console.WriteLine("Adres : " + district + "/" + city);
                ////Console.WriteLine();
                ////Console.WriteLine("-----------------------------------");

                ////Console.WriteLine();

                ////customerName = "Ali";
                ////customerSurname = "Ayşe";
                ////customerPhone = "+90 600 500 70 20";
                ////customerEmail = "test@gmail.com";
                ////district = "Melikgazi";
                ////city = "Kayseri";

                ////Console.WriteLine("-----------------------------------");
                ////Console.WriteLine("");
                ////Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
                ////Console.WriteLine("İletişim : " + customerPhone);
                ////Console.WriteLine("Email Adresi : " + customerEmail);
                ////Console.WriteLine("Adres : " + district + "/" + city);
                ////Console.WriteLine();
                ////Console.WriteLine("-----------------------------------");
                #endregion


                #region intDeğişkenler

                //int   

                int hamburgerPrice = 300;
                int cokePrice = 35;
                int pizzaPrice = 250;
                int lemonadePrice = 60;
                int friesPrice = 50;
                int waterPrice = 20;


                Console.WriteLine("********** RESTAURANT MENÜ **********");
                Console.WriteLine("");
                Console.WriteLine("--------Kola : " + cokePrice + "TL");
                Console.WriteLine("--------Su : " + waterPrice + "TL");
                Console.WriteLine("--------Limonata : " + lemonadePrice + "TL");
                Console.WriteLine("--------Hamburger : " + hamburgerPrice + "TL");
                Console.WriteLine("--------Pizza : " + pizzaPrice + "TL");
                Console.WriteLine("--------Kızartma : " + friesPrice + "TL");
                Console.WriteLine("");
                Console.WriteLine("********** RESTAURANT MENÜ **********");

                Console.WriteLine();
                int hamburgerCount;
                int cokeCount;
                int lemonadeCount;
                int waterCount;
                int pizzaCount;
                int frizeCount;

                int totalHamburger;
                int totalCoke;
                int totalWater;
                int totalLemonade;
                int totalPizza;
                int totalFrize;
                int totalPrice;

                hamburgerCount = 3;
                cokeCount = 3;
                lemonadeCount = 0;
                waterCount = 2;
                pizzaCount = 0;
                frizeCount = 1;



                totalHamburger = hamburgerCount * hamburgerPrice;
                totalCoke = cokeCount * cokePrice;
                totalWater = waterCount * waterPrice;
                totalLemonade = lemonadeCount * lemonadePrice;
                totalPizza = pizzaCount * pizzaPrice;
                totalFrize = frizeCount * friesPrice;
                totalPrice = totalLemonade + totalPizza + totalFrize + totalHamburger + totalWater + totalCoke;


                Console.WriteLine("*");
                Console.WriteLine();
                Console.WriteLine("Hamburger tutarı : " + totalHamburger + "TL");
                Console.WriteLine("Kola tutarı : " + totalCoke + "TL");
                Console.WriteLine("Su tutarı : " + totalWater + "TL");
                Console.WriteLine("Limonata tutarı : " + totalLemonade + "TL");
                Console.WriteLine("Pizza tutarı : " + totalPizza + "TL");
                Console.WriteLine("Kızartma tutarı : " + totalFrize + "TL");
                Console.WriteLine();
                Console.WriteLine("ÖDENECEK TUTAR : " + totalPrice);
                Console.WriteLine();
                Console.WriteLine("*");














                #endregion


                Console.Read();
            }
        }
    }




