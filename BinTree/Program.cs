namespace BinTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBinTree<int> tree = new MyBinTree<int>();
            tree.Add(8);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);

            tree.Print(true); // 137815

        }
    }
}
