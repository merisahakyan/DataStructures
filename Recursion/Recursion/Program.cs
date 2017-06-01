using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        public static int Bajanarar(int a, int b)
        {
            if (b == 0)
                return a;
            return Bajanarar(b, a % b);
        }
        public static int Qanord(int a, int b)
        {
            if (a < 0)
                return -1;
            else
                return 1 + Qanord(a - b, b);
        }
        public static int Artadryal(int a, int b)
        {
            if (b == 0)
                return 0;
            else
                if (b > 0)
                return a + Artadryal(a, b - 1);
            else
                return Artadryal(a, b + 1) - a;
        }
        public static int K_Min(int[] a, int k)
        {
            int min = a[0];
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
            }
            for (int i = 0; i < a.Length; i++)
                if (a[i] == min)
                    a[i] = max;
            if (k == 1)
                return min;
            else
            {
                return K_Min(a, k - 1);
            }
        }
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine(Bajanarar(a, b));
            //}

            //while (true)
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine(Qanord(a, b));
            //}
            //while (true)
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine(Artadryal(a, b));
            //}
            while (true)
            {
                int l = int.Parse(Console.ReadLine());
                int[] a = new int[l];
                for(int i=0;i<l;i++)
                    a[i]= int.Parse(Console.ReadLine());
                Console.Write("k=");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine(K_Min(a,k));
            }
        }
    }
}
