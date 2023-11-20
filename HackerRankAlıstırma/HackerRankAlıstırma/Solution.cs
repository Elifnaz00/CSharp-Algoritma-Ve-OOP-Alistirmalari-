using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlıstırma
{
    class Solution
    {

        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            string evenIndexes = "";
            string oddIndexes = "";



            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {

                string myString1 = Console.ReadLine();
                char[] myCharArray1 = myString1.ToCharArray();


                for (int j = 0; j < myCharArray1.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenIndexes += myCharArray1[j] + " ";

                    }
                    if (j % 2 != 0)
                    {
                        oddIndexes += myCharArray1[j] + " " ;
                    }
                    

                }

                Console.WriteLine(evenIndexes + " " + oddIndexes);

            }
           


        }
    }
}
