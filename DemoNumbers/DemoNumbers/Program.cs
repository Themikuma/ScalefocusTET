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
            GetNthNumber();
        }
        static void GetNthNumber()
        {
            while (true)
            {
                int a = int.Parse(Console.ReadLine());+33                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       =++++++
                if (a == 0)
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
        static void GetNMinusINumber()
        {
            int a = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            int divider = (int)Math.Pow(10, n - i);
            a = a / divider;
            int c = a % (int)Math.Pow(10, i);
            Console.WriteLine(c);
        }

        static void HomeWorkTask2()
        {
            int a = int.Parse(Console.ReadLine());

            //DO STUFF HERE
            while (a > 0)
            {
                //DO STUFF HERE
                a = a / 10;

                //DO STUFF HERE
            }
        }
    }
}
