using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a==0)
                {
                    break;
                }
                int n = int.Parse(Console.ReadLine());
                int divider = (int)Math.Pow(10, n - 1);
                a = a / divider;
                int c = a % 10;
                Console.WriteLine(c); 
            }
        }
    }
}
