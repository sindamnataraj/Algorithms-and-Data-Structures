using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    public class BinrayTree2
    {
        public class TreeNode {
            public int n;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val)
            {
                n = val;
                left = null;
                right = null;
            }
        }
        
        private TreeNode Head;

        public BinrayTree2()
        {
            Head = null;
        }

        public void Insert(int n)
        {
           InsertBFS(ref Head, n);
        }
        private void InsertBFS(ref TreeNode Node, int n)
        {
            if (Node == null)
            {
                Node = new TreeNode(n);
                return;
            }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(Node);

            while (q.Count > 0)
            {
                TreeNode temp = q.Dequeue();

                if (temp.left == null)
                {
                    temp.left = new TreeNode(n);
                    return;
                }
                else if (temp.right == null)
                {
                    temp.right = new TreeNode(n);
                    return;
                }
                else
                {
                    q.Enqueue(temp.left);
                    q.Enqueue(temp.right);
                }

            }

          
        }

        public void Inorder()
        {
            Inorder_Recursive(Head);
            Console.WriteLine();
            Inorder_NonRecursive(Head);
        }
        private void Inorder_Recursive(TreeNode Node)
        {
            if (Node!=null)
            {
                Inorder_Recursive(Node.left);
                Console.Write("{0} ",Node.n);
                Inorder_Recursive(Node.right);
            }
        }
        private void Inorder_NonRecursive(TreeNode Node)
        {
            if (Node == null) return;

            Stack<TreeNode> s = new Stack<TreeNode>();

            while (s.Count > 0 || Node != null)
            {
                while (Node != null)
                {
                    s.Push(Node);
                    Node = Node.left;
                }

                if (s.Count > 0)
                {
                    Node = s.Pop();
                    Console.Write("{0} ",Node.n);
                    Node = Node.right;
                }
            }



        }

        public void PreOrder()
        {
            Console.WriteLine();
            Preorder_Recursive(Head);
            Console.WriteLine();
            Preorder_NonRecursive(Head);
        }
        private void Preorder_Recursive(TreeNode Node)
        {
            if (Node != null)
            {
                Console.Write("{0} ", Node.n);
                Preorder_Recursive(Node.left);
                Preorder_Recursive(Node.right);
            }
        }
        private void Preorder_NonRecursive(TreeNode Node)
        {
            if (Node == null) return;

            Stack<TreeNode> s = new Stack<TreeNode>();

            while (Node != null || s.Count > 0)
            {
                while (Node != null)
                {
                    Console.Write("{0} ",Node.n);
                    s.Push(Node);
                    Node = Node.left;
                }

                if (s.Count > 0)
                {
                    Node = s.Pop();
                    Node = Node.right;
                }
            }
            Console.WriteLine();
        }

        public void PostOrder()
        {
            Console.WriteLine();
            Console.WriteLine();
        }

        private void Postorder_Recursive(TreeNode Node)
        {
            if (Node != null)
            {
                Postorder_Recursive(Node.left);
                Postorder_Recursive(Node.right);
                Console.Write("{0} ", Node.n);

            }
        }
        private void PostOrder_NonRecursive(TreeNode Node)
        {
            if (Node == null) return;
            Stack<TreeNode> s = new Stack<TreeNode>();
            while (s.Count > 0 || Node != null)
            {
                while (Node != null)
                {
                    if (Node.right != null) s.Push(Node.right);
                    s.Push(Node);
                    Node = Node.left;
                }

                Node = s.Pop();
                if (s.Count>0 && Node.right == s.Peek())
                {
                    TreeNode temp = s.Pop();
                    s.Push(Node);
                    Node = temp;
                }
                else
                {
                    Console.Write("{0} ",Node.n);
                    Node = null;   
                }
                
            }
        }

        public void LevelOrder()
        {
            LevelOrder(Head);
            Console.WriteLine();
            LevelOrderFromBottom(Head);
        }
        private void LevelOrder(TreeNode Node)
        {
            if (Node == null) return;

            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(null);
            q.Enqueue(Node);

            while (q.Count > 0)
            {
                TreeNode currentNode = q.Dequeue();
                if (currentNode == null)
                {
                    Console.WriteLine();
                    if (q.Count > 0)
                    {
                        q.Enqueue(null);
                    }
                }
                else
                {
                    Console.Write("{0} ",currentNode.n);
                    if (currentNode.left != null) q.Enqueue(currentNode.left);
                    if (currentNode.right != null) q.Enqueue(currentNode.right);
                }
            }

        }
        private void LevelOrderFromBottom(TreeNode Node)
        {
            if (Node == null) return;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(Node);
            q.Enqueue(null);
            Stack<TreeNode> s = new Stack<TreeNode>();
            while (q.Count > 0)
            {
                TreeNode curNode = q.Dequeue();
                if (curNode == null)
                {
                    s.Push(null);
                    if (q.Count > 0)
                    {
                        q.Enqueue(null);
                    }
                }
                else
                {
                    s.Push(curNode);
                    if (curNode.left != null) q.Enqueue(curNode.left);
                    if (curNode.right != null) q.Enqueue(curNode.right);
                }
            }

            while (s.Count > 0)
            {
                TreeNode node = s.Pop();
                if (node == null)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("{0} ",node.n);
                }
            }
        }
        
        //O(n)
        private bool SearchBinaryTree(TreeNode Node,int n)
        {
            if (Node == null) return false;
            if (Node.n == n) return true;
            else 
            {
                return SearchBinaryTree(Node.left, n) || SearchBinaryTree(Node.right, n) ;
            }
        }

        private int MaxNumberInBinaryTree(TreeNode Node)
        {
            if (Node == null) return int.MinValue;
            int left = MaxNumberInBinaryTree(Node.left);
            int right = MaxNumberInBinaryTree(Node.right);
            return Math.Max(Node.n, Math.Max(left, right));
        }

        private int MaxDepth(TreeNode Node)
        {
            if (Node == null) return 0;
            return Math.Max(MaxDepth(Node.left), MaxDepth(Node.right)) + 1;
        }

        public void DeepestNode()
        {
            int depth = new int();
            TreeNode node = DeepestNode(Head,ref depth);
            if (node != null)
            {
                Console.WriteLine(node.n);
            }
        }
        private TreeNode DeepestNode(TreeNode Node, ref int height)
        {
            if (Node == null)
            {
                height = 0;
                return null;
            }

            int lHeight = new int();
            int rHeight = new int();
            TreeNode left = DeepestNode(Node.left,ref lHeight);
            TreeNode right = DeepestNode(Node.right,ref rHeight);
            if (left == null && right == null)
            {
                height = 1;
                return Node;
            }

            if (lHeight > rHeight)
            {
                height = lHeight + 1;
                return left;
            }
            else
            {
                height = rHeight + 1;
                return right;
            }

        }

        private int Height(TreeNode Node)
        {
            if (Node == null) return 0;
            return Math.Max(Height(Node.left), Height(Node.right)) + 1;
        }

        private int FullNodes(TreeNode Node)
        {
            if (Node == null) return 0;
            if (Node.left == null && Node.right == null) return 1;
            return FullNodes(Node.left) + FullNodes(Node.right);
        }

        private int HalfNodes(TreeNode Node)
        {
            if (Node == null) return 0;
            int left = HalfNodes(Node.left);
            int right = HalfNodes(Node.right);
            if ((Node.left == null && Node.right != null) || (Node.left != null && Node.right == null))
            {
                return left + right + 1;
            }
            return left + right;
        }

        private int Leaves(TreeNode Node)
        {
            if (Node == null) return 0;
            if (Node.left == null && Node.right == null) return 1;
            return Leaves(Node.left) + Leaves(Node.right);
        }

        //Diameter or width of binary tree
        //is the number of nodes on the longest path between two leaves in the tree
        public void Diameter()
        {
            int d = new int();
            Console.WriteLine(Diameter(Head,ref d));
        }
        private int Diameter(TreeNode Node,ref int Depth)
        {
            if (Node == null)
            {
                Depth = 0;
                return 0;
            }

            int leftDepth = new int();
            int rightDepth = new int();

            int leftDia = Diameter(Node.left, ref leftDepth);
            int rightDia = Diameter(Node.right, ref rightDepth);

            int d = leftDepth + rightDepth + 1;
            Depth = Math.Max(leftDepth, rightDepth) + 1;

            return Math.Max(d, Math.Max(leftDia, rightDia));
        }

        public void PrintAllPaths()
        {
            string s = "";
          
            PrintAllPathsToLeaves(Head,s);
        }
        private void PrintAllPathsToLeaves(TreeNode Node, string s)
        {
            if (Node == null) return;
            if (Node.left == null && Node.right == null)
            {
                Console.WriteLine("{0}{1}",s,Node.n);
            }
            else
            {
                StringBuilder sb = new StringBuilder(s);
                sb.Append(Node.n);
                if (Node.left != null)
                {
                    PrintAllPathsToLeaves(Node.left, sb.ToString());
                }
                if (Node.right != null)
                {
                    PrintAllPathsToLeaves(Node.right, sb.ToString());
                }
            }

        }

        private TreeNode LCA(TreeNode Node1, TreeNode Node2,TreeNode Root)
        {
            if (Root == null || Node1 == null || Node2 == null) return null;
            if (Root == Node1 || Root == Node2) return Root;
            TreeNode left = LCA(Node1, Node2, Root.left);
            TreeNode right = LCA(Node1, Node2, Root.right);
            if (left != null && right != null)
            {
                return Root;
            }
            if (left != null) return left;
            return right;
        }
        
        public void BuildTreeFrom_InorderAndPreOrder(int[] InOrder, int[] PreOrder)
        {
            int preOrderIndex = new int();
            TreeNode newTree = BuildTree(InOrder, 0, InOrder.Length - 1, PreOrder, ref preOrderIndex, PreOrder.Length - 1);

            Inorder_Recursive(newTree);
        }
        //Build tree if Inorder and PreOrder are already given
        private TreeNode BuildTree(int[] InOrder, int InLow, int InHigh, int[] PreOrder, ref int PreLow, int PreHigh)
        {
            if (PreLow > PreHigh) return null;
            TreeNode newNode = new TreeNode(PreOrder[PreLow]);
            if (InLow == InHigh) { PreLow++; return newNode; }
            int InOrderIndex = SearchInArray(InOrder, InLow, InHigh, PreOrder[PreLow]);
            if (InOrderIndex != -1)
            {
                PreLow++;
                newNode.left = BuildTree(InOrder, InLow, InOrderIndex - 1, PreOrder, ref PreLow, PreHigh);
                newNode.right = BuildTree(InOrder, InOrderIndex+1, InHigh, PreOrder, ref PreLow, PreHigh);
            }
            return newNode;
        }
        private int SearchInArray(int[] A, int low, int high,int n)
        {
            for (int i = low; i <= high; i++)
            {
                if (A[i] == n) return i;
            }
            return -1;
        }

        //https://www.careercup.com/question?id=5749533368647680
        //very imp ***
        public void PrintColumns()
        {
            SortedDictionary<int, List<int>> sd = new SortedDictionary<int, List<int>>();
            PrintInColumns(Head, ref sd, 0);

            foreach (int key in sd.Keys)
            {
                List<int> li = sd[key];
                foreach (int i in li)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        private void PrintInColumns(TreeNode Node, ref SortedDictionary<int, List<int>> sd, int verticalnum)
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

        //very imp ***
        public void GetMirror()
        {
            TreeNode newHead = GetMirror(Head);
            Inorder_Recursive(newHead);
        }
        private TreeNode GetMirror(TreeNode Node)
        {
            if (Node == null) return null;
            TreeNode t = new TreeNode(Node.n);
            
            t.right = GetMirror(Node.left);
            t.left = GetMirror(Node.right);

            return t;
        }

        #region Path based problems
        //Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that 
        //adding up all the values along the path equals the given sum
        public bool HasPathSum(TreeNode root, int sum)
        {
            return HasPath(root, sum, 0);
        }
        private bool HasPath(TreeNode Node, int sum, int curSum)
        {
            if (Node == null) return false;
            curSum += Node.n;
            if (Node.left == null && Node.right == null)
            {
                if (curSum == sum) return true;
                return false;
            }
            return HasPath(Node.left, sum, curSum) || HasPath(Node.right, sum, curSum);

        }

        //Given a binary tree and a sum, find all root-to-leaf paths where each path's 
        //sum equals the given sum.
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            List<IList<int>> final = new List<IList<int>>();
            Path(root, new List<int>(), 0, sum, ref final);
            return (IList<IList<int>>)final;
        }
        public void Path(TreeNode Node, List<int> curPath, int curSum, int sum, ref List<IList<int>> final)
        {
            if (Node == null) return;

            curSum += Node.n;
            curPath.Add(Node.n);

            if (Node.left == null && Node.right == null)
            {
                if (curSum == sum)
                {
                    final.Add((IList<int>)curPath);
                }
                return;
            }

            Path(Node.left, new List<int>(curPath), curSum, sum, ref final);
            Path(Node.right, new List<int>(curPath), curSum, sum, ref final);
        }

        //Check if given two nodes are on same path in a tree
        public bool AreOnSamePath(int n1, int n2)
        {
            return AreOnSamePath(Head, n1, n2);
        }
        private bool AreOnSamePath(TreeNode Node, int n1, int n2)
        {
            if (Node == null) return false;
            if (Node.n == n1 || Node.n == n2) return true;
            bool left = AreOnSamePath(Node.left, n1, n2);
            bool right = AreOnSamePath(Node.right, n1, n2);
            if (left == true && right == true) return false;
            if (left == true) return left;
            return false;
        }
        
        #endregion

        #region PurePractice
        public void practice_level()
        {
            practice_LevelOrder(Head);
        }
        private void practice_LevelOrder(TreeNode Node)
        {
            if (Node == null) return;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(Node);
            q.Enqueue(null);

            while (q.Count > 0)
            {
                TreeNode temp = q.Dequeue();
                if (temp == null)
                {
                    Console.WriteLine();
                    if (q.Count == 0) return;
                    q.Enqueue(null);
                }
                else
                {
                    if (temp.left != null) q.Enqueue(temp.left);
                    if (temp.right != null) q.Enqueue(temp.right);
                    Console.Write("{0} ",temp.n);
                }
            }
        }


        private void p_inorder(TreeNode Node)
        {
            if (Node != null)
            {
                p_inorder(Node.left);
                Console.Write(Node.n);
                p_inorder(Node.right);
            }
        }
        private void p_inorder_nonReursive(TreeNode Node)
        {
            if (Node == null) return;

            Stack<TreeNode> s = new Stack<TreeNode>();

            while (s.Count > 0 || Node != null)
            {
                while (Node != null)
                {
                    s.Push(Node);
                    Node = Node.left;
                }

                //Console.WriteLine(s.Pop());
                if (s.Count > 0)
                {
                    Node = s.Pop();
                    Console.WriteLine(Node.n);
                    Node = Node.right;
                }
            }

        }
        private void p_preorder_nonrecur(TreeNode Node)
        {
            if (Node == null) return;

            Stack<TreeNode> s = new Stack<TreeNode>();

            while (s.Count > 0 || Node != null)
            {
                while (Node != null)
                {
                    Console.WriteLine(Node.n);
                    s.Push(Node);
                    Node = Node.left;
                }
              
                if (s.Count > 0)
                {
                    Node = s.Pop();
                    Node = Node.right;
                }
            }
        }
        private bool p_binarysearch(TreeNode Node,int k)
        {
            if (Node != null)
            {
                if (Node.n == k) return true;
                return p_binarysearch(Node.left, k) || p_binarysearch(Node.right, k);
            }

            return false;
        }

        private int p_diam(TreeNode Node,ref int height)
        {
            if (Node == null)
            {
                height = 0;
                return 0; 
            }

            int lefth = 0;
            int righth = 0;

            int leftDia = p_diam(Node.left, ref lefth);
            int rightDia = p_diam(Node.right, ref righth);

            height = Math.Max(lefth, righth);

            int other = lefth + righth + 1;

            return Math.Max(Math.Max(leftDia, rightDia), other);
        }


        private TreeNode p_CovertTOMirro(TreeNode Node)
        {
            if (Node == null) return null;
            TreeNode temp = new TreeNode(Node.n);
            temp.left = p_CovertTOMirro(Node.right);
            temp.right = p_CovertTOMirro(Node.left);
            return temp;

        }

        private bool IsBalanaced(TreeNode Node,ref int height)
        {
            if (Node == null )
            {
                height = 0;
                return true;
            }

            int leftH = 0;
            int rightH = 0;

            if (IsBalanaced(Node.left, ref leftH) == false) return false;
            if (IsBalanaced(Node.right, ref rightH) == false) return false;

            if (Math.Abs(leftH - rightH) > 1) return false;
            height = Math.Max(leftH, rightH) + 1;
            return true;
        }

























        #endregion
    }
}
