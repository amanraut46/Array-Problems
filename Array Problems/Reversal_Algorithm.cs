using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problems
{
    public class Reversal_Algorithm
    {
        public void leftRotate(int[] arr,int d)
        {
            if (d==0)
            {
                return;
            }
            int n = arr.Length;

            rotateArry(arr, 0, d-1);
            rotateArry(arr, d, n - 1);
            rotateArry(arr, 0, n-1);
        }

        public void rotateArry(int[] arr, int start, int end)
        {
            
            while (start<end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }


        public static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int d = 2;
            Reversal_Algorithm reversal_Algorithm = new Reversal_Algorithm();
            reversal_Algorithm.leftRotate(arr, d);
            reversal_Algorithm.printArray(arr);
            Console.ReadLine();
        }

        private void printArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ",");
            }
        }
    }
}
