namespace Stack
{
    public class MyStack<T>
    {
        private T[] Items;
        private int _Size;
        public MyStack()
        {
            Items = new T[0];
            _Size = 0;
        }
        public void Push(T item)
        {
            if (_Size == Items.Length)
            {
                Array.Resize(ref Items, Items.Length +1);
                
            }
            Items[_Size++] = item;
        }
        public void Pop()
        {
            if(_Size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            Array.Resize(ref Items, --_Size);
        }
        public T Peek()
        {
            if (_Size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return Items[Items.Length - 1];
        }
        public int Size()
        {
            return _Size;
        }
        public bool isEmpty()
        {
            return (_Size == 0) ? true : false;
        }
        public void Print()
        {
            foreach (var item in Items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
