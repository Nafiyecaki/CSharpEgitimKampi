using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü 
            //int i;
            //for ( i = 0; i <=5 ; i++)
            //{
            //    Console.WriteLine("c# eğitim kampı");
            //}

            //for(int i=1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i=3; i<=50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("lütfen ekrana yazılmasını istediğiniz adedi giriniz ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for(int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("yaşasın cumhuriyet ");
            //}

            #endregion

            #region for döngüsü ile karar yapıları

            //for(int i=0; i <= 100; i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}    

            //int totalValue = 0;
            //for (int i = 1; i<= 10; i++){
            //    totalValue += 1;
            //    Console.WriteLine(totalValue);
            //}

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if(i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for(int i=1; i<=50; i++)
            //{
            //    if(i%7==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for(int i = 1; i<=24; i++)
            //{
            //    bacterium*=2;
            //    Console.WriteLine(i+". saat sonunda "+ bacterium);
            //}

            #endregion

            #region while döngüsü
            // while (şart)
            //{
            // işlemler
            //}

            //int i = 1;
            //while (i<=10) {
            //Console.WriteLine("merhaba döngüler");
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int toplam = 0;
            //while (i <=10) {
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine(toplam);

            #endregion

            #region örnek sınav sorusu
            //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız
            Console.Write("sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundred;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundred = number / 100;

            Console.WriteLine(ones + "-" + tens + "-" + hundred);
            sum = ones + tens + hundred;
            Console.WriteLine(sum);
            #endregion
            Console.Read();
        }
    }
}