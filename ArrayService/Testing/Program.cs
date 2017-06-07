using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayService;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Services.CreateArray();
            Services.PrintArray(a);
            int x = 100, y = 200;
            Services.Swap(ref x, ref y);
            Console.WriteLine("x=" + x + "; y=" + y);
            int[] arr = { 1, 2, 3, 4};
           // Services.MergeSort(arr, 0, arr.Length);
          //  Services.MergeSort(a, 0, a.Length - 1);
            Services.PrintArray(a);
        }
    }
}
