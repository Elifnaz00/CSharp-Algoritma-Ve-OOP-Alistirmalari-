using System;
using System.Collections.Generic;
using System.Linq;

namespace hackerrank7
{
    internal class Program
    {
        
            


        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr= Console.ReadLine().TrimEnd().Split(' ').ToList().Select(x=> Convert.ToInt32(x)).ToList();
            arr.Reverse();
            Console.WriteLine(String.Join(" ", arr)); 

           


            
         }
    }
}
