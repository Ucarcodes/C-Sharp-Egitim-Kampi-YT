using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Double Değişkenler

            //double ondalikliSayi = 3.21;

            //Console.WriteLine("Tanımlanan Ondalıklı Sayı Değeri: " + ondalikliSayi);
            //Console.Read();




            //double cherryPrice, kiwiPrice, watermelonPrice, strawberryPrice;
            //double cherryKG, kiwiKG, watermelonKG, strawberryKG;

            //cherryPrice = 15.90;
            //kiwiPrice = 9.90;
            //watermelonPrice = 5;
            //strawberryPrice = 19.90;

            //cherryKG = 2;
            //kiwiKG = 1.5;
            //watermelonKG = 5.85;
            //strawberryKG = 1.35;

            //double cherryTotalPrice = cherryPrice * cherryKG;
            //double kiwiTotalPrice = kiwiPrice * kiwiKG;
            //double watermelonTotalPrice = watermelonPrice * watermelonKG;
            //double strawberryTotalPrice = strawberryPrice * strawberryKG;

            //double overallTotalPrice = cherryTotalPrice + kiwiTotalPrice + watermelonTotalPrice + strawberryTotalPrice;

            //Console.WriteLine("|----- Meyve Fiyatları -----|");
            //Console.WriteLine();
            //Console.WriteLine("--- Çilek Kilo Fiyatı: " + strawberryPrice + " ₺");
            //Console.WriteLine("--- Karpuz Kilo Fiyatı: " + watermelonPrice + " ₺");
            //Console.WriteLine("--- Kiraz Kilo Fiyatı: " + cherryPrice + " ₺");
            //Console.WriteLine("--- Kivi Kilo Fiyatı: " + kiwiPrice + " ₺");
            //Console.WriteLine();


            //Console.WriteLine("|----- Sepet -----|");
            //Console.WriteLine("Alınan Ürün: Çilek | " + "Kilo Fiyatı: " + strawberryPrice + " |" + " Alınan Miktar: " + strawberryKG + " |" + " Toplam: " + strawberryTotalPrice + "₺" + " |");
            //Console.WriteLine("Alınan Ürün: Karpuz | " + "Kilo Fiyatı: " + watermelonPrice + " |" + " Alınan Miktar: " + watermelonKG + " |" + " Toplam: " + watermelonTotalPrice + "₺" + " |");
            //Console.WriteLine("Alınan Ürün: Kiraz | " + "Kilo Fiyatı: " + cherryPrice + " |" + " Alınan Miktar: " + cherryKG + " |" + " Toplam: " + cherryTotalPrice + "₺" + " |");
            //Console.WriteLine("Alınan Ürün: Kivi | " + "Kilo Fiyatı: " + kiwiPrice + " |" + " Alınan Miktar: " + kiwiKG + " |" + " Toplam: " + kiwiTotalPrice + "₺" + " |");
            //Console.WriteLine();
            //Console.WriteLine("Genel Toplam : " + overallTotalPrice + "₺");
            //Console.Read();

            #endregion

            #region Char Değişkenler

            //char exampleChar = 'x';

            //Console.WriteLine("Tanımladığımız Char Değeri: " + exampleChar);
            //Console.Read();
            #endregion

            #region Klavyeden Veri Girişleri (String, Long, Int)

            //string passengerName, passengerSurname, passengerCity, passengerCountry;
            //int passengerAge; 
            //long passengerIdentityNumber;

            //Console.WriteLine("|----- Ucar Hava Yolları Yolcu Bilgileri -----|");
            //Console.WriteLine();
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu Kimlik Numarası: ");
            //passengerIdentityNumber = Convert.ToInt64(Console.ReadLine());
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Yolcu Şehri: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Ülkesi: ");
            //passengerCountry = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("|----- Girilen Yolcu Bilgileri -----|");
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Adı: " + passengerName + " | " + "Yolcu Soyadı: " + passengerSurname + " | " + "Yolcu Kimlik Numarası: "+ passengerIdentityNumber + " | " + "Yolcu Yaşı: " + passengerAge + " | " + "Yolcu Şehri: " + passengerCity + " | " + "Yolcu Ülkesi: "+ passengerCountry + " | ");
            //Console.Read();
            #endregion

            #region Klavyeden  Tam Sayı Girişleri (Int)

            //int computerPrice, TVPrice, mobilePhonePrice, monitorPrice;
            //int computerAmount, TVAmount, mobilePhoneAmount, monitorAmount;
            //int totalPrice;

            //computerPrice = 15000;
            //TVPrice = 30000;
            //mobilePhonePrice = 25000;
            //monitorPrice = 10000;

            //Console.WriteLine("|----- Satın Alınan Ürünler ve Sayıları -----|");
            //Console.WriteLine();
            //Console.Write("Satın aldığınız bilgisayar sayısını giriniz: ");
            //computerAmount = int.Parse(Console.ReadLine()); //int32
            //Console.Write("Satın aldığınız televizyon sayısını giriniz: ");
            //TVAmount = int.Parse(Console.ReadLine()); //int32
            //Console.Write("Satın aldığınız cep telefonu sayısını giriniz: ");
            //mobilePhoneAmount = int.Parse(Console.ReadLine()); //int32
            //Console.Write("Satın aldığınız monitör sayısını giriniz: ");
            //monitorAmount = int.Parse(Console.ReadLine()); //int32
            //Console.WriteLine();

            //totalPrice = computerAmount * computerPrice + TVAmount * TVPrice + mobilePhoneAmount * mobilePhonePrice + monitorAmount * monitorPrice;

            //Console.WriteLine("|----- Sepet Toplamı -----|");
            //Console.WriteLine("Ödenecek Toplam Tutar: " + totalPrice);
            //Console.Read();

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri (Double)

            //double exam1, exam2, exam3, average;

            //Console.WriteLine("|----- Öğrenci Not Giriş Sistemi -----|");
            //Console.WriteLine();
            //Console.Write("1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Not ortalaması: " + average);
            //Console.Read();


            #endregion

            #region Klavyeden Karakter Girişleri (Char)

            char exampleCharacter;

            Console.WriteLine("|----- Karakter Giriş Ekranı -----|");
            Console.Write("Lütfen, girmek istediğiniz karakteri tuşlayınız: ");
            exampleCharacter = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Girdiğiniz karakter: " + exampleCharacter);
            Console.Read();

            #endregion
        }
    }
}
