using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArrayUtilities
    {
        public static int GetMaxElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int GetAbsoluteMaxElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int SumElements (int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i]; 
            }
            return sum;
        } 

        public static int[] GetMaxElementRow(int[,] arr)
        {
            int n = (int)Math.Sqrt(arr.Length);
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int max = arr[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
                result[i] = max;
            }
            return result;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
