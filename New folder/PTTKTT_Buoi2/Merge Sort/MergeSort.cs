using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        public static void MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return;

            int[] left = new int[array.Length / 2];
            int[] right = new int[array.Length - left.Length];

            Array.Copy(array, 0, left, 0, left.Length);
            Array.Copy(array, left.Length, right, 0, right.Length);

            MergeSort(left);
            MergeSort(right);
            Merge(array, left, right);
        }

        private static void Merge(int[] result, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
                result[k++] = left[i++];

            while (j < right.Length)
                result[k++] = right[j++];
        }
        private static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = { 22, 3, 9, 6, 1, 5, 23, 75 };
            Console.WriteLine("Mang ban dau:");
            PrintArray(array);

            MergeSort(array);

            Console.WriteLine("\nSap xep:");
            PrintArray(array);

            Console.ReadKey();
        }


    }
}