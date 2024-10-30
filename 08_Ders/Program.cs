using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metot sonunda () olur.
            //Geriye değer döndüren ve değer döndürmeyen metodlar vardır.
            //Geriye değer döndürmeyen metotlar void metottur.
            //Metotlar birden fazla kez çağırılabilir.

            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ahmet Saman");
            //    Console.WriteLine("Sevil Sarı");
            //    Console.WriteLine("Fuat Çam");
            //    Console.WriteLine("Eda Kaya");
            //}
            //CustomerList(); //Fonksiyonumuzu çağırdık.
            //CustomerList(); //Metotlar birden fazla kez çağırılabilir.

            //void Sum()
            //{
            //    int x = 1, y = 2, z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen Parametreli String ve Int Metotlar

            //void Addition(int x, int y, int z)
            //{
            //   int total = x + y + z;
            //   Console.WriteLine(total);
            //}

            //Addition(10,20,30);

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine($"Müşteri Adı: {name} | Müşteri Soyadı: {surName}");
            //}
            //CustomerCard("Ahmet", "Beyaz");
            //CustomerCard("Sevda", "Görgülü");

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string ExampleFunction()
            //{
            //    //Yazdırma işlemi yapmadığımız için ekranda gözükmeyecek.
            //    return "Bu bir geriye değer döndüren fonksiyon örneğidir.";
            //}

            //ExampleFunction();

            //string studentCard()
            //{
            //    string name = "Arif";
            //    string surName = "Işık";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(studentCard()); //Return edilen değerleri yazdırır.

            #endregion

            #region Geriye Değer Döndüren Parametreli String ve Int Metotlar

            //string CountryCard(string countryName, string capital)
            //{
            //    string countryInfo = "Ülke ismi: " + countryName + " | " + " Başkent: " + capital;
            //    return countryInfo;
            //}

            //string cName, cptl;
            //Console.Write("Ülke adını giriniz: ");
            //cName = Console.ReadLine();
            //Console.Write("Ülke başkentini giriniz: ");
            //cptl = Console.ReadLine();

            //Console.WriteLine(CountryCard(cName, cptl));

            //int Addition(int value1, int value2)
            //{
            //    int total = value1 + value2;
            //    return total;
            //}
            //Console.WriteLine(Addition(5, 9));
            #endregion

            #region Örnek Uygulama
            string ExamResult(string studentName, int exam1, int exam2, int exam3)
            {
                int result = ((exam1 + exam2 + exam3) / 3);
                if (result >= 50)
                {
                    return studentName + " isimli öğrenci sınavı geçti!" + " | " + "Ortalama: " + result;
                }

                else
                {
                    return studentName + " isimli öğrenci sınavı geçemedi!" + " | " + "Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Selin Ay", 30, 70, 80));
            Console.WriteLine(ExamResult("Tuna Çoban", 40, 40, 50));

            #endregion




            Console.Read();


        }
    }
}
