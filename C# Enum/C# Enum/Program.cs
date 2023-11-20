using System;

namespace C__Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Salı);
            Console.WriteLine((int)Gunler.Çarşamba);
            Console.WriteLine(Convert.ToInt32(Gunler.Cuma));
            Console.WriteLine(Convert.ToInt32(Gunler.Cumartesi));

            int sicaklik = Convert.ToInt32(Console.ReadLine());

            if(sicaklik < (int)HavaDurumu.Soğuk)
            {
                Console.WriteLine("Hava soğuk ");
            }
            if (sicaklik < (int)HavaDurumu.İyi)
            {
                Console.WriteLine("Hava normal");
            }


        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=22,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soğuk = 0 ,

        İyi = 25,

        Sıcak= 30,

        ÇokSıcak= 35

    }


}
