using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yolcu");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Tuğrul Öztürk");
            //    Console.WriteLine("Sezen Aksu");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();




            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar



            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Niyazi Cansız");




            //void customerCard (string name, String surName)
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surName);
            //}
            //customerCard("Niyazi", "Cansız");
            //customerCard("Ayşegül", "Ayva");


            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar


            //void sum (int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(10, 20, 30);



            #endregion

            #region Geriye Değer Döndüren Metotlar


            //string CustomerName()
            //{
            //    return "Pınar Yılmaz";
            //}
            //CustomerName();




            //string StudentCard()
            //{
            //    string name = "Yusuf";
            //    string surName = "Dikeç";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region  Geriye Değer Döndüren Parametreli Metotlar


            //string countryCard(string countryName, string capital, string flagColour)
            //{
            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + capital + "- Bayrak Rengi: " + flagColour;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));
            //Console.WriteLine(countryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar


            //int sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(sum(20, 42));
            //Console.WriteLine(sum(85, 96));
            //Console.WriteLine(sum(56, 89));
            //Console.WriteLine(sum(14, 15));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result=(exam1+exam2+exam3)/3;
                if(result >= 50)
                {
                    return student+" İsimli öğrenci sınavı geçti  " + "Ortalama: " + result;
                }
                else
                {
                    return student + "isimli öğrenci başarısız oldu."+" Ortalama: "+result;
                }
            }
            Console.WriteLine(ExamResult("Melike", 85, 96, 79));
            Console.WriteLine(ExamResult("Adem", 52, 48, 45));

            #endregion




            Console.Read();
        }
    }
}
