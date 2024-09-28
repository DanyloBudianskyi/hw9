using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public class MyBinTree<T> where T : IComparable<T>
    {
        private Node<T> root;
        public void Add(T data)
        {

            Node<T> newNode = new Node<T>();
            newNode.Data = data;
            newNode.Left = null;
            newNode.Right = null;
            if (root == null)
            {
                root = newNode;
                return;
            }
            Node<T> current = root;
            Node<T> parent = null;

            while (true)
            {
                parent = current;

                if (data.CompareTo(current.Data) < 0)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = newNode;
                        break;
                    }
                }
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        break;
                    }
                }

            }
        }

        private void InOrder(Node<T> node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Data + " ");
                InOrder(node.Right);
            }
        }
        private void ReverseOrder(Node<T> node)
        {
            if (node != null)
            {
                ReverseOrder(node.Right);
                Console.Write(node.Data + " ");
                ReverseOrder(node.Left);
            }
        }
        public void Print(bool direction = false)
        {
            if (direction) { InOrder(root); }
            else { ReverseOrder(root); }
        }
        private class Node<T>
        {
            public Node<T> Right { get; set; }
            public Node<T> Left { get; set; }
            public T Data { get; set; }
        }
    }

}