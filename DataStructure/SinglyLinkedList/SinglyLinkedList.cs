using System.Net.Http.Headers;

namespace DataStructure.LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }

        public Node(int value, Node next)
        {
            this.Next = next;
            this.Value = value;
        }

    }

    public class SinglyLinkedList
    {
        public Node Head;
        public Node Tail { get; set; }
        public int Size { get; set; }

        public SinglyLinkedList()
        {
            this.Head = null;
            this.Tail = null;
            this.Size = 0;
        }

        public void InsertAtFirstLinkList(int value)
        {
            var node = new Node(value);
            node.Next = this.Head;
            this.Head = node;

            if (this.Tail is null)
                this.Tail = node;

            this.Size++;
        }

        public void DisplayList()
        {
            var tempNode = this.Head;

            while (tempNode != null)
            {
                Console.WriteLine($"{tempNode.Value} -->");
                tempNode = tempNode.Next;
            }
        }

        public void InsertAtEnd(int value)
        {
            if (Tail is null)
            {
                InsertAtFirstLinkList(value);
                return;
            }

            var node = new Node(value);
            this.Tail.Next = node;
            this.Tail = node;

            this.Size++;
        }

        public void InsertAtIndex(int value, int index)
        {
            if (index == 0)
            {
                InsertAtFirstLinkList(value);
                return;
            }

            if (this.Size == index)
            {
                InsertAtEnd(value);
                return;
            }

            var tempNode = this.Head;

            for (int i = 1; i < index; index++)
            {
                tempNode = tempNode.Next;
            }

            var node = new Node(value,tempNode.Next);
            tempNode.Next = node;


            this.Size++;

        }
        public int DeleteAtFirst()
        {
            int val = this.Head.Value;
            this.Head = this.Head.Next;

            if (Head == null)
                this.Tail = null;

            return val;
        }

        public Node GetNode(int index)
        {
            Node temp = this.Head;

            for(int i=0;i< index;i++)
            {
                temp = temp.Next;
            }

            return temp;
        }

        public int DeleteFromLast()
        {
            if(this.Size <= 1)
            {
                return DeleteAtFirst();
            }

            Node secoundLast = GetNode(this.Size - 2);
            int val = this.Tail.Value;
            this.Tail = secoundLast;
            this.Tail.Next = null;


            return val;
        }

        public int DeleteAtParticularLoacation(int index)
        {
            if(index == 0)
                return DeleteAtFirst();

            if(index == this.Size -1)
                return DeleteFromLast();

            Node prev = GetNode(index - 1);
             int val = prev.Next.Value;
            prev.Next = prev.Next.Next;


            return val;
        }

    }
}
