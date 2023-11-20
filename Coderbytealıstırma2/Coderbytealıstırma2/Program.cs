using System;
using System.Collections.Immutable;

namespace Coderbytealıstırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("dizi kaç elemanlı olsun?");
            int a = Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[a];

            for (int i = 0; i < a; i++) 
            {
                strings[i] = Console.ReadLine();
                
            }

            Array.Sort(strings);

            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
            


            /*
            string hobiler = "yüzme, spor, voleybol ";
            char[] virgul = { ',' };
            string[] hobidizisi =hobiler.Split(virgul);

            foreach(string s in hobidizisi) { Console.WriteLine(s); }

            string[] hobilerr =hobiler.Split(',');
            foreach (string s in hobilerr) { Console.WriteLine(s); }
            */


        }
    }
}
