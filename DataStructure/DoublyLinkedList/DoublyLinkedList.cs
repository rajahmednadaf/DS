using System.Collections.Generic;

namespace DataStructure.DoublyLinkedList
{
    public class Node
    {
        public int Val { get; set; }
        public Node Next;
        public Node Prev;
        public Node(int val)
        {
            this.Val = val;
        }
    }


    public class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public void InsertAtFirst(int val)
        {
            var node = new Node(val);
            node.Next = this.head;
            node.Prev = null;

            if (head != null)
                head.Prev = node;

            this.head = node;

            this.size++;
        }

        public void Display()
        {
            Console.WriteLine("====================== traversal =============================");
            Node temp = this.head;
            Node Last = null; 

            while(temp != null)
            {
                Console.WriteLine($"{temp.Val} -->");
                Last = temp;
                temp = temp.Next; 
            }

            Console.WriteLine("====================== Reversing  =============================");
            while (Last != null)
            {
                Console.WriteLine($"{Last.Val} -->");
                Last = Last.Prev;
            }
        }

        public void InsertAtEnd(int val)
        {
            if (this.head == null)
            {
                InsertAtFirst(val);
                return;
            }

            Node temp = this.head;
            Node last = null;
            while (temp != null)
            {
                last = temp;
                temp = temp.Next;
            }

            Node node = new Node(val);
            last.Next = node;
            node.Prev = last;
            node.Next = null;
        }

        public void InserAfterNode(int afterValue, int val)
        {
            if (head == null)
            {
                Console.WriteLine($"The list is empty");
                InsertAtFirst(val);
                return;
            }

            Node afterNode = FindTheNode(afterValue);
            if (afterNode == null)
            {
                Console.WriteLine($"Node such value present in the list {afterValue}");
                return;
            }

            Node node = new Node(val);
            node.Next = afterNode.Next;
            
            node.Prev = afterNode;

            if(afterNode.Next != null)
            {
                afterNode.Next.Prev = node;
            }
            afterNode.Next = node;
        }

        private Node FindTheNode( int afterValue)
        {
            Node node = this.head;
            while (node != null)
            {
                if (node.Val == afterValue)
                {
                    return node;
                }
                node = node.Next;
            }

            return null;
        }
    }
}
