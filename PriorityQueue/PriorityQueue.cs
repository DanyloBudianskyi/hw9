using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class MyPriorityQueue<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] Items;
        private int Count;
        private int position = -1;
        public MyPriorityQueue()
        {
            Items = new T[0];
            Count = 0;
        }
        public void Enqueue(T item)
        {
            if (Count == Items.Length)
            {
                Array.Resize(ref Items, Items.Length + 1);
            }
            Items[Count] = item;
            Count++;
            Array.Sort(Items);

        }
        public T Dequeue()
        {
            if (Count == 0) throw new InvalidOperationException("Queue is empty");
            T item = Items[0];
            for (int i = 1; i < Items.Length; i++)
            {
                Items[i - 1] = Items[i];
            }
            Count--;
            Array.Resize(ref Items, Items.Length - 1);
            return item;
        }
        public T Current {
            get { return Items[position]; }
        }
        object IEnumerator.Current => Current;
        public void Dispose(){}
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            position++;
            return (position < Count);
        }
        public void Reset()
        {
            position = -1;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void print()
        {
            foreach(var item in Items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
