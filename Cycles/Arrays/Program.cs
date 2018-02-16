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
            string result = CapitalizeEnglishCaption("how i met your mother");
            string expected = "How I Met Your Mother";
            Console.WriteLine(result);
            if (expected.Equals(result))
            {
                Console.WriteLine("Works");
            }
            else
            {
                Console.WriteLine("Fail");
            }
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
