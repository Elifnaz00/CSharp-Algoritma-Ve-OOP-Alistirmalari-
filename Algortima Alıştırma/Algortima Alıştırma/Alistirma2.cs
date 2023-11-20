using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortima_Alıştırma
{
    internal class Alistirma2
    {
        static void Main(string[] args)
        {
            /*int sayi1;
            int sayi2;
            int sayi3 = 40;
            int sayi4 = 12;
            int sonuc = sayi3 - sayi4;
            string isim;
            string soyisim;
            int sayi5;



            int Topla(int sayi1, int sayi2)
            {

                return sayi1 + sayi2;

            }
            Console.WriteLine(Topla(20, 30));
            Console.WriteLine(sonuc);
            Console.Write(sayi3+sayi4);

            

            Console.WriteLine("İsminizi Giriniz:");
            isim = Console.ReadLine();


            Console.WriteLine("Soyisminizi Giriniz:");
            soyisim = Console.ReadLine();

            Console.WriteLine("İsminiz:" + isim + " " + "Soyisminiz:" + soyisim);

            Console.WriteLine("10 a kadar Çarpım tablosu değerleri sıralanması için sayı giriniz.");
            sayi5 = Convert.ToInt32(Console.ReadLine());

            int sayac = 1;
            int carpim;

            for (int i = 0; i < 10; i++)
            {
                
                carpim = sayi5 * sayac ;
                sayac++;
                Console.WriteLine(carpim);
            }


            int deger1;
            int deger2;
            Console.WriteLine("Kareleri toplamı alınacak 1.sayıyı girin:");
            deger1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kareleri toplamı alınacak 1.sayıyı girin:");
            deger2 = int.Parse(Console.ReadLine());

            int sonuc1 = deger1 * deger1 + deger2 * deger2;
            Console.WriteLine(sonuc1); */


            double toplam = 0 ;
            for (int i = 1; i < 11; i++)
            {
                toplam += Math.Pow(i, 3);
            }


            /*double toplamSonuc=0 ;
            int sayac = 1;
            while (sayac < 10 )
            {
                toplamSonuc += Math.Pow(sayac, 3);
                sayac++;

            }*/


            double toplamSonuc = 0;
            int sayac = 1;
            while (sayac < 10 )
            {
                toplamSonuc += Math.Pow(sayac, 3);
                sayac++;

                if(sayac == 10 ) {
                    break;
                
                }
                
            }
            Console.WriteLine(toplamSonuc);
            








        }
    
    }
}
