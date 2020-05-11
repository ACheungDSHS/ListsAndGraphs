/* Still a bit stuck in terms of writing the code, but had some help from Harvey and Toby, who explained a bit of the code for me */ 
using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace ListsAndGraphs
{
    class LinkedList
    {
        public Node first { get; }
        
        /* This is the constructor equivalent to def __init__(self, data) */
        public LinkedList(int data)
        {
            first = new Node(data, null);
        }

        public bool append(int data)
        {
            Node finalNode;
            
            finalNode = this.getLast();
            /* Set the pointer of the last list item to the new node */
            finalNode.next = new Node(data, finalNode);

            return true;
        }

        private Node getLast()
        {
            Node n;
            /* How do we return the final node? 
             * If you want to test in your program remember to make it public
             */

            /* 
             * Walk along the list, until the pointer next is null
             */
            n = this.first;

            while (n.next != null)
                n = n.next;
            return n;
        }

        public Node findItem(int data)
        {
            /* Return null if you can't find the item */

            /* make this! */
            Console.WriteLine("What node are you looking for?");
            int item = Console.ReadLine();

            While (n.next != item);
                n = n.next;
                Console.WriteLine("Item found");
            return null;
        }

        public void deleteItem(int data)
        {
            Node n;

            n = this.findItem(data);

            n.previous.next = n.next;
            n.next.previous = n.previous;

            /* n is now orphaned */
        }

        public void printAll()
        {
            /* do something */

            /* 
            tmp = l.first;
            Console.Out.WriteLine(tmp.data);
            while ((tmp = tmp.next) != null)
                Console.Out.WriteLine(tmp.data);
            */

        }

    }

    class Node
    {
        public int data { /* want to be able to read it */
            get; /* want to be able to write */ /*set;*/ }
        public Node next { get; set; }
        public Node previous { get; set; }

        public Node(int data, Node previous)
        {
            this.data = data;
            this.next = null;
            this.previous = previous;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l;
            Node tmp;

            l = new LinkedList(1);

            l.append(5);
            l.append(10);


            /* l.printAll() */
            
            tmp = l.first;
            Console.Out.WriteLine(tmp.data);
            while ((tmp = tmp.next) != null)
                Console.Out.WriteLine(tmp.data);

            l = null;
        }
    }
}
