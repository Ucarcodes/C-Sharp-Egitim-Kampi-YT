using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region Her satırda 10 tane yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            #endregion

            #region Dik Üçgen Örneği

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Dik Üçgen Örneği

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Dik Üçgen ve Ters Üçgeni Birlikte Yazdırma Örneği

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Baklava Dilimi Örneği

            //int h = 5; //h = yükseklik

            //Baklava diliminin üst tarafı

            //for (int i = 1; i <= h; i++)
            //{
            //    for (int j = h - 1; j > 0; j--)
            //    {
            //        Console.Write(" "); //Satırın sol taraftaki boşluğu  
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////Baklava diliminin alt tarafı

            //for (int l = h - 1; l >= 1; l--)
            //{
            //    for (int m = h - 1; m > 0; m--)
            //    {
            //        Console.Write(" "); //Satırın sol taraftaki boşluğu  
            //    }

            //    for (int n = 1; n <= 2 * l - 1; n++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit Örneği

            //int h = 5; //h = yükseklik

            //for (int i = 1; i < h; i++)
            //{
            //    for (int j = h - i; j > 0; j--)
            //    {
            //        Console.Write(" "); //Satırın solundaki boşluklar
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit Örneği

            //int h = 5; //h = yükseklik

            //for (int i = h; i >= 1; i--)
            //{
            //    for (int j = h - i; j > 0; j--)
            //    {
            //        Console.Write(" "); //Satırın solundaki boşluklar
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();

        }
    }
}
