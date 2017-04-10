using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked_List<int> list = new LinkedList.Linked_List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("after removing {0}", i);
                list.Remove(i);
                foreach (var m in list)
                    Console.WriteLine(m);

                Console.WriteLine("Count={0}", list.Count);
                Console.WriteLine("First node's value is {0}", list.First.value);
                Console.WriteLine("Last node's value is {0}", list.Last.value);
            }

            int[] massive = { 1, 2, 3, 4, 5 };
            Linked_List<int> mylist = new Linked_List<int>(massive);
            foreach (var m in mylist)
                Console.WriteLine(m);

        }
    }
}
