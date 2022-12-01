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
        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed.");
        }

        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top = top.next; //Make top poiny to the next node in sequence
        }

        public void display()
        {
            Node tap;
            if (empty(//if stack is empty));
                top = top.next;
            //Make top point to the next node in sequence
        }
    }
}
