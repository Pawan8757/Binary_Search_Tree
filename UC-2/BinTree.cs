using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public class binaryTree
    {
        public Node Root { get; set; }
        public bool Add(int value)
        {
         Node before = null, after = this.Root;
   
            while (after != null)
            {
                before = after;

                if (value < after.Data)
                {
                    after = after.LeftNode;
                }

                else if (value > after.Data)
                {
                    after = after.RightNode;
                }

                else
                {
                    return false;
                }
            }
            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)
            {
                this.Root = newNode;
            }

            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;        }

        public void TraversePreorder(Node Parent)
        {
            if (Parent != null)
            {
                Console.WriteLine(Parent.Data + "");
                Console.WriteLine("------------------------------ Left node");
                TraversePreorder(Parent.LeftNode);
                Console.WriteLine("------------------------------ Right node");
                TraversePreorder(Parent.RightNode);

            }
        }

    }
}