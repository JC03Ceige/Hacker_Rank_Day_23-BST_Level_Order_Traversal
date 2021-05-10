using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank_Day_23_BST_Level_Order_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static Queue<Node> nodeQ = new Queue<Node>();
        static void levelOrder(Node root)
        {
            //Write your code here
            nodeQ.Enqueue(root);
            while (nodeQ.Count > 0)
            {
                var curNode = nodeQ.Dequeue();
                Console.Write(curNode.data + " ");

                if (curNode.left != null)
                    nodeQ.Enqueue(curNode.left);

                if (curNode.right != null)
                    nodeQ.Enqueue(curNode.right);
            }

            Console.ReadKey();
        }       
    }

    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
