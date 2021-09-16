using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problems
{
    public class ArrayRotation
    {
        public static void Main()
        {
            int[] arr = new int[] {1,2,3,4,5,6,7 };
            int d = 2;
            leftRotate(arr, arr.Length, d);
            printArray(arr, arr.Length);
            Console.ReadLine();
        }

        private static void printArray(int[] arr, int length)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ",");
            }
        }

        private static void leftRotate(int[] arr, int length, int d)
        {
            for (int i = 0; i <d; i++)
            {
                oneRotate(arr, length);
            }
        }

        private static void oneRotate(int[] arr, int length)
        {
            int temp = arr[0];
            for (int i = 0; i < length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[length - 1] = temp;
        }
    }
}
