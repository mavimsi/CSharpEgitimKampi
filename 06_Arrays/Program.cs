using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri


            //string[] colours = new string[4];
            //colours[0] = "Kırmızı";
            //colours[1] = "Sarı";
            //colours[2] = "Beyaz";
            //colours[3] = "Mavi";

            //Console.WriteLine(colours[2]);




            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[5]);




            //dizinin i numaralı elemanında değer yoksa "0" değeri otomatik olarak verilir

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 563;
            //numbers[3] = 28;
            //numbers[7] = 78;

            //Console.WriteLine(numbers[5]);






            //string[] cities = { "prag", "roma", "atina", "ankara", "bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme


            //string[] colours = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };
            //for (int i = 0; i < colours.Length; i++)
            //{
            //        Console.WriteLine(colours[i]);
            //}





            //int[] numbers = { 4, 85, 96, 75, 83, 62, 71, 12, 32, 1255 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}






            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}





            //maksimum değeri buluyor
            //int[] myArray = { 45, 69, 85, 25, 27, 123, 751, 111, 155 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);






            //string[] persons = { "ali", "ahmet", "mehmet", "ayşe", "zeynep", "ece" };
            //Console.WriteLine(persons.Length);      //dizi uzunluğunu verir






            //int[] numbers = { 45, 854, 95, 23, 63, 698, 78, 12 };
            //Array.Sort(numbers); //küçükten büyüğe doğru sıralar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}







            //int[] numbers = { 45, 854, 95, 23, 63, 698, 78, 12 };
            //Array.Reverse(numbers); //diziyi tersten sıralar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metodları

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);





            //int[] numbers = { 48, 78, 962, 568, 1005, 236, 547, 58, 61 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + "Dizinin en küçük elemanı: " + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma


            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen{i + 1}. Şehrini Giriniz: ");
            //    cities[i]=Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}






            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);






            int[] numbers = { 21, 42, 33, 54, 55, 87, 92, 63, 57, 125, 589 };
            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion


            Console.Read();
        }
    }
}
