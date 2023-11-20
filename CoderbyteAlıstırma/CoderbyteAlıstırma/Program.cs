using System;
using System.Linq;

class MainClass
{

    
   

    static void Main()
    {

        // 1.SORU
        /*Console.WriteLine("Pozitif bir sayı giriniz:");
        int elemansayisi = Convert.ToInt32(Console.ReadLine());
        int[] sayilar = new int[elemansayisi];
        for(int i = 0; i < elemansayisi; i++)
        {
            Console.WriteLine("{i+1}. sayısı giriniz:");
            sayilar[i]= Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i <elemansayisi; i++)
        {
            if (sayilar[i] %2 == 0)
            { Console.WriteLine(sayilar[i]); }
        } */

        //2.SORU

        /*Console.Write("Hangi Sayının Bölünmesini İstersiniz: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Kaç Adet Sayı Girmek İstersiniz: ");
        int sayiAdeti = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[sayiAdeti];
        for (int i = 0; i < sayiAdeti; i++)
        {
            Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Girmiş Olduğunuz Çift Sayılar: ");
        int bolonebilenSayi = 0;
        for (int i = 0; i < sayiAdeti; i++)
        {
            if (sayiDizisi[i] % m == 0 || sayiDizisi[i] == m)
            {
                bolonebilenSayi++;
                Console.Write(sayiDizisi[i] + " ");
            }
        }*/

        // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.


        Console.WriteLine("Bir cümle yazınız:");
        string cümle= Console.ReadLine();
        string[] kelimeler = cümle.Split(' ');
        Console.WriteLine("Kelime sayısı:" + kelimeler.Length);

        char[] harfler= cümle.ToArray();
        Console.WriteLine("Kelime sayısı:" + harfler.Length);






    }

}