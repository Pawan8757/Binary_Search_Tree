using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(6);
            binaryTree.Add(1);
            binaryTree.Add(5);
            binaryTree.Add(7);
            binaryTree.Add(9);

            binaryTree.TravarsePreorder(binaryTree.Root);

        }
    }
}