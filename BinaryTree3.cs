using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    public class BinaryNode3 {
        public int n;
        public BinaryNode3 left;
        public BinaryNode3 right;

        public BinaryNode3(int val)
        {
            n = val;
            left = null;
            right = null;
        }
    }

    public class BinaryTree3
    {
        private BinaryNode3 head;

        //Constructor
        public BinaryTree3()
        {
            head = null;
        }

        //Insert in Binary Search Tree
        public void Insert(int n)
        {
            head = InsertInt(head, n);
        }
        private BinaryNode3 InsertInt(BinaryNode3 Node, int n)
        {
            if (Node == null)
            {
                Node = new BinaryNode3(n);
                return Node;
            }

            if (n < Node.n)
            {
                Node.left = InsertInt(Node.left, n);
            }
            else
            {
                Node.right = InsertInt(Node.right, n);
            }
            return Node;
        }

        public bool Search(int n)
        {
            return Search(head, n);
        }
        private static bool Search(BinaryNode3 Node, int n)
        {
            if (Node == null) return false;
            if (Node.n == n) return true;
            if (n < Node.n) return Search(Node.left, n);
            return Search(Node.right, n);
        }


        public void Inorder()
        {
            InorderInt(head);
            Console.WriteLine();
            Inorder_NonRecur(head);
        }
        private static void InorderInt(BinaryNode3 Node)
        {
            if (Node != null)
            {
                InorderInt(Node.left);
                Console.Write("{0} ", Node.n);
                InorderInt(Node.right);
            }
        }
        private static void Inorder_NonRecur(BinaryNode3 Node)
        {
            if (Node == null) return;
            Stack<BinaryNode3> stk = new Stack<BinaryNode3>();

            while (stk.Count > 0 || Node != null)
            {
                while (Node != null)
                {
                    stk.Push(Node);
                    Node = Node.left;
                }

                if (stk.Count > 0)
                {
                    Node = stk.Pop();
                    Console.Write("{0} ", Node.n);
                    Node = Node.right;
                }
            }


        }


        public void PreOrder()
        {
            PreOrder(head);
            Console.WriteLine();
            PreOrder_NonRecur(head);
        }
        private static void PreOrder(BinaryNode3 Node)
        {
            if (Node != null)
            {
                Console.Write("{0} ", Node.n);
                PreOrder(Node.left);
                PreOrder(Node.right);
            }
        }
        private static void PreOrder_NonRecur(BinaryNode3 Node)
        {
            if (Node == null) return;
            Stack<BinaryNode3> stk = new Stack<BinaryNode3>();

            while (stk.Count > 0 || Node != null)
            {
                while (Node != null)
                {
                    Console.Write("{0} ", Node.n);
                    stk.Push(Node);
                    Node = Node.left;
                }

                if (stk.Count > 0)
                {
                    Node = stk.Pop();
                    Node = Node.right;
                }
            }
        }

        public void PostOrder()
        {
            PostOrder(head);
        }
        private static void PostOrder(BinaryNode3 Node)
        {
            if (Node != null)
            {
                PostOrder(Node.left);
                PostOrder(Node.right);
                Console.Write("{0} ", Node.n);
            }
        }

        //level Order
        public void levelOrder()
        {
            LevelOrder(head);
        }
        private static void LevelOrder(BinaryNode3 Node)
        {
            if (Node == null) return;
            Queue<BinaryNode3> q = new Queue<BinaryNode3>();
            q.Enqueue(Node);
            q.Enqueue(null);

            while (q.Count > 0)
            {
                BinaryNode3 temp = q.Dequeue();
                if (temp != null)
                {
                    if (temp.left != null) { q.Enqueue(temp.left); }
                    if (temp.right != null) { q.Enqueue(temp.right); }
                    Console.Write("{0} ", temp.n);
                }
                else
                {
                    if (q.Count == 0) return;
                    Console.WriteLine();
                    q.Enqueue(null);
                }

            }
        }

        //Max number in binary tree O(n)
        public int MaxBT()
        {
            return Max(head);
        }
        private static int Max(BinaryNode3 Node)
        {
            if (Node == null) return int.MinValue;
            int leftMax = Max(Node.left);
            int rightMax = Max(Node.right);
            return Math.Max(leftMax, Math.Max(rightMax, Node.n));
        }

        //Deepest node
        public void Deepest()
        {
            int dep = 0;
            BinaryNode3 Node = Deepest(head, ref dep);
            if (Node != null)
            {
                Console.WriteLine("{0} ", Node.n);
            }
        }
        private static BinaryNode3 Deepest(BinaryNode3 Node, ref int depth)
        {
            if (Node == null)
            {
                depth = 0;
                return null;
            }

            int leftDepth = new int();
            int rightDepth = new int();

            BinaryNode3 leftDeep = Deepest(Node.left, ref leftDepth);
            BinaryNode3 rightDeep = Deepest(Node.right, ref rightDepth);


            if (leftDeep == null && rightDeep == null)
            {
                depth = 1;
                return Node;
            }

            if (leftDepth >= rightDepth)
            {
                depth = leftDepth + 1;
                return leftDeep;
            }
            depth = rightDepth + 1;
            return rightDeep;
        }

        //full nodes
        private static int fullNodes(BinaryNode3 Node)
        {
            if (Node == null) return 0;
            int left = fullNodes(Node.left);
            int right = fullNodes(Node.right);

            if (Node.left != null && Node.right != null)
            {
                return left + right + 1;
            }

            return left + right;
        }

        //half nodes
        private static int halfNodes(BinaryNode3 Node)
        {
            if (Node == null) return 0;
            int left = halfNodes(Node.left);
            int right = halfNodes(Node.right);

            if ((Node.left == null && Node.right != null) || (Node.left != null && Node.right == null))
            {
                return left + right + 1;
            }

            return left + right;


        }

        //leaves
        private static int leaves(BinaryNode3 Node)
        {
            if (Node == null) return 0;
            if (Node.left == null && Node.right == null) return 1;
            return leaves(Node.left) + leaves(Node.right);
        }

        //diameter
        private static int Diameter(BinaryNode3 Node, ref int height)
        {
            if (Node == null)
            {
                height = 0;
                return 0;
            }

            int leftheight = 0;
            int rightheight = 0;
            int leftD = Diameter(Node.left, ref leftheight);
            int rightD = Diameter(Node.right, ref rightheight);
            height = Math.Max(leftheight, rightheight) + 1;
            int tempD = leftheight + rightheight + 1;
            return Math.Max(tempD, Math.Max(leftD, rightD));


        }

        public void PrintAllPaths()
        {
            PrintAllPaths(head, "");
        }
        private static void PrintAllPaths(BinaryNode3 Node, string s)
        {
            if (Node == null) return;
            string s2 = s + "->" + Node.n;
            if (Node.left == null && Node.right == null)
            {
                Console.WriteLine(s2);
                return;
            }
            PrintAllPaths(Node.left, s2);
            PrintAllPaths(Node.right, s2);
        }
            


    }
}
