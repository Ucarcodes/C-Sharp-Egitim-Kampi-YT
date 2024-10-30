using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If - Else

            //Console.WriteLine("|----- Değer Tahmini Oyunu -----|");
            //Console.Write("1-10 aralığında bir sayı giriniz: ");
            //int enteredValue, trueValue = 8;
            //enteredValue = Convert.ToInt16(Console.ReadLine());

            //if (enteredValue == trueValue)
            //{
            //    Console.WriteLine("Tebrikler! Değer tahmininiz doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Üzgünüz! Maalesef değer tahmininiz doğru değil.");
            //}
            //Console.Read();
            #endregion

            #region If - Else - Birden Fazla Şart Kontrolü

            //Console.WriteLine("|----- Alfabe Harf Oyunu -----|");
            //Console.Write("Alfabemizin ilk harfini giriniz: ");
            //string firstLetter, lastLetter;
            //firstLetter = Console.ReadLine();
            //Console.Write("Alfabemizin son harfini giriniz: ");
            //lastLetter = Console.ReadLine();

            //if (firstLetter == "A" && lastLetter == "Z") //if kontrolünde büyük-küçük karakter kullanımı aynı olmalıdır. Aksi takdirde şart hatalı kontrol edilir.
            //{
            //    Console.WriteLine("Tebrikler! Alfabemizin ilk ve son harfini doğru bildiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Üzgünüz! Alfabemizin ilk ve/veya son harfini doğru bilemediniz.");
            //}

            //Console.Read();
            #endregion

            #region If - Else - Sayı Tahmini Uygulaması
            //int schoolNumber;
            //Console.WriteLine("|----- Okul Numarası Tahmin Oyunu -----|");
            //Console.WriteLine("Not: 600-700 aralığında giriş yapmanız beklenmektedir.");
            //Console.Write("Lütfen sayı tahmininizi giriniz: ");
            //schoolNumber = int.Parse(Console.ReadLine());
            //if (schoolNumber == 640)
            //{
            //    Console.WriteLine("Tebrikler! Okul numarasını doğru tahmin ettiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Üzgünüz! Maalesef okul numarasını doğru tahmin edemediniz.");
            //}
            //Console.Read();
            #endregion

            #region If - Vize Final Ortalama Hesabı Uygulaması

            //int midtermExam, finalExam, average;
            //string result = "Hatalı giriş yapıldı!"; // örnekte else şartı olmadığı için result değeri if değerleri dışına çıkarsa hata vermemesi için değer ataması yapılmalıdır.

            //Console.WriteLine("|----- Üniversite Sınav Sonuçları Giriş Ekranı -----|");
            //Console.Write("Vize Notu: ");
            //midtermExam = int.Parse(Console.ReadLine());
            //Console.Write("Final Notu: ");
            //finalExam = int.Parse(Console.ReadLine());

            //average = ((midtermExam + finalExam) / 2);
            //Console.WriteLine("Öğrencinin Ders Ortalaması: " + average );

            //if (average >= 0 & average < 20)
            //{
            //    result = ("| Harf Notu: FF | Başarı Derecesi: Başarısız. |");
            //}

            //if (average >= 20 & average < 30)
            //{
            //    result = ("| Harf Notu: FD | Başarı Derecesi: Başarısız. |");
            //}

            //if (average >= 30 & average < 40)
            //{
            //    result = ("| Harf Notu: DD | Başarı Derecesi: Koşullu Geçer. |");
            //}

            //if (average >= 40 & average < 50)
            //{
            //    result = ("| Harf Notu: DC | Başarı Derecesi: Koşullu Geçer. |");
            //}

            //if (average >= 50 & average < 60)
            //{
            //    result = ("| Harf Notu: CC | Başarı Derecesi: Geçer. |");
            //}

            //if (average >= 60 & average < 70)
            //{
            //    result = ("| Harf Notu: CB | Başarı Derecesi: Orta. |");
            //}

            //if (average >= 70 & average < 80)
            //{
            //    result = ("| Harf Notu: BB | Başarı Derecesi: İyi. |");
            //}

            //if (average >= 80 & average < 90)
            //{
            //    result = ("| Harf Notu: BA | Başarı Derecesi: Pekiyi. |");
            //}

            //if (average >= 90 & average <= 100)
            //{
            //    result = ("| Harf Notu: AA | Başarı Derecesi: Mükemmel. |");
            //}

            //Console.WriteLine(result);
            //Console.Read();

            #endregion

            #region If - Else - Şehir Tahmini Uygulaması

            //string city;
            //Console.Write("Lütfen Türkiye'de bulunan büyük şehirlerden birini giriniz: ");
            //city = Console.ReadLine();

            //if (city == "Ankara" | city == "İstanbul" | city == "Bursa" | city == "Antalya" | city == "Mersin |")
            //{
            //    Console.WriteLine("Tebrikler! Listemizde bulunan büyük şehirlerden birini doğru bildiniz.");
            //}

            //else
            //{
            //    Console.WriteLine("Üzgünüz! Maalesef girdiğiniz şehir, listemizde mevcut değil.");
            //}

            //Console.Read();
            #endregion

            #region If - Else Admin Paneli Girişi Uygulaması

            //string id = "admin", password = "adminPass";

            //Console.WriteLine("|----- Admin Paneli Giriş Ekranı -----|");
            //Console.Write("Lütfen, kullanıcı adını giriniz: ");
            //id = Console.ReadLine();
            //Console.Write("Lütfen, şifreyi giriniz: ");
            //password = Console.ReadLine();

            //if (id != "admin" | password != "adminPass")
            //{
            //    Console.WriteLine("Giriş yapılamadı! Kullanıcı adı ve/veya şifre hatalı!");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş başarılı!");
            //}
            //Console.Read();

            #endregion

            #region If - Else Mod Alma - Tek - Çift Kalan Kontrolü

            //Console.WriteLine("|----- Mod Alma İşlemi -----|");
            //Console.Write("Lütfen, 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen, 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int modResult = number1 % number2;
            //int oddEvenResult = modResult % 2;

            //if (oddEvenResult == 0)
            //{
            //    Console.WriteLine("1. Sayının 2. Sayıya Modundan Kalan: " + modResult);
            //    Console.WriteLine("Kalan çifttir.");
            //}

            //if (oddEvenResult == 1)
            //{
            //    Console.WriteLine("1. Sayının 2. Sayıya Modundan Kalan: " + modResult);
            //    Console.WriteLine("Kalan tektir.");
            //}
            //Console.Read();
            #endregion

            #region If - Else If - Else Char Kontrolü

            //char FTChar;

            //Console.WriteLine("|----- Tek Karakterden Takım Bulma Oyunu -----|");
            //Console.Write("Başlamak için bir harf giriniz: ");
            //FTChar = char.Parse(Console.ReadLine());

            //if (FTChar == 'f' | FTChar == 'F')
            //{
            //    Console.Write("Tahminimiz: Fenerbahçe");
            //}

            //else if (FTChar == 'g' | FTChar == 'G')
            //{
            //    Console.Write("Tahminimiz: Galatasaray");
            //}

            //else if (FTChar == 'b' | FTChar == 'B')
            //{
            //    Console.Write("Tahminimiz: Beşiktaş");
            //}

            //else if (FTChar == 't' | FTChar == 'T')
            //{
            //    Console.Write("Tahminimiz: Trabzonspor");
            //}

            //else
            //{
            //    Console.Write("Üzgünüz! Girmiş olduğunuz karaktere ait futbol takımı, listemizde bulunmamaktadır.");

            //}

            //Console.Read();

            #endregion

            #region If - Else If - Else - Restoran Menü Seçim Uygulaması



            //Console.WriteLine("|----- C# Eğitim Kampı Restoran -----|");
            //Console.WriteLine();
            //Console.WriteLine("|-----Menü -----|");
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("|-----Menü -----|");
            //Console.WriteLine();

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //int menuNumber;
            //menuNumber = int.Parse(Console.ReadLine());

            //if (menuNumber == 1)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("|----- Çorbalar -----|");
            //    Console.WriteLine("1- Ezogelin Çorbası");
            //    Console.WriteLine("2- Mercimek Çorbası");
            //    Console.WriteLine("3- Yayla Çorbası");
            //    Console.WriteLine("|----- Çorbalar -----|");
            //}
            //else if (menuNumber == 2)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("|----- Ana Yemekler -----|");
            //    Console.WriteLine("1- Patlıcan Musakka");
            //    Console.WriteLine("2- Fırında Tavuk");
            //    Console.WriteLine("3- Kurufasülye");
            //    Console.WriteLine("4- Pirinç Pilavı");
            //    Console.WriteLine("5- Bulgur Pilavı");
            //    Console.WriteLine("|----- Ana Yemekler -----|");
            //}

            //else if (menuNumber == 3)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("|----- Pizzalar -----|");
            //    Console.WriteLine("1- Margarita Pizza");
            //    Console.WriteLine("2- Sebzeli Pizza");
            //    Console.WriteLine("3- Tavuklu Pizza");
            //    Console.WriteLine("4- Karışık Pizza");
            //    Console.WriteLine("|----- Pizzalar -----|");
            //}

            //else if (menuNumber == 4)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("|----- İçecekler -----|");
            //    Console.WriteLine("1- Gazlı İçecekler");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Portakal Suyu");
            //    Console.WriteLine("4- Nar Suyu");
            //    Console.WriteLine("5- Karışık Meyve Suyu");
            //    Console.WriteLine("|----- İçecekler -----|");
            //}

            //else if (menuNumber == 5)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("|----- Tatlılar -----|");
            //    Console.WriteLine("1- Keşkül");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Supangle");
            //    Console.WriteLine("4- Tavukgöğsü");
            //    Console.WriteLine("5- Sütlaç");
            //    Console.WriteLine("|----- Tatlılar -----|");
            //}

            //else
            //{
            //    Console.WriteLine("Girdiğiniz numara menümüzde bulunmamaktadır!");
            //}
            //Console.Read();
            #endregion

            #region Switch Case - Ay Kontrolü Uygulaması

            //Console.WriteLine("|----- Girilen Sayıya Göre Ay Kontrolü -----|");
            //Console.Write("Lütfen, 1-12 arası bir sayı giriniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("1. Ay: Ocak");
            //        break;
            //    case 2: Console.WriteLine("2. Ay: Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("3. Ay: Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("4. Ay: Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("5. Ay: Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("6. Ay: Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("7. Ay: Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("8. Ay: Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("9. Ay: Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("10. Ay: Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("11. Ay: Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("12. Ay: Aralık");
            //        break;
            //}
            //Console.Read();
            #endregion

            #region Switch Case - Hesap Makinesi Uygulaması

            //float number1, number2, result;
            //char operation;

            //Console.WriteLine("|----- 4 İşlem Uygulaması -----|");
            //Console.Write("1. Sayıyı giriniz: ");
            //number1 = float.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //number2= float.Parse(Console.ReadLine());
            //Console.Write("Yapılacak işlemi giriniz: ");
            //operation = char.Parse(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Seçilen işlem: Toplama");
            //        Console.WriteLine("Sonuç: " +result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Seçilen işlem: Çıkarma");
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Seçilen işlem: Çarpma");
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Seçilen işlem: Bölme");
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    default: Console.WriteLine("Hatalı operatör girişi yapıldı.");
            //        break; 
            //}
            //Console.Read();

            #endregion



        }
    }
}
