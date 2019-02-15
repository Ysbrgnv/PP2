using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());  //get a size of triangle
            for (int i = 1; i <=n; ++i)        //lines
            {
                for (int j = 1; j <= i; ++j)    //columns
                {
                    Console.Write("[*]");

                }
                Console.WriteLine();            //end of line after every line
            }
        }
    }
}