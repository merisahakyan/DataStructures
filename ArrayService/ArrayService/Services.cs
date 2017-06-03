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


        public static void MergeSort(int[] arr, int first, int last)
        {
            if (first < last)
            {
                int mid = (first + last) / 2;
                MergeSort(arr, first, mid);
                MergeSort(arr, mid + 1, last);
                Merge(arr, first, mid, last);
            }
        }
        public static void Merge(int[] arr, int first, int mid, int last)
        {
            int[] temp = new int[arr.Length];
            int first1 = first;
            int last1 = mid;
            int first2 = mid + 1;
            int last2 = last;
            int i = 0;
            for (; first1 <= last1 && first2 <= last2; i++)
            {
                if (arr[first1] < arr[first2])
                {
                    temp[i] = arr[first1];
                    first1++;
                }
                else
                {
                    temp[i] = arr[first2];
                    first2++;
                }
            }
            if (first1 <= last1)
                for (; first1 <= last1; i++)
                    temp[i] = arr[first1++];
            else
                for (; first2 <= last2; i++)
                    temp[i] = arr[first2++];
            int k = 0;
            for (int j = first; j < last; j++)
                arr[j] = temp[k++];
            
        }
    }
}
