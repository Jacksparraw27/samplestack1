using System;

namespace StackUsingLinkedList_CSharp
{
    class Node
    {
        public int info;
        public Node Node;
        public Node(int i, Node n)
        {
            info = 1;
            Next = n;
        }
    }
    class Stacks
    {
        Node top;
        public Stacks()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
    }
}
