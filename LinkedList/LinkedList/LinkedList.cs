using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        public T value { get; set; }
        public Node<T> next { get; set; }
        public Node()
        {

        }
        public Node(T data)
        {
            this.value = data;
        }
    }
    public class Linked_List<T> : IEnumerable<T>
    {
        public Node<T> head;
        public Node<T> tail;
        private int count;


        public int Count
        {
            get { return count; }
        }
        public Node<T> First
        {
            get
            {
                if (head != null)
                    return head;
                else return null;
            }
        }
        public Node<T> Last
        {
            get
            {
                if (tail != null)
                    return tail;
                else return null;
            }
        }

        public Linked_List()
        {
            count = 0;
        }
        public Linked_List(IEnumerable<T> collection)
        {
            if (collection.Count<T>() != 0)
            {
                Node<T> current;
                collection = collection.Reverse<T>();
                tail = new Node<T>(collection.First<T>());
                head = tail;
                Node<T> next = tail;
                collection = collection.Skip(1);

                foreach (var m in collection)
                {

                    current = new Node<T>(m);
                    current.next = next;
                    next = current;
                    head = current;

                }
            }
            else
            {
                head = null;
                tail = null;
            }
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
            }
            tail = node;
            count++;
        }

        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> prev = null;
            while (current != null)
            {
                if (current.value.Equals(data))
                {
                    if (prev != null)
                    {
                        prev.next = current.next;
                        if (current.next == null)
                            tail = prev;
                    }
                    else
                    {
                        head = head.next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                prev = current;
                current = current.next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
