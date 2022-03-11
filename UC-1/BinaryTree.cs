using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public bool Add(int value)

        {
            Node before = null, after = this.Root;

            while(after != null)
            {
                before = after;

            if(value<after.Data)
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

            Node NewNode = new Node();
            NewNode.Data = value;

            if (this.Root == null)
            {
                this.Root = new Node();
            }
            else
            {
                if (value < before.Data)
                    before.LeftNode = NewNode;
                else
                    before.RightNode = NewNode;
            }
            return true;
        }
            public void TravarsePreorder(Node Parent)
        {
            if(Parent!=null)
            {
                Console.WriteLine(Parent.Data + " ");
                TravarsePreorder(Parent.LeftNode);
                TravarsePreorder(Parent.RightNode);
            }
        }
    }
}
