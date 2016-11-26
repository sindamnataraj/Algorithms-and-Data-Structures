using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    public class MyBinaryTree
    {
        public class MyBinaryTreeNode
        {
            public int n;
            public MyBinaryTreeNode left;
            public MyBinaryTreeNode right;
        }

        private MyBinaryTreeNode Head;

        public MyBinaryTree() {
            Head = null;
        }

        /// <summary>
        /// Insert as binary search tree
        /// </summary>
        public void Insert(int n)
        {
            Head = Insert(Head, n);
        }

        private MyBinaryTreeNode Insert(MyBinaryTreeNode Node, int n)
        {
            if (Node == null)
            {
                MyBinaryTreeNode temp = new MyBinaryTreeNode();
                temp.n = n;
                Node = temp;

            }
            else if (n < Node.n)
            {
                Node.left = Insert(Node.left, n);
            }
            else
            {
                Node.right = Insert(Node.right, n);
            }
            return Node;
        }

        #region Recursive Traversal
        public void Inorder()
        {
            Inorder(Head);
            Console.WriteLine();
        }

        private void Inorder(MyBinaryTreeNode Node)
        {
            if (Node != null)
            {
                Inorder(Node.left);
                Console.Write("{0} ", Node.n);
                Inorder(Node.right);
            }

        }

        public void PreOrder()
        {
            PreOrder(Head);
            Console.WriteLine();
        }

        private void PreOrder(MyBinaryTreeNode Node)
        {
            if (Node != null)
            {
                Console.Write("{0} ", Node.n);
                PreOrder(Node.left);
                PreOrder(Node.right);
            }
        }

        public void PostOrder()
        {
            PostOrder(Head);
            Console.WriteLine();
        }

        private void PostOrder(MyBinaryTreeNode Node)
        {
            if (Node != null)
            {
                PostOrder(Node.left);
                PostOrder(Node.right);
                Console.Write("{0} ", Node.n);
            }
        }
        #endregion

        #region Non Recursive Traversal
        public void PreOrder_NonRecursive()
        {
            PreOrder_NonRecursive(Head);
        }

        private void PreOrder_NonRecursive(MyBinaryTreeNode Node)
        {

            Stack<MyBinaryTreeNode> s = new Stack<MyBinaryTreeNode>();

            while (Node != null || s.Count > 0)
            {
                while (Node != null)
                {
                    Console.Write("{0} ", Node.n);
                    s.Push(Node);
                    Node = Node.left;
                }

                MyBinaryTreeNode Temp = s.Pop();
                Node = Temp.right;
            }

        }


        #endregion

        #region Binary Tree Problems
        public int MaximumDepth()
        {
            return MaximumDepth(Head);
        }

        /// <summary>
        /// Best Case: Balanced Tree : T(n) = 2T(n/2) + O(1) : O(n)
        /// Worst Case: Unbalanced list : T(n) = T(n-1)+O(1) : O(n)        
        /// </summary>
        /// <param name="Node"></param>
        /// <returns></returns>
        private int MaximumDepth(MyBinaryTreeNode Node)
        {
            if (Node == null) return 0;
            return Math.Max(MaximumDepth(Node.left), MaximumDepth(Node.right)) + 1;
        }

        public void LevelOrderTraversal()
        {
            LevelOrderTraversal(Head);
        }

        /// <summary>
        /// Non Recursive Level Order Traversal
        /// Best Case : Balanced Tree : O(n)
        /// Worst Case: Skewed Tree : O(n)
        /// </summary>
        /// <param name="Node"></param>
        private void LevelOrderTraversal(MyBinaryTreeNode Node)
        {
            if (Node == null) return;

            Queue<MyBinaryTreeNode> q = new Queue<MyBinaryTreeNode>();
            q.Enqueue(Node);
            q.Enqueue(null);
            while (q.Count > 0)
            {
                MyBinaryTreeNode temp = q.Dequeue();

                if (temp != null)
                {
                    Console.Write("{0} ", temp.n);
                    if (temp.left != null) q.Enqueue(temp.left);
                    if (temp.right != null) q.Enqueue(temp.right);
                }
                else
                {
                    if (q.Count != 0)
                    {
                        q.Enqueue(null);
                        Console.WriteLine();
                    }
                }

            }
        }


        public int LevelWithMaxSum()
        {
            return LevelWithMaxSum(Head);
        }

        /// <summary>
        /// COmplexity - Same as level order - O(n) in best and worst
        /// </summary>
        /// <param name="Node"></param>
        /// <returns></returns>
        private int LevelWithMaxSum(MyBinaryTreeNode Node)
        {
            if (Node == null) return -1;
            Queue<MyBinaryTreeNode> q = new Queue<MyBinaryTreeNode>();
            q.Enqueue(Node);
            q.Enqueue(null);
            int currentLevelSum = 0;
            int currentLevel = 0;
            int MaxSum = 0;
            int MaxLevel = -1;

            while (q.Count > 0)
            {
                MyBinaryTreeNode temp = q.Dequeue();
                if (temp != null)
                {
                    currentLevelSum = currentLevelSum + temp.n;
                    if (temp.left != null) q.Enqueue(temp.left);
                    if (temp.right != null) q.Enqueue(temp.right);

                }
                else
                {
                    if (currentLevelSum > MaxSum)
                    {
                        MaxSum = currentLevelSum;
                        MaxLevel = currentLevel;
                    }
                    if (q.Count != 0) {
                        q.Enqueue(null); currentLevel++; currentLevelSum = 0;
                    }
                }
            }

            return MaxLevel + 1;

        }

        public void ReverseLevelOrder()
        {
            ReverseLevelOrder(Head);
        }

        //Best O(n)
        //Worst O(n)
        private void ReverseLevelOrder(MyBinaryTreeNode Node)
        {
            if (Node == null) return;

            Queue<MyBinaryTreeNode> q = new Queue<MyBinaryTreeNode>();
            Stack<MyBinaryTreeNode> s = new Stack<MyBinaryTreeNode>();
            s.Push(null);

            q.Enqueue(Node);
            q.Enqueue(null);

            while (q.Count > 0)
            {
                MyBinaryTreeNode temp = q.Dequeue();
                if (temp != null)
                {
                    s.Push(temp);
                    if (temp.left != null) q.Enqueue(temp.left);
                    if (temp.right != null) q.Enqueue(temp.right);
                }
                else
                {
                    if (q.Count != 0)
                    { q.Enqueue(null); s.Push(null); }

                }
            }

            while (s.Count > 0)
            {

                MyBinaryTreeNode temp1 = s.Pop();
                if (temp1 == null)
                {
                    Console.WriteLine();
                }
                else {
                    Console.Write("{0} ", temp1.n);
                }
            }
        }

        private void ZigZagTraversal(MyBinaryTreeNode Node)
        {



        }

        public int FullNodes()
        {
            return FullNodes(Head);
        }

        //best - balanced tree - O(n) - T(n)=2T(n/2)+O(1)
        //worst - skewed tree - O(n) - T(n) = T(n-1)+O(1)
        private int FullNodes(MyBinaryTreeNode Node)
        {
            if (Node == null) return 0;
            if (Node.left != null && Node.right != null) return FullNodes(Node.left) + FullNodes(Node.right) + 1;
            else return FullNodes(Node.left) + FullNodes(Node.right);
        }

        public int HalfNodes()
        {
            return HalfNodes(Head);
        }

        private int HalfNodes(MyBinaryTreeNode Node)
        {
            if (Node == null) return 0;
            if ((Node.left != null && Node.right == null) || (Node.left == null && Node.right != null))
            {
                return HalfNodes(Node.right) + HalfNodes(Node.left) + 1;
            }
            return HalfNodes(Node.right) + HalfNodes(Node.left);
        }

        public int Height()
        {
            return Height(Head);
        }

        private int Height(MyBinaryTreeNode Node)
        {
            if (Node == null) return 0;
            return Math.Max(Height(Node.left), Height(Node.right)) + 1;
        }

        public void PrintAllPathsToLeaves()
        {
            PrintAllPathsToLeaves(Head, "");
        }

        //O(n)
        //O(n)
        private void PrintAllPathsToLeaves(MyBinaryTreeNode Node, string s)
        {
            if (Node == null) return;
            if (Node.left == null && Node.right == null)
            {
                Console.WriteLine("{0}", s + "->" + Node.n.ToString());
            }
            else
            {
                PrintAllPathsToLeaves(Node.left, s + "->" + Node.n.ToString());
                PrintAllPathsToLeaves(Node.right, s + "->" + Node.n.ToString());
            }
        }

        public void ZigZag()
        {
            ZigZag(Head);
        }

        private void ZigZag(MyBinaryTreeNode Node)
        {
            if (Node == null) return;

            Stack<MyBinaryTreeNode> Current = new Stack<MyBinaryTreeNode>();
            Stack<MyBinaryTreeNode> Next = new Stack<MyBinaryTreeNode>();

            Current.Push(Node);
            bool direction = true;
            while (Current.Count > 0)
            {
                MyBinaryTreeNode Temp = Current.Pop();
                Console.Write("{0} ", Temp.n);
                if (direction)
                {
                    if (Temp.left != null) Next.Push(Temp.left);
                    if (Temp.right != null) Next.Push(Temp.right);
                }
                else
                {
                    if (Temp.right != null) Next.Push(Temp.right);
                    if (Temp.left != null) Next.Push(Temp.left);
                }
                if (Current.Count == 0)
                {
                    Stack<MyBinaryTreeNode> tempStack = Current;
                    Current = Next;
                    Next = tempStack;
                    Console.WriteLine();
                    direction = !direction;
                }
            }
        }

        //Given a complete binary tree, count the number of nodes.
        public int CountNodes(MyBinaryTreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 1;
            int l = leftheight(root);
            int r = rightheight(root);
            if (l == r)
            {
                return ((int)Math.Pow(2, l)) - 1;
            }
            else
            {
                return CountNodes(root.left) + CountNodes(root.right) + 1;
            }
        }

        private int leftheight(MyBinaryTreeNode node)
        {
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.left;
            }
            return count;
        }

        private int rightheight(MyBinaryTreeNode node)
        {
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.right;
            }
            return count;
        }

        
        //https://www.careercup.com/question?id=5749533368647680
        public void PrintColumns()
        {
            SortedDictionary<int, List<int>> sd = new SortedDictionary<int, List<int>>();
            PrintInColumns(Head, ref sd, 0);

            foreach(int key in sd.Keys)
            {
                List<int> li = sd[key];
                foreach (int i in li)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        private void PrintInColumns(MyBinaryTreeNode Node, ref SortedDictionary<int, List<int>> sd, int verticalnum)
        {
            if (Node != null)
            {
                //process left
                PrintInColumns(Node.left, ref sd, verticalnum - 1);

                if (sd.ContainsKey(verticalnum))
                {
                    sd[verticalnum].Add(Node.n);
                }
                else
                {
                    sd.Add(verticalnum, new List<int>());
                    sd[verticalnum].Add(Node.n);
                }
                //process current
                PrintInColumns(Node.right, ref sd, verticalnum + 1);
                //process right
            }
        }

        //Max Path sum in binary tree , node values can be -ve too.
        //also path not necessariy to pass between the root.
        //very important
        //Leetcode in progress solution 
        //public long MaxPath(TreeNode root, ref long sendToParent)
        //{
        //    if (root == null)
        //    {
        //        sendToParent = int.MinValue;
        //        return int.MinValue;
        //    }
        //    if (root.left == null && root.right == null)
        //    {
        //        sendToParent = root.val;
        //        return root.val;
        //    }

        //    long leftP = new long();
        //    long rightP = new long();

        //    int leftsum = MaxPath(root.left, ref leftP);
        //    int rightsum = MaxPath(root.right, ref rightP);

        //    sendToParent = Math.Max(leftP + root.val, rightP + root.val);

        //    long one = (leftP + root.val);
        //    long two = Math.Max(one, rightP + root.val);
        //    long three = Math.Max(two, root.val);
        //    long four = Math.Max(three, leftP + rightP + root.val);
        //    long five = Math.Max(four, leftP);
        //    long six = Math.Max(five, rightP);

        //    return Math.Max(six, Math.Max(leftsum, rightsum));
        //}
        

        
        #endregion


    }
}










