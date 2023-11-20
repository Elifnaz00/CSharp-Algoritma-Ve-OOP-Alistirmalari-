using System;

namespace c__struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dikdörtgen dikdörtgen = new Dikdörtgen();

            dikdörtgen.KısaKenar = 3;
            dikdörtgen.UzunKenar = 5;
            
            Console.WriteLine(dikdörtgen.AlanHesapla());
            
            
            Dikdörtgen_Struct dikdörtgenstruct = new Dikdörtgen_Struct();
            dikdörtgenstruct.KısaKenar = 4;
            dikdörtgenstruct.UzunKenar = 6;

            Console.WriteLine(dikdörtgenstruct.AlanHesapla());
        }

        class Dikdörtgen
        {
            public int KısaKenar;

            public int UzunKenar;

            public long AlanHesapla()
            {
                return this.KısaKenar * this.UzunKenar;
            }


        }
        struct Dikdörtgen_Struct
        {
            public int KısaKenar;

            public int UzunKenar;
            public long AlanHesapla()
            {
                return this.KısaKenar * this.UzunKenar;
            }

        }
    }
}
