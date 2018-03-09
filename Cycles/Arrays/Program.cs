using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int[,] a = new int[n, n];
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = p++;
                }
            }
            var result = ArrayUtilities.GetMaxElementRow(a);
            ArrayUtilities.PrintArray(result);
            Console.WriteLine();
        }

        static void PrintOneSymbolPerLine()
        {
            char[] name = { 'P', 'E', '6', 'O', '0' };
            int n = name.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        //In: "how i met your mother"
        //Out: "How I Met Your Mother"
        public static string CapitalizeEnglishCaption(string caption)
        {
            string[] result = caption.Split(' ');
            int n = result.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(char.ToUpper(result[i][0]));
                sb.Append(result[i].Substring(1));
                sb.Append(" ");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
