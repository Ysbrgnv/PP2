using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //get "size" of input
            int[] a = new int[n];                   // input data storage array
            for (int i = 0; i < n; ++i)
            {
                a[i] = int.Parse(Console.ReadLine()); // get the array itself
            }

            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j < 2; ++j)   // duplicate each element 
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
    }
}