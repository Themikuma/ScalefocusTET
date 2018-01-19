using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome(10));
            Console.WriteLine(Palindrome(11));
            Palindrome(99);
        }

        public static bool Palindrome(int a)
        {
            if (a < -1000000 || a > 1000000)
            {
                throw new ArgumentOutOfRangeException();
            }
            int c = a;
            int mirror = 0;
            while (c > 0)
            {
                int b = c % 10;
                c = c / 10;
                mirror = mirror * 10 + b;
            }
            if (a == mirror)
            {
                return true;
            }
            return false;
        }
    }
}
