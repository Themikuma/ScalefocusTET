using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            SumUntilZero();
        }

        private static void BooleanExpressions()
        {
            bool a = true;
            bool b = true;
            bool c = true && !(a || !b);
            bool d = !true;
            int num = 64321;
            if ((c == d) || (a != b))
            {
                Console.WriteLine(num % 10);
            }
            else if (a != c)
            {
                Console.WriteLine(num / 10);
            }
            else
            {
                Console.WriteLine(++num);
            }
        }

        private static void WhileLoopDemo()
        {
            int a = 1;
            int n = int.Parse(Console.ReadLine());
            while (a <= n)
            {
                int b = a;
                while (b < n + a)
                {
                    Console.Write($"{b} ");
                    b++;
                }
                a++;
                Console.WriteLine();
            }
        }

        private static void SumNumbers()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }

        private static void SumUntilZero()
        {
            int sum = 0;
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }
                sum = sum + n;
            }
            Console.WriteLine(sum);
        }
    }
}
