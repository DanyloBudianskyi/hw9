namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> s = new MyStack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Print();
            s.Pop();
            s.Print();
            Console.WriteLine(s.Peek());
        }
    }
}
