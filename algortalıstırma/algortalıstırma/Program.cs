using System;
using System.Diagnostics.CodeAnalysis;

namespace algortalıstırma
{
    internal class Program
    {
        public static int FirstFactorial(int sayi)
        {
            int sum = 0;

            for (int i = sayi; i > sayi/2; i--) 
            {
                
                if(sayi % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }   
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(FirstFactorial(Convert.ToInt32(Console.ReadLine())));

        }
    }
}
