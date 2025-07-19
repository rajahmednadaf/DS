using System.Reflection.Metadata.Ecma335;

namespace DataStructure.Trees
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data) 
        { 
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
    public class BinaryTree
    {
        public static int idx=-1;

        public Node BuildTree(int[] nodes)
        {
            idx++;

            if (nodes[idx] == -1)
            {
                return null;
            }

            Node node = new Node(nodes[idx]);
            node.left = BuildTree(nodes);
            node.right = BuildTree(nodes);

            return node;
        }

        public void PreOrder(Node root)
        {
            if(root == null)
            {  return; }

            Console.WriteLine(root.data);
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public void InOrder(Node root)
        {
            if (root == null)
            { return; }

            
            InOrder(root.left);
            Console.WriteLine(root.data);
            InOrder(root.right);
        }

        public void PostOrder(Node root)
        {
            if (root == null)
            { return; }


            PostOrder(root.left);
            PostOrder(root.right);
            Console.WriteLine(root.data);
        }

        //level order traversal

        public void LevelOrderTraversal(Node root)
        {
            if (root == null) 
            {
                return;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            queue.Enqueue(null);

            while (queue.Any())
            {
               var Currnode = queue.Dequeue();

                 if(Currnode == null)
                {
                    Console.WriteLine();

                    if (queue.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        queue.Enqueue(null);
                    }

                }
                else
                {
                    Console.Write(Currnode.data+ " ");
                    if(Currnode.left != null)
                    {
                        queue.Enqueue(Currnode.left);
                    }
                    if(Currnode.right != null) 
                    {
                        queue.Enqueue(Currnode.right);
                    }
                }
            }

        }

        //count of the nodes in the tree
        public int CountTheNodesInTree(Node root)
        {
            if(root == null)
            {
                return 0;
            }

            int countOfLeft = CountTheNodesInTree(root.left);
            int CountOfRight = CountTheNodesInTree(root.right);

            return countOfLeft + CountOfRight + 1;
        }

        //count sum of the nodes in the tree
        public int CountSumOfTheNodesInTree(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int countOfLeft = CountSumOfTheNodesInTree(root.left);
            int CountOfRight = CountSumOfTheNodesInTree(root.right);

            return countOfLeft + CountOfRight + root.data;
        }

        //Height of the tree
        public int HeightOfTheTree(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int countOfLeft = HeightOfTheTree(root.left);
            int CountOfRight = HeightOfTheTree(root.right);

            return Math.Max(countOfLeft, CountOfRight) +1;
        }

    }
}
