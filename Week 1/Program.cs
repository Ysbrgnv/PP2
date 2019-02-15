using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static bool Prime(int c) //function for check is number prime of not 
        {
            if (c == 1)
                return false;
            for (int i = 2; i < c; i++)
            {
                if (c % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);           // get input "size"
            int[] a = new int[n];           //new array
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                string ss = Console.ReadLine();
                int b = int.Parse(ss);
                a[i] = b;                   //put numbers in new array
            }
            for (int i = 0; i < n; i++)
            {
                if (Prime(a[i]))
                {
                    cnt++; // counter of prime numbers with Prime() function
                }
            }
            Console.WriteLine(cnt); // quantity of prime numbers
            for (int i = 0; i < n; i++)
            {
                if (Prime(a[i]))
                {
                    Console.Write(a[i]); // prime numbers
                }
            }
        }
    }
}
