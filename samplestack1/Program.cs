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
            next = n;
        }
    }
}