﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {
        static void SelectionSort(ref int[] a)
        {
            int max_index;
            for (int i = 0; i < a.Length; i++)
            {
                max_index = Max(a, i);
                Swap(ref a[max_index], ref a[a.Length - 1 - i]);
            }

        }
        static int Max(int[] a, int n)
        {
            int index = 0;
            for (int i = 1; i < a.Length - n; i++)
                if (a[i] > a[index])
                    index = i;
            return index;
        }
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 8, 6, 3, 5, 2 };
            SelectionSort(ref a);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
