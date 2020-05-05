using System;
using System.ComponentModel;

namespace ListsAndGraphs
{
    class LinkedList
    {
        public Node first { get; }
        
        /* This is the constructor */
        public LinkedList(int data)
        {
            first = new Node(data, null);
        }

        public bool append(int data)
        {
            Node finalNode;
            
            finalNode = this.getLast();
            finalNode.next = new Node(data, finalNode);

            return true;
        }

        private Node getLast()
        {
            /* How do we return the final node? 
             * If you want to test in your program remember to make it public
             */
        }

        /* This is the destructor */
        ~LinkedList()
        {
            /* Here you need to walk along the list to find the last listitem,
             * and destroy it.
             * 
             * Although... nothing stops you from actually starting at the
             * beginning and walking along, deleting them until .next is null!
             * 
             * If you're thinking laterally, perhaps something recursive might
             * work.  Think 'cascading deletion', and you might get a clue.
             * Hint: You could also make a destructor for Node.
             */
        }

        public Node findItem(int data)
        {
            /* Return null if you can't find the item */
        }
    }

    class Node
    {
        public int data { get; set; }
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
            
            tmp = l.first;
            Console.Out.WriteLine(tmp.data);
            while ((tmp = tmp.next) != null)
                Console.Out.WriteLine(tmp.data);
        }
    }
}
