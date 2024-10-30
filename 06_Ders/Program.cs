using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Boyutu Önceden Belirlenmiş Dizi Örnekleri

            // degiskenTuru [] diziAdi = new degiskenTuru[Eleman sayısı veya elemanlar] şeklinde diziyi tanımlayabiliriz.
            // Diziler, 0. indexten başlar.
            // Dizilerde, girilen eleman sayısının tamamı dolu olmak zorunda değildir.
            // int Dizilerde, bir index boş bırakılırsa, o index çağırıldığında default olarak 0 değeri atanır.
            // string Dizilerde, bir index boş bırakılırsa, o index çağırıldığında default olarak " " (boş karakter) değeri atanır.

            //string[] colors = new string[4];

            //colors[0] = "Beyaz";
            //colors[1] = "Siyah";
            //colors[2] = "Kırmızı";
            //colors[3] = "Mavi";

            //Console.WriteLine("Dizimizin ilk elemanı: " + colors[0]);
            //Console.WriteLine("Dizimizin son elemanı: " + colors[3]);

            //int[] numbers = new int[8];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[5] = 60;
            //numbers[7] = 80;

            //Console.WriteLine("7. Indexteki değer: " + numbers[7]);
            //Console.WriteLine("6. Indexteki değer: " + numbers[6]);




            #endregion

            #region Boyutu Önceden Belirlenmemiş Dizi Örneği

            //string[] cities = {"Ankara", "Atina", "Paris" };

            //Console.WriteLine("Dizimizdeki ilk eleman: " + cities[0]);
            //Console.WriteLine("Dizimizdeki son eleman: " + cities[cities.Length - 1]); // ya da index numarası biliniyorsa, aşağıdaki gibi de yazılabilir.
            //Console.WriteLine("Dizimizdeki son eleman: " + cities[2]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Beyaz", "Camgöbeği", "Petrol Mavisi", "Turuncu" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(i + ". indexteki değer: " + colors[i]);
            //}

            //int[] numbers = { 30, 21, 11, 7, 60, 120, 210, 124 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine("Dizimizde, 3'e tam bölünen değişkenler: " + numbers[i]);
            //    }
            //}

            //char[] symbols = { '+', '-', '*', '/', '!', '^' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine("Dizimizdeki char değişkenler: " + symbols[i]);
            //}
            #endregion

            #region Dizideki En Büyük Elemanı Bulma

            //int[] numbersArray = {11, 23, 37, 79, 7, 111, 21, 84 };

            //int maxNumber = numbersArray[0]; //Dizinin ilk elemanını en büyük elemanmış gibi kabul ettik.

            //for (int i = 0; i < numbersArray.Length; i++)
            //{
            //    if (numbersArray[i] > maxNumber)
            //    {
            //        maxNumber = numbersArray[i]; // Dizinin herhangi bir indexindeki sayı, bizim kabul ettiğimiz sayıdan büyükse, dizinin indexindeki değeri, maxNumber değişkenimize ata.
            //    }
            //}
            //Console.WriteLine("Dizinin en büyük değere sahip elemanı: " + maxNumber);
            #endregion

            #region Dizideki En Küçük Elemanı Bulma

            //int[] numbersArray = { 39, 75, 45, 21, 5, 99, 6, 47 };

            //int minNumber = numbersArray[0]; //Dizinin ilk elemanını en küçük elemanmış gibi kabul ettik.

            //for (int i = 0; i < numbersArray.Length; i++)
            //{
            //    if (numbersArray[i] < minNumber)
            //    {
            //        minNumber = numbersArray[i]; // Dizinin herhangi bir indexindeki sayı, bizim kabul ettiğimiz sayıdan küçükse, dizinin indexindeki değeri, minNumber değişkenimize ata.
            //    }
            //}
            //Console.WriteLine("Dizinin en küçük değere sahip elemanı: " + minNumber);

            #endregion

            #region Dizilerde Metodlar

            // diziAdi.Length, dizi büyüklüğünü verir.
            // Array.Sort, diziyi küçükten büyüğe sıralar.
            // Array.Reverse, diziyi sondan başa sıralar.
            // Array.IndexOf(diziAdi, "arananVeri"), girdiğimiz değerin, dizimizde kaçıncı indexte olduğunu bulur.
            // diziAdi.Max(), dizinin en büyük değerini bulur.
            // diziAdi.Min(), dizinin en küçük değerini bulur.

            //string[] people = { "Akif", "Mustafa", "Cem", "Buse", "Pınar" };

            //Console.WriteLine("Dizimizin uzunluğu: " + people.Length);

            //int[] numbers = { 13, 45, 23, 67, 99 };

            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Küçükten büyüğe sıralanmış listenin " + i + ". elemanı: " + numbers[i]);
            //}

            //int[] numbers = { 13, 45, 23, 67, 99 };

            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Listenin tersten yazıldığında " + i + ". elemanı: " + numbers[i]);
            //}

            //string[] customers = { "Mustafa", "Ahmet", "Eda", "Cemre" };
            //int customerIndex = Array.IndexOf(customers, "Eda");

            //Console.WriteLine("Eda adlı müşterinin index numarası: " + customerIndex);

            //int[] numbers = { 41, 34, 16, 32, 7, 81, 121};

            //Console.WriteLine("Dizinin en büyük değeri: " + numbers.Max() + " Dizinin en küçük değeri: " + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alınarak Dizi Oluşturma
            // ($"Dizinin {i+1}. Indexi: "); gibi bir kullanım, {} içinde,değişkenlerin değerlerini yazdırmada, " " içinde de string verileri yazdırmaya yarar. Gereksiz + + + gibi kullanımları engeller.

            //string[] cities = new string[4];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("|----- Kullanıcıdan alınan şehir verileri -----|");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Kullanıcının girdiği {i+1}. Şehir: {cities[i]}"  );
            //}

            #endregion

            #region Dizideki Elemanların Toplamını Bulma

            //int[] numbers = { 20, 15, 25, 35, 40 };

            //int total = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i];
            //}
            //Console.WriteLine($"Dizideki değerler toplamı: {total}");
            #endregion

            #region Dizideki Elemanların Çarpımını Bulma

            //int[] numbers = { 20, 15, 25, 35, 40 };

            //int total = 1;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total *= numbers[i];
            //}
            //Console.WriteLine($"Dizideki değerler çarpımı: {total}");

            #endregion

            #region Dizideki Tek ve Çift Sayıları İki Ayrı Diziye Dönüştürme

            //int[] numbers = {10, 20, 33, 26, 17, 11, 30 };
            
            //Console.WriteLine("Dizideki Çift Sayılar:");


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine("Dizideki Tek Sayılar:");


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            #endregion

            Console.Read();
        }
    }
}
