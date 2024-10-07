﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("----Portakal Birim Fiyatı:" + orangePrice +  " TL");
            //Console.WriteLine("----Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("----Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("----Domates Birim Fiyatı:" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice *  strawberryGram;
            //double potatoTotalPrice= potatoPrice * potatoGram;
            //double tomatoTotalPrice= tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma " + " - Birim Fİyatı:" + applePrice + " - Gramı:" + appleGram + " - Toplam Tutar:" + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal " + " - Birim Fİyatı:" + orangePrice + " - Gramı:" + orangeGram + " - Toplam Tutar:" + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek " + " - Birim Fİyatı:" + strawberryPrice + " - Gramı:" + strawberryGram + " - Toplam Tutar:" + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates " + " - Birim Fİyatı:" + potatoPrice + " - Gramı:" + potatoGram + " - Toplam Tutar:" + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates " + " - Birim Fİyatı:" + tomatoPrice + " - Gramı:" + tomatoGram + " - Toplam Tutar:" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı:" + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();


            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdendityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdendityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu TC Kimlik No:" + passengerIdendityNumber + " -Yolcu :" + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı Giriş İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            //exam1 =double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
            //exam2 =double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            //exam3 =double.Parse(Console.ReadLine());

            //result=(exam1+exam2+exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);



            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;

            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);  

            #endregion


            Console.Read();

        }
    }
}