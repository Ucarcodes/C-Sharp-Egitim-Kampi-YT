using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı "+ "Döngünün " + i + ". değerindeyiz.");
            //}

            //for (int i = 5; i <= 100; i += 5)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region For Döngüsü ve Kullanıcı Veri Girişi

            //Console.Write("Lütfen, ekrana kaç kez yazdırmak istediğinizi giriniz: ");

            //int inputValue = int.Parse(Console.ReadLine());

            //Console.WriteLine("Girmiş olduğunuz değer: "+ inputValue);
            //Console.WriteLine();

            //for (int i = 1; i <= inputValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}

            #endregion

            #region For Döngüsü ve Karar Yapıları

            //Console.WriteLine("|----- 7'ye Tam Bölünen Sayılar -----|");

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine("7'ye tam bölünen sayı: " + i);
            //    }
            //}


            //Console.WriteLine("|----- 2'ye Tam Bölünen Sayıların Toplamı -----|");

            //int totalValue = 0;

            //for (int i = 1; i < 40; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine("2'ye tam bölünen sayı: " + i);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("|----- Toplam -----|");
            //Console.WriteLine(totalValue);


            //Console.WriteLine("|----- 1-100 Arası 11'e Tam Bölünen Sayıların Adedini Bulma -----|");

            //int count = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 11 == 0)
            //    {
            //        Console.WriteLine("11'e tam bölünen sayılar: " + i);
            //        count++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tam bölünen sayısı: " + count);

            #endregion

            #region For Döngüsü Bakteri Örneği

            //int bacteriumValue = 1;
            //int totalTime = 24;
            //for (int i = 1; i <= totalTime; i++)
            //{
            //    bacteriumValue *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda Toplam Bakteri: " + bacteriumValue);
            //}


            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba, bu bir while döngüsü örneği.");
            //    i++;
            //}


            //int i = 1;

            //while (i <= 20)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("2'ye tam bölünen sayı: " + i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int totalValue = 0;

            //while (i <= 15)
            //{
            //    totalValue += i;
            //    i++;
            //}
            //Console.WriteLine("1-15 arası sayıların toplamı: " + totalValue);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının, basamakları toplamını hesaplayan kodu yazınız.

            //Console.Write("Lütfen, basamakları toplamını öğrenmek istediğiniz sayıyı giriniz: ");
            //int inputValue = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int totalValue;

            //hundreds = inputValue / 100;
            //tens = (inputValue%100)/10;
            //ones = inputValue % 10;

            //totalValue = hundreds + tens + ones;

            //Console.WriteLine("Girilen sayının yüzler basamağı değeri: " + hundreds);
            //Console.WriteLine("Girilen sayının onlar basamağı değeri: " + tens);
            //Console.WriteLine("Girilen sayının birler basamağı değeri: " + ones);
            //Console.WriteLine("Girilen sayının basamaklar toplamı değeri: " + totalValue);
            #endregion

            Console.Read();
        }
    }
}
