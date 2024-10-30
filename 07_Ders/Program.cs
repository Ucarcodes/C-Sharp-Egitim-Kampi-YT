﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //Foreach (1;2;3;4)
            //1: Değişken türü
            //2: Değişken adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = { "Paris", "Milano", "Bursa" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 33, 44, 55, 66, 77, 88, 99, 111 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Foreach ve If Kullanımı

            //int[] numbers = { 33, 44, 55, 66, 77, 88, 99, 111 };

            //Console.WriteLine("Çift sayılar yazdırılıyor...");
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            #endregion

            #region Foreach Dizi Toplamı Bulma

            //int[] numbers = { 33, 44, 55, 66, 77, 88, 99, 111 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine("Dizinin toplamı: " + total);

            #endregion

            #region Foreach ve List Kullanımı

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,5,9,10
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Foreach ve Kelimeyi Tek Tek Yazdırma


            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("|----- C# Eğitim Kampı Sınav Uygulaması -----|");
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki çğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------");
            Console.Write("Sınıfınızda kaç tane öğrenci var? : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[]studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;
                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz:");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //Notları topluyoruz.
                }

                studentExamAvg[i] = totalExamResult / 3;


            }
            Console.WriteLine();

            //Öğrencilerin ortalamaları ve geçip kalma durumları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i] > 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");

                }
            }

            //Öğrencilerin ortalaması ve dersten geçme/kalma durumları

            

            #endregion

            Console.Read();
        }
    }
}