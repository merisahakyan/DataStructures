using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayService
{
    public static class Services
    {
        public static int[] CreateArray()
        {
            Random r = new Random();
            int n = r.Next(1, 20);
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(0, 100);
            }
            return array;
        }
        public static void PrintArray(int[] array)
        {
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }

        public static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i;
                for (; j > 0 && temp < arr[j - 1]; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = temp;
            }
            return arr;
        }
        public static int[] BinarySort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int first = 0;
                int last = i;
                int mid = last / 2;
                while (last >= first)
                {
                    if (arr[i + 1] == arr[mid])
                        break;
                    if (arr[i + 1] > arr[mid])
                        first = mid + 1;
                    else
                        last = mid - 1;
                    mid = (last + first) / 2;
                }
                int temp = arr[i + 1];
                for (int j = i + 1; j > mid; j--)
                { arr[j] = arr[j - 1]; }
                arr[mid] = temp;
            }
            return arr;
        }


        public static void MergeSort(int[] items)
        {
            if (items.Length <= 1)
            {
                return;
            }
            int leftSize = items.Length / 2;
            int rightSize = items.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];
            Array.Copy(items, 0, left, 0, leftSize);
            Array.Copy(items, leftSize, right, 0, rightSize);
            MergeSort(left);
            MergeSort(right);
            Merge(items, left, right);
        }
        private static void Merge(int[] items, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int targetIndex = 0;
            int remaining = left.Length + right.Length;
            while (remaining > 0)
            {
                if (leftIndex >= left.Length)
                {
                    items[targetIndex] = right[rightIndex++];
                }
                else if (rightIndex >= right.Length)
                {
                    items[targetIndex] = left[leftIndex++];
                }
                else if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    items[targetIndex] = left[leftIndex++];
                }
                else
                {
                    items[targetIndex] = right[rightIndex++];
                }
                targetIndex++; remaining--;
            }
        }
    }
}
