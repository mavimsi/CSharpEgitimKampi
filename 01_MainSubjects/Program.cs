using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("selam");

            //Console.WriteLine("*** Yemek Tarifleri ***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***Yemek Tarifleri ***");

            #endregion

            #region String Değişkenler

            //string name;
            //name = "Gökçe";
            //Console.WriteLine(name);


            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, District, City;

            //customerName = "Ali";
            //customerSurname = "Poyraz";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //District = "Kadıköy";
            //City = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:"+District+"/"+City);
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();



            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 400 80 70";
            //customerEmail = "test@gmail.com";
            //District = "Sincan";
            //City = "Ankara";


            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + District + "/" + City);
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("**** Rezervasyon Kartı ****");

            #endregion

            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restorant Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("--Hamburger:" + hamburgerPrice + " TL");
            Console.WriteLine("--Pizza:"+pizzaPrice+" TL");
            Console.WriteLine("--Kola:" + cokePrice + " TL");
            Console.WriteLine("--Limonata:" + lemonadePrice + " TL");
            Console.WriteLine("--Kızartma:" + friesPrice + " TL");
            Console.WriteLine("--Su:" + waterPrice + " TL");
            Console.WriteLine() ;
            Console.WriteLine("**** Restorant Menü Fiyatı ****");

            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0;
            int lemonadeCount = 0;

            int totalHamburgerPrice, totalCokePrice, totalWaterPrice, totalFriesPrice, totalPizzaPrice, totalLemonadePrice;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice= cokeCount * cokePrice;
            totalWaterPrice= waterCount * waterPrice;
            totalFriesPrice= friesCount * friesPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totalLemonadePrice= lemonadeCount * lemonadePrice;

            Console.WriteLine("------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı:" + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı:" + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı:" + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı" + totalLemonadePrice + " TL");
            Console.WriteLine();

            int totalPrice=totalHamburgerPrice+totalCokePrice+totalWaterPrice+totalFriesPrice+totalPizzaPrice+totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrice + " TL");





            #endregion


            Console.Read();
        }
    }
}
