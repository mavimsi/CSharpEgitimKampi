using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region if

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if(password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}





            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}






            //int number;

            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number ==5)
            //{
            //    Console.Write("Sayı Hatalı");
            //}
            //else
            //{
            //    Console.Write("Sayı Doğru");
            //}






            // int exam1, exam2, exam3, average;
            // string result= "";

            // Console.Write("Sınav 1: ");
            // exam1=int.Parse(Console.ReadLine());

            // Console.Write("Sınav 2: ");
            // exam2=int.Parse(Console.ReadLine());

            // Console.Write("Sınav 3: ");
            // exam3 =int.Parse(Console.ReadLine());

            // average = (exam1 + exam2 + exam3) / 3;

            // Console.WriteLine("Sonuçların Ortalaması: " + average);

            // if (average>0 & average<=49)
            // {
            //     result = "Sonuç Vasat";
            // }
            // if (average > 49 & average < 70)
            // {
            //     result = "Sonuç Orta";
            // }
            // if (average > 69 & average < 85)
            // {
            //     result = "Sonuç İyi";
            // }
            // if (average > 84 )
            // {
            //     result = "Sonuç Çok İyi";
            // }

            //Console.WriteLine(result);





            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city=="adana" | city=="ankara" | city=="bursa" | city=="trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}





            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //string username= Console.ReadLine();

            //if (username!="admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}

            #endregion

            #region Mod İşlemleri %

            //int number;
            //number = 26;
            //int result = number % 5;

            //Console.WriteLine(result);







            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2=int.Parse(Console.ReadLine());


            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);








            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if ( number %2==0 )
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}


            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen takımınızın ilk harfiniz giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team=='g' | team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            #endregion

            #region Örnek Proje Uygulama

            //Console.WriteLine("****** C# Eğitim Kampı ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1_Ana Yemekler");
            //Console.WriteLine("2_Çorbalar");
            //Console.WriteLine("3_Pizzalar");
            //Console.WriteLine("4_İçecekler");
            //Console.WriteLine("5_Tatlılar");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("_____Ana Yemekler_____");
            //    Console.WriteLine();
            //    Console.WriteLine("1_Köri Soslu Tavuk");
            //    Console.WriteLine("2_Kızartma Tabağı");
            //    Console.WriteLine("3_Fasulye Pilav");
            //    Console.WriteLine("4_Fırında Somon");
            //    Console.WriteLine("5_Patlıcan Musakka");
            //    Console.WriteLine("_____Ana Yemekler_____");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("_____Çorbalar_____");
            //    Console.WriteLine();
            //    Console.WriteLine("1_Mercimek Çorbası");
            //    Console.WriteLine("2_Ezogelin Çorbası");
            //    Console.WriteLine("_____Çorbalar_____");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("_____Pizzalar_____");
            //    Console.WriteLine();
            //    Console.WriteLine("1_Akdeniz Pizza");
            //    Console.WriteLine("2_Margaritta");
            //    Console.WriteLine("3_Tavuklu Pizza");
            //    Console.WriteLine("_____Pizzalar_____");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("_____İçecekler_____");
            //    Console.WriteLine();
            //    Console.WriteLine("1_Kola");
            //    Console.WriteLine("2_Ayran");
            //    Console.WriteLine("3_Meyve Suyu");
            //    Console.WriteLine("4_Şalgam");
            //    Console.WriteLine("5_Su");
            //    Console.WriteLine("_____İçecekler_____");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("_____Tatlılar_____");
            //    Console.WriteLine();
            //    Console.WriteLine("1_Triliçe");
            //    Console.WriteLine("2_Kazan Dibi");
            //    Console.WriteLine("3_Sütlaç");
            //    Console.WriteLine("_____Tatlılar_____");
            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi"); break;
            //}

            #endregion

            # region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("Lütfen Yapmak İstediğini İşlemi Seçiniz: ");
            symbol=char.Parse(Console.ReadLine());

            Console.Write("1.Sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result=number1 + number2;
                    Console.WriteLine("Toplam: "+result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: "+result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: "+result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: "+result);
                    break;
            }


            #endregion



            Console.Read();

        }
    }
}
