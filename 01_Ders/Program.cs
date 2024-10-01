using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Soğuk Başlangıçlar");
            //Console.WriteLine("3- Ana Yemekler");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string customerName;
            //customerName = "Mevlüt";
            //Console.WriteLine(customerName);

            //string customerName, customerSurname;
            //string customerCountry, customerCity, customerDistrict;
            //string customerEmail, customerPhone;

            //customerName = "Ahmet";
            //customerSurname = "Çayır";
            //customerCountry = "Türkiye";
            //customerCity = "Bursa";
            //customerDistrict = "Merkez";
            //customerEmail = "ornekmail@gmail.com";
            //customerPhone = "0590 852 32 46";

            //Console.WriteLine("----- Rezervasyon Kartı -----");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri İsmi: " + customerName);
            //Console.WriteLine("Müşteri Soyismi: " + customerSurname);
            //Console.WriteLine("Müşteri Ülkesi: " + customerCountry);
            //Console.WriteLine("Müşteri Şehri: " + customerCity);
            //Console.WriteLine("Müşteri İlçesi: " + customerDistrict);
            //Console.WriteLine("Müşteri Mail Adresi: " + customerEmail);
            //Console.WriteLine("Müşteri Telefon Numarası: " + customerPhone);
            //Console.WriteLine();

            #endregion

            #region Int  ve String Değişkenler Birlikte

            int hamburgerPrice = 300;
            int friesPrice = 100;
            int pizzaPrice = 250;
            int cokePrice = 50;
            int lemonadePrice = 40;
            int waterPrice = 10;

            int hamburgerCount = 2;
            int friesCount = 4;
            int pizzaCount = 2;
            int cokeCount = 1;
            int lemonadeCount = 3;
            int waterCount = 4;

            int genelToplam = (hamburgerCount * hamburgerPrice)
                + (friesCount * friesPrice)
                +(pizzaCount * pizzaPrice)
                +(cokeCount * cokePrice)
                +(lemonadeCount * lemonadePrice)
                +(waterCount * waterPrice);

            Console.WriteLine("----- Restoran Menüsü ----- ");
            Console.WriteLine("----- Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("----- Patates Kızartması: " + friesPrice + "TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("----- Kola: " + cokePrice + "TL");
            Console.WriteLine("----- Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("----- Su: " + waterPrice + "TL");
            Console.WriteLine("----- Restoran Menüsü ----- ");
            Console.WriteLine();



            Console.WriteLine("----- Siparişler ----- ");
            Console.WriteLine("----- Hamburger: " + hamburgerCount + " Adet");
            Console.WriteLine("----- Patates Kızartması: " + friesCount + " Adet");
            Console.WriteLine("----- Pizza: " + pizzaCount + " Adet");
            Console.WriteLine("----- Kola: " + cokeCount + " Adet");
            Console.WriteLine("----- Limonata: " + lemonadeCount + " Adet");
            Console.WriteLine("----- Su: " + waterCount + " Adet");
            Console.WriteLine("----- Siparişler ----- ");
            Console.WriteLine();

            Console.WriteLine("----- Hesap Toplamı ----- ");
            Console.WriteLine("----- Genel Toplam: " + genelToplam + "TL");
            Console.WriteLine("----- Hesap Toplamı ----- ");



            #endregion

            Console.Read();
        }
    }
}
