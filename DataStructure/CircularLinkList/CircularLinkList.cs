namespace DataStructure.CircularLinkList
{
    public class Node
    {
        public int Val { get; set; }
        public Node Next { get; set; }
        public Node(int val) 
        {
            this.Val = val;
        }
    }

    public class CircularLinkList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public CircularLinkList()
        {
            this.Head = null;
            this.Tail = null;
        }

        public void InsertIntoList(int val)
        {
            Node node = new Node(val);
            if(this.Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            Tail.Next = node;
            node.Next = Head;
            Tail = node;


        }

        public void Display()
        {
            if(this.Head == null)
            {
                Console.WriteLine("Nothing in the list");
                return;
            }

            Node temp = this.Head;

            do
            {
                Console.WriteLine($"{temp.Val} -->");
                temp = temp.Next;
            } while(temp != this.Head);

            Console.WriteLine("Head");

        }

        public void DeleteFromList(int val)
        {
            Node node = Head;
            if(this.Head == null)
              return;

            if(node.Val == val)
            {
                this.Head = Head.Next;
                Tail.Next = Head;
            }

            do
            {
                Node n = node.Next;
                if (n.Val == val)
                {
                    node.Next = n.Next;
                    break;
                }
                node = node.Next;

            }
            while (node != Head);

        }

    }
}
