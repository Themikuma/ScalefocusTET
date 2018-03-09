using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int p = 0;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = p++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
        }

        //public static string Reverse(string source)
        //{
        //    StringBuilder result = new StringBuilder();
        //    return "";
        //}
    }
}
