using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 0, 1, -6, 3, -9 };
            //Console.WriteLine(Max(a));
            //Console.WriteLine(K_from_N(6,2));

            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                List<int> A = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    A.Add(n - i);
                }
                List<int> B = new List<int>();
                List<int> C = new List<int>();
                Print(A);
                Print(B);
                Print(C);
                Tower(n, A, B, C);
                Print(A);
                Print(B);
                Print(C);
            }

        }
        static void Print(List<int> list)
        {
            if (list.Count == 0)
                Console.WriteLine("empty list");
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        
        static void Tower(int n, List<int> source, List<int> dest, List<int> bridge)
        {
            if (n == 1)
            {
                dest.Add(source.Last());
                source.RemoveAt(source.Count-1);
            }
            else
            {
                Tower(n - 1, source, bridge, dest);
                Tower(1, source, dest, bridge);
                Tower(n - 1, bridge, dest, source);
            }
        }
        public static int K_from_N(int n, int k)
        {
            if (k == 0) return 1;
            if (k > n)
                return 0;
            if (k == n)
                return 1;
            else
                return K_from_N(n - 1, k - 1) + K_from_N(n - 1, k);
        }
        public static int Max(int[] a)
        {
            if (a.Length == 1)
                return a[0];
            else
            {
                int[] b = new int[a.Length / 2];
                int[] c = new int[a.Length - b.Length];
                int i = 0;
                for (i = 0; i < b.Length; i++)
                    b[i] = a[i];
                for (int k = 0; k < c.Length; k++)
                {
                    c[k] = a[i++];
                }
                return Math.Max(Max(b), Max(c));
            }
        }
    }
}
