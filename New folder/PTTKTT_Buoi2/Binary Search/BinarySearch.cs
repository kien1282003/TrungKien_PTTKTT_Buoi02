using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine("\nNhap so can tim: ");
            int key = int.Parse(Console.ReadLine());
            int result = binarySearch(a, key, 11);
            if (result == -1)
                Console.WriteLine("Khong tim thay vi tri");
            else
                Console.WriteLine("Phan tu duoc tim thay tai vi tri: " + result);
            Console.ReadKey();
        }
        public static int binarySearch(int[] A, int key, int n)
        {
            int mid;
            int left = 0; // vị trí phần tử đầu tiên trong mảng
            int right = n - 1; // vị trí phần tử cuối cùng trong mảng
            while (left <= right)
            {
                mid = (left + right) / 2; //vị trí giữa mảng
                if (A[mid] == key)
                    return mid;
                if (key < A[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1; // không tìm thấy key trong mảng nên trả về vị trí -1.
        }
    }
}
