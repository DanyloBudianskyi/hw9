namespace PriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyPriorityQueue<int> queue = new MyPriorityQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.print();
            queue.Dequeue();
            queue.print();
        }
    }
}
