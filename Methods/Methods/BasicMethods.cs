using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class BasicMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(6));
            Console.WriteLine(Sum(3, 8));
            Console.WriteLine(Sum(0, 6));
        }

        public static float Average(int n)
        {
            int sum = Sum(n);
            float result = (float)sum / n;
            return result;
        }

        public static int Sum(int a)
        {
            return Sum(0, a);
        }

        public static int Sum(int a, int b)
        {
            if (a > b)
            {
                int c = a;
                a = b;
                b = c;
            }   
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
