using System;
using System.Collections.Generic;
using System.Linq;

namespace coderbytealgortima
{
    internal class Program
    {
        public static string FindIntersection(string[] strArr)
        {
            List<int> output = new List<int>();
            int[] l1 = strArr[0].Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            int[] l2 = strArr[1].Split(',').Select(x => Convert.ToInt32(x)).ToArray();

            
            for(int i = 0; i < l1.Length; i++) 
            {
                if (l2.Contains(l1[i]))
                {
                    output.Add(l1[i]);
                }
            }
            return string.Join(",", output.ToArray());
        }





        static void Main(string[] args)
        {
            Console.WriteLine(FindIntersection(Console.ReadLine()));    
        }
    }
}
