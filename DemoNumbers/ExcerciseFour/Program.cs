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
            SumNtoM();
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

    }
}
