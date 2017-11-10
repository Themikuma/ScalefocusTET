using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseFour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringExcercise();
        }

        static void SumNtoM()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                sum += i; //sum = sum + i;
            }
            Console.WriteLine(sum);
        }

        static void PrintMatrix()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = (i - 1) * n + 1; j <= i * n; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        static void StringExcercise()
        {
            string s = Console.ReadLine();
            bool isCapitalLetter = true;
            bool isSmallLetter = true;
            foreach (var item in s)
            {
                isCapitalLetter = true;
                isSmallLetter = true;
                if (item < 97 || item > 122)
                {
                    isSmallLetter = false;
                }
                if (item < 65 || item > 90)
                {
                    isCapitalLetter = false;
                }
            }
            Console.WriteLine(isCapitalLetter || isSmallLetter);
        }
    }
}
