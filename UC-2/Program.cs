using System;

namespace BinTree;

class Program
{
    public static void Main(string[] args)
    {
        binaryTree b = new binaryTree();

        b.Add(56);
        b.Add(30);
        b.Add(40);
        b.Add(20);
        b.Add(11);
        b.Add(3);
        b.Add(16);
        b.Add(95);
        b.Add(70);

        b.Add(65);
        b.Add(63);
        b.Add(67);
        b.Add(70);

        b.TraversePreorder(b.Root);
    }
}