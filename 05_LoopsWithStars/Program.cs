using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    namespace _05_loopswithstars
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                #region alt alta 10 tane yıldız oluşturma

                //for(int i=0; i<=10; i++)
                //{
                //    Console.WriteLine("*");
                //}   


                #endregion

                #region yan yana 10 tane yıldız oluşturma

                //for(int i=1; i<10; i++)
                //{
                //    Console.Write("*");
                //}

                #endregion

                #region alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun
                //for(int i=1; i<10; i++)
                //{
                //    Console.WriteLine("**********");
                //}


                #endregion

                #region dik üçgen
                //for(int i=1; i<=5; i++)
                //{
                //    for(int j=1; j<=i; j++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}


                #endregion

                #region ters dik üçgen
                //for (int i = 5; i >= 1; i--)
                //{
                //    for (int j = 1; j <= i; j++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}
                #endregion

                #region dik ve ters üçgen beraber

                //for (int i = 1; i <= 5; i++)
                //{
                //    for (int j = 1; j <= i; j++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}
                //    for (int i = 4; i >= 1; i--)
                //    {

                //    for (int j = 1; j <= i; j++)
                //        {
                //            Console.Write("*");
                //        }
                //        Console.WriteLine();
                //    }


                #endregion

                #region baklava dilimi
                //int n = 5;

                //// Üst kısım
                //for (int i = 1; i <= n; i++)
                //{
                //    for (int j = n; j > i; j--)
                //    {
                //        Console.Write(" ");
                //    }
                //    for (int k = 1; k <= 2 * i - 1; k++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}

                //// Alt kısım
                //for (int i = n - 1; i >= 1; i--)
                //{
                //    for (int j = n; j > i; j--)
                //    {
                //        Console.Write(" ");
                //    }
                //    for (int k = 1; k <= 2 * i - 1; k++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}



                #endregion

                #region Piramit
                //int n = 5;
                //for (int i = 1; i <= n; i++)
                //{
                //    // Boşlukları yazdır
                //    for (int j = n - i; j > 0; j--)
                //    {
                //        Console.Write(" ");
                //    }
                //    // Yıldızları yazdır
                //    for (int k = 1; k <= 2 * i - 1; k++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}
                #endregion

                #region Ters Piramit
                int n = 5;
                for (int i = n; i >= 1; i--)
                {
                    //boşluklar
                    for (int j = n - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    //yıldızlar
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                #endregion

                Console.Read();

            }
        }
    }
}