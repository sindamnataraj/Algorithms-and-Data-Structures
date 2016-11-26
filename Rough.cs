using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    class Rough
    {

        //permutations
        public static void Permute(int[] A, int p, int q)
        {
            if (p == q)
            {
                PrintArray(A);
            }
            else
            {
                for (int i = p; i <= q; i++)
                {
                    Swap1(ref A, p, i);
                    Permute(A, p + 1, q);
                    Swap1(ref A, p, i);
                }
            }

        }
        public static void PrintArray(int[] A)
        {
            foreach (int i in A)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();
        }
        public static void Swap1(ref int[] A, int p, int q)
        {
            int t = A[p];
            A[p] = A[q];
            A[q] = t;
        }


        public static void NQueen(int N)
        {
            int[,] B = new int[N, N];
            NQueen_Aux(N, 0, B);
        }
        public static void NQueen_Aux(int N, int y,int[,] B)
        {
            
            if (y == N)
            {
                Print2DArray(B);
                return;
            }

            for (int i = 0; i < N; i++)
            {
                if (IsSafe(B, i, y,N))
                {
                    B[i, y] = 1;
                    NQueen_Aux(N, y + 1, B);
                    B[i, y] = 0;
                }
            }

        }
        public static void Print2DArray(int[,] B)
        {
            int m = B.GetLength(0);
            int n = B.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", B[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static bool IsSafe(int[,] B, int x, int y,int N)
        {
            int i = 0;
            int j = 0;
            for ( j = 0; j < y; j++)
            {
                if (B[x, j] == 1) return false;
            }

            for (i = 0, j = 0; i < x && j < y; i++, j++)
            {
                if (B[i, j] == 1) return false;
            }

            for (i = N - 1, j = 0; i > x && j  < y;i--,j++)
            {
                if (B[i, j] == 1) return false;
            }
            return true;
        }
             

        public static void PaintFill(ref int[,] Screen, int x, int y, int newColor)
        {
            int m = Screen.GetLength(0);
            int n = Screen.GetLength(1);
            int oldColor = Screen[x, y];
            PaintFill_Helper(ref Screen, x, y, newColor, m, n, oldColor);
               
        }
        public static void PaintFill_Helper(ref int[,] Screen, int x, int y, int newColor, int m, int n,int oldColor)
        {
            if (!IsValid(x, y, m, n)) return;
            if (Screen[x, y] != oldColor) return;
            Screen[x, y] = newColor;
            PaintFill_Helper(ref Screen, x-1, y, newColor, m, n, oldColor);
            PaintFill_Helper(ref Screen, x+1, y, newColor, m, n, oldColor);
            PaintFill_Helper(ref Screen, x, y-1, newColor, m, n, oldColor);
            PaintFill_Helper(ref Screen, x, y+1, newColor, m, n, oldColor);
        }
        public static bool IsValid(int x, int y, int m, int n)
        {
            if (x < 0 || x >= m) return false;
            if (y < 0 || y >= n) return false;
            return true;
        }

        //selection sort
        //O(n2)
        public static void SelectionSort(ref int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Swap(ref A, min, i);
                }
            }
        }
        public static void Swap(ref int[] A, int p, int q)
        {
            int temp = A[p];
            A[p] = A[q];
            A[q] = temp;
        }

        //Insertion Sort
        //O(n2)
        public static void InsertionSort(ref int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int k = A[i];
                int j = i - 1;

                while (j >= 0 && A[j] > k)
                {
                    A[j + 1] = A[j];
                    j--;
                }

                A[j + 1] = k;

            }
        }

        //bucket sort

        //Quick sort
        //T(n) = T(n/2) + 1
        public static void QuickSort(ref int[] A, int p, int q)
        {
            if (p < q)
            {
                int r = Partition(ref A, p, q);
                QuickSort(ref A, p, r - 1);
                QuickSort(ref A, r + 1, q);

            }
        }
        public static int Partition(ref int[] A, int p, int q)
        {
            int k = A[q];
            int i = p - 1;
            int j = p;

            while (j < q)
            {

                if (A[j] <= k)
                {
                    Swap(ref A, i + 1, j);
                    i++;
                }

                j++;
            }

            A[q] = A[i + 1];
            A[i + 1] = k;
            return i + 1;
        }

        //Merge Sort
        public static void MergeSort(ref int[] A, int p, int q)
        {
            if (p < q)
            {
                int r = p + (q - p) / 2;
                MergeSort(ref A, p, r);
                MergeSort(ref A, r + 1, q);
                Merge(ref A, p, r, q);
            }
        }
        public static void Merge(ref int[] A, int p, int r, int q)
        {
            int len1 = r - p + 1;
            int len2 = q - r;

            int[] left = new int[len1];
            int[] right = new int[len2];

            int i = 0;
            for (i = 0; i < len1; i++)
            {
                left[i] = A[p + i];
            }

            int j = 0;
            for (j = 0; j < len2; j++)
            {
                right[j] = A[r + 1 + j];
            }

            i = 0;
            j = 0;
            int k = p;

            while (i < len1 && j < len2)
            {
                if (left[i] <= right[j])
                {
                    A[k] = left[i];
                    i++;
                }
                else
                {
                    A[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < len1)
            {


                A[k] = left[i];
                i++;
                k++;

            }

            while (j < len2)
            {
                A[k] = right[j];
                j++;
                k++;
            }




        }

        //counting sort for numbers
        //Time = O(n+d)
        //Mem  = O(d)
        public static int[] CountingSort(int[] A)
        {

            int[] C = new int[10];

            for (int i = 0; i < A.Length; i++)
            {
                C[A[i]]++;
            }

            for (int j = 1; j < C.Length; j++)
            {
                C[j] = C[j] + C[j - 1];
            }

            int[] Result = new int[A.Length];

            for (int k = A.Length - 1; k >= 0; k--)
            {
                int newIndex = C[A[k]] - 1;
                Result[newIndex] = A[k];
                C[A[k]]--;
            }

            return Result;
        }

        //Radix sort
        //O(k(n+d))

        //Bucket sort
        //

        //Heap Sort

        //a + b = k

        //Binary Search
        public static bool BinarySearch(int[] A, int p, int q, int k)
        {
            if (p == q)
            {
                if (A[p] == k) return true;
                return false;
            }
            else if (p < q)
            {
                int mid = p + (q - p) / 2;
                if (A[mid] == k)
                {
                    return true;
                }
                else if (k < A[mid])
                {
                    return BinarySearch(A, p, mid - 1, k);
                }
                else
                {
                    return BinarySearch(A, mid + 1, q, k);
                }
            }
            return false;

        }

        //find missing number 1
        public static int FindMissingNum1(int[] A)
        {
            int n = A.Length + 1;

            int curSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                curSum += A[i];
            }

            int expectedSum = n * (n + 1) / 2;

            return expectedSum - curSum;
        }

        //find missing number 2
        public static int FindMissingNum2(int[] A)
        {
            int n = A.Length + 1;

            int allXor = 0;

            for (int i = 1; i <= n; i++)
            {
                allXor = allXor ^ i;
            }

            int curXor = 0;
            for (int i = 0; i < A.Length; i++)
            {
                curXor = curXor ^ A[i];
            }

            return curXor ^ allXor;
        }

        #region a + b = k
        //a + b = k
        //A is sorted
        //O(n log n) + O(n) /
        public static bool sumOfTwo(int[] A, int p, int q, int k)
        {
            while (p < q)
            {
                int sum = A[p] + A[q];
                if (sum == k)
                {
                    return true;
                }
                else if (sum < k)
                {
                    p++;
                }
                else
                {
                    q--;
                }

            }
            return false;
        }

        //hashing method
        //A not sorted 
        //O(n) / O(n)
        public static bool sumOfTwo1(int[] A, int p, int q, int k)
        {
            Dictionary<int, bool> hash = new Dictionary<int, bool>();

            for (int i = p; i <= q; i++)
            {
                int a = A[i];
                int b = k - a;
                if (hash.ContainsKey(b))
                {
                    return true;
                }
                else
                {
                    if (!hash.ContainsKey(a))
                    {
                        hash.Add(a, true);
                    }
                }

            }

            return false;
        }

        #endregion

        // a + b ~ k
        // A is sorted
        public static int sumClosestToK(int[] A, int p, int q, int k, int preSum)
        {
            if (p < q)
            {
                int sum = A[p] + A[q];
                if (sum == k)
                {
                    return sum;

                }
                else
                {
                    int curDiff = Math.Abs(sum - k);
                    int prevDiff = Math.Abs(preSum - k);

                    if (curDiff < prevDiff)
                    {
                        preSum = sum;
                    }
                    if (sum < k)
                    {
                        return sumClosestToK(A, p + 1, q, k, preSum);
                    }
                    else
                    {
                        return sumClosestToK(A, p, q - 1, k, preSum);
                    }

                }
            }

            return preSum;
        }

        //a + b + c ~ k
        //A is sorted
        public static int sumClosesToK3(int[] A, int p, int q, int k)
        {
            int prevDiff = int.MaxValue;
            int resultSum = 0;
            for (int i = p; i < q - 1; i++)
            {
                int a = A[i];
                int sum = sumClosestToK(A, i + 1, q, k - a, int.MaxValue);

                int curSum = sum + a;
                int curDiff = Math.Abs(curSum - k);

                if (curDiff < prevDiff)
                {
                    prevDiff = curDiff;
                    resultSum = sum;
                }

            }

            return resultSum;
        }

        //radix sort of numbers
        public static void RadixSort(ref int[] A,int digitCount)
        {
            for (int i = 1; i <= digitCount; i++)
            {
                CountingSort_Digit(ref A, i);
            }
            
        }
        private static void CountingSort_Digit(ref int[] A, int digit)
        {
            int[] C = new int[10];
            for (int i = 0; i < A.Length; i++)
            {
                int n = getIthDigit(A[i], digit);
                C[n]++;
            }

            for (int j = 1; j < C.Length; j++)
            {
                C[j] = C[j] + C[j - 1];
            }
            int[] output = new int[A.Length];
            for (int k = A.Length - 1; k >= 0; k--)
            {
                int num = A[k];
                int index = getIthDigit(num, digit);
                output[C[index] - 1] = A[k];
                C[index]--;
            }

            output.CopyTo(A, 0);
        }
        private static int getIthDigit(int n, int i)
        {
            int j = 1;
            int rem = 0;
            while (j <= i && n>=0)
            {
                 rem = n % 10;
                n = n - rem;
                n = n / 10;
                j++;
            }
            return rem;
        }
        
        #region stack_problems

        //valid parenthesis
        public static bool IsValidParenth(string s)
        {
            Stack<char> stack_of_lefts = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (IsLeft(s[i]))
                {
                    stack_of_lefts.Push(s[i]);
                }
                else
                {
                    if (stack_of_lefts.Count == 0) return false;
                    if (AreMatchingPair(stack_of_lefts.Peek(), s[i]))
                    {
                        stack_of_lefts.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (stack_of_lefts.Count == 0) return true;
            return false;
            
        }
        public static bool IsLeft(char c)
        {
            if (c == '(' || c == '[' || c == '{') return true;
            return false;
        }
        public static bool AreMatchingPair(char left, char right)
        {
            //string c = "123";
            //int n = int.Parse(c);
            if (left == '(' && right == ')') return true;
            if (left == '[' && right == ']') return true;
            if (left == '{' && right == '}') return true;
            return false;

        }

        //balancing symbols
        //(A+B) + (C-D)

        //infix to postfix
        //A+B = AB+
        //only for capital lettes
        public static string InFix2PostFix(string s)
        {
            StringBuilder res = new StringBuilder();
            Stack<char> stk_of_symbols = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (IsCapitalLetter(c))
                {
                    //just add to the result
                    res.AppendFormat("{0}", c);
                }
                else if (IsSymbol(c) || c == '(')
                {
                    while (stk_of_symbols.Count > 0 && (PriorityLevel(stk_of_symbols.Peek()) > PriorityLevel(c)))
                    {
                        res.AppendFormat("{0}", stk_of_symbols.Pop());

                    }
                    stk_of_symbols.Push(c);
                }
                else {
                    //is a ( bracket ...might be left or right

                    while (stk_of_symbols.Count > 0 && stk_of_symbols.Peek() != '(')
                    {
                        res.AppendFormat("{0}", stk_of_symbols.Pop());
                    }
                    stk_of_symbols.Pop();
                }
            }

            return res.ToString();
        }
        public static int PriorityLevel(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;

                case '(':
                case ')':
                    return 3;

                default:
                    return 0;
            }
        }
        public static bool IsCapitalLetter(char c)
        {
            int asci = (int)c;
            if (asci >= 65 && asci <= 90) return true;
            return false;

        }
        public static bool IsSymbol(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/') return true;
            return false;
        }

        //evaluatte post fix with stack 123*+5-

        //evaluate infix using two stacks but one pass

        //remove k digits such that resulting number is smaller
        public static string RemoveKDigits(string s,int k)
        {
            if (s.Length == 0) return "0";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}",s);
            for (int j = 0; j < k; j++)
            {
                int i = 0;
                while (i < sb.Length && sb[i]<=sb[i+1])
                {
                    i++;
                }
                sb.Remove(i, 1);
            }
            
            while (sb.Length>0 && sb[0]=='0')
            {
                sb.Remove(0, 1);
            }

            if (sb.Length == 0) return "0";
            return sb.ToString();

        }

        //321. Create Maximum Number

        #endregion

        #region Interval_Range_Problems

        public class Range {
            public int start;
            public int end;
            public Range(int x, int y)
            {
                start = x;
                end = y;
            }
        }

        //sort based on start times
        //T(n) = T(n/2) + O(n)
        public static void Merge_Sort_Intervals(ref List<Range> L,int p,int q)
        {
            if (p < q)
            {
                int mid = p + (q - p) / 2;
                Merge_Sort_Intervals(ref L, p, mid);
                Merge_Sort_Intervals(ref L, mid + 1, q);
                Merge_Intervals(ref L, p, mid, q);
            }
        }
        public static void Merge_Intervals(ref List<Range> L, int p, int mid, int q)
        {
            int len1 = mid - p + 1;
            int len2 = q - mid;
            int i = 0;
            int j = 0;
            List<Range> left = new List<Range>();
            for (i = p; i <= mid; i++)
            {
                left.Add(L[i]);
            }

            List<Range> right = new List<Range>();
            for (j = mid + 1; j <= q; j++)
            {
                right.Add(L[j]);
            }

            i = 0;
            j = 0;
            int k = p;

            while (i < len1 && j < len2)
            {
                if (left[i].start <= right[j].start)
                {
                    L[k] = left[i];
                    i++;
                    k++;
                }
                else
                {
                    L[k] = right[j];
                    j++;
                    k++;
                }
            }


            while (i < len1)
            {
                    L[k] = left[i];
                    i++;
                    k++;
            }

            while (j < len2)
            {
                    L[k] = right[j];
                    j++;
                    k++;
            }

        }
        public static void Print_Ranges_List(List<Range> L)
        {
            foreach (Range r in L)
            {
                Console.WriteLine("[{0},{1}]",r.start,r.end);
            }
            Console.WriteLine();
        }

        //given sorted list of intervals, merge the overlapping ones
        public static void Merge_Overlappping_Intervals(List<Range> L)
        {
            List<Range> result = new List<Range>();
            if (L.Count == 0) return;

            result.Add(L[0]);
            int i = 1;

            while (i < L.Count)
            {
                Range prev = result[result.Count - 1];
                Range current = L[i];

                if (prev.end >= current.start)
                {
                    result[result.Count - 1] = Merge_Two_Intervals(prev, current);
                    i++;
                }
                else
                {
                    result.Add(current);
                    i++;
                }
            }

            Print_Ranges_List(result);
        }
        public static bool AreOverlapping(Range A, Range B)
        {
            if (A.end < B.start) return false;
            return true;
        }
        public static Range Merge_Two_Intervals(Range A, Range B)
        {
            int left = Math.Min(A.start, B.start);
            int right = Math.Max(A.end, B.end);
            return new Range(left, right);
        }

        //insert interval;
        
        //given list of meetings , can a person attend all of them


        #endregion

    }

    public class Heap
    {

        private int[] A;
        private int heapLen;

        public Heap(int[] Input)
        {
            A = new int[Input.Length];
            Array.Copy(Input, A, Input.Length);
            BuildMaxHeap(ref A, ref heapLen);
        }

        public void HeapSort()
        {
            for (int i = A.Length - 1; i > 0; i--)
            {
                swap(ref A, 0, i);
                heapLen--;
                Maxheapify(ref A, 0, heapLen);
            }
            PrintArray(A);
        }
        private static void PrintArray(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            Console.WriteLine();
        }

        private static void BuildMaxHeap(ref int[] A, ref int heapLen)
        {
            heapLen = A.Length - 1;
            int lastParent = A.Length / 2 - 1;
            int firstParent = 0;

            for (int i = lastParent; i >= firstParent; i--)
            {
                Maxheapify(ref A, i, heapLen);
            }
        }
        private static void Maxheapify(ref int[] A, int i, int heapLen)
        {
            int left = Left(i);
            int right = Right(i);

            int max = i;
            if (left <= heapLen && A[left] > A[max])
            {
                max = left;
            }

            if (right <= heapLen && A[right] > A[max])
            {
                max = right;
            }

            if (max != i)
            {
                swap(ref A, i, max);
                Maxheapify(ref A, max, heapLen);
            }
        }
        private static void swap(ref int[] A, int p, int q)
        {
            int temp = A[p];
            A[p] = A[q];
            A[q] = temp;
        }

        private static int Parent(int i)
        {
            return (i - 1) / 2;
        }
        private static int Left(int i)
        {
            return 2 * i + 1;
        }
        private static int Right(int i)
        {
            return 2 * i + 2;
        }
    }

    public class LinkedList
    {

        public class LinkedListNode
        {
            public int n;
            public LinkedListNode next;
            public LinkedListNode(int n)
            {
                this.n = n;
                next = null;
            }
        }

        private LinkedListNode Head;
        private LinkedListNode Tail;

        public void Insert(int n)
        {
            LinkedListNode Temp = new LinkedListNode(n);
            if (Head == null && Tail == null)
            {
                Head = Temp;
                Tail = Temp;
            }
            else
            {
                Tail.next = Temp;
                Tail = Tail.next;
            }
        }

        public void PrintList()
        {
            LinkedListNode Temp = Head;
            while (Temp != null)
            {
                Console.Write("{0} ->", Temp.n);
                Temp = Temp.next;

            }
            Console.WriteLine();
        }

        //Reverse List
        public void Reverse()
        {
            Head = ReverseList(Head);
        }

        private LinkedListNode ReverseList(LinkedListNode Node)
        {
            if (Node == null || Node.next == null) return Node;
            LinkedListNode second = Node.next;
            LinkedListNode reverseSecond = ReverseList(second);
            second.next = Node;
            Node.next = null;
            return reverseSecond;
        }

        //Is Palindrome


        //Merge Sort


        //Quick Sort

        //Reorder List
        //1 2 3 4 5 6 
        //1 6 2 5 3 4

        //Has Cycle

        //Has Cycle if so where





    }

    public class BinaryTree
    {

        public class BinaryTreeNode
        {
            public int n;
            public BinaryTreeNode left;
            public BinaryTreeNode right;
            public BinaryTreeNode(int n)
            {
                this.n = n;
                left = null;
                right = null;
            }
        }

        private BinaryTreeNode Root;
        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int n)
        {
            Root = Insert(Root, n);
        }
        private static BinaryTreeNode Insert(BinaryTreeNode Root, int n)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode(n);
                return Root;
            }

            if (n <= Root.n)
            {
                Root.left = Insert(Root.left, n);
            }
            else
            {
                Root.right = Insert(Root.right, n);
            }
            return Root;
        }

        public void Print()
        {
            Console.WriteLine("InOrder:");
            Inorder(Root);
            Console.WriteLine();
            InOrder_NonRecur(Root);

            Console.WriteLine();
            Console.WriteLine();

            PreOrder_NonRecur(Root);
            PreOrder(Root);

            Console.WriteLine();
            Console.WriteLine();

            PostOrder(Root);
            Console.WriteLine();

        }

        private static void Inorder(BinaryTreeNode Node)
        {
            if (Node != null)
            {
                Inorder(Node.left);
                Console.Write("{0} ", Node.n);
                Inorder(Node.right);
            }
        }
        private static void InOrder_NonRecur(BinaryTreeNode Node)
        {
            if (Node == null) return;

            Stack<BinaryTreeNode> stk = new Stack<BinaryTreeNode>();

            while (Node != null || stk.Count > 0)
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


        private static void PreOrder(BinaryTreeNode Node)
        {
            if (Node != null)
            {
                Console.Write("{0} ", Node.n);
                PreOrder(Node.left);
                PreOrder(Node.right);
            }
        }
        private static void PreOrder_NonRecur(BinaryTreeNode Node)
        {
            if (Node == null) return;

            Stack<BinaryTreeNode> stk = new Stack<BinaryTreeNode>();

            while (Node != null || stk.Count > 0)
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

        private static void PostOrder(BinaryTreeNode Node)
        {
            if (Node != null)
            {
                PostOrder(Node.left);
                PostOrder(Node.right);
                Console.Write("{0} ", Node.n);
            }

        }

        public void LevelOrder()
        {
            LevelOrder(Root);
        }
        private static void LevelOrder(BinaryTreeNode Node)
        {
            if (Node == null) return;
            Queue<BinaryTreeNode> q = new Queue<BinaryTreeNode>();
            q.Enqueue(Node);
            q.Enqueue(null);

            while (q.Count > 0)
            {
                BinaryTreeNode Temp = q.Dequeue();
                if (Temp == null)
                {
                    Console.WriteLine();
                    if (q.Count > 0)
                    {
                        q.Enqueue(null);
                    }
                }
                else
                {
                    Console.Write("{0} ", Temp.n);
                    if (Temp.left != null) q.Enqueue(Temp.left);
                    if (Temp.right != null) q.Enqueue(Temp.right);
                }
            }
        }

        public void Search(int k)
        {
            if (BinarySearch(Root, k) == true)
            {
                Console.WriteLine("{0} is present.", k);
            }
            else
            {
                Console.WriteLine("{0} is not present");
            }
        }

        //O(log n)
        public static bool BinarySearch(BinaryTreeNode Node, int k)
        {
            if (Node == null) return false;
            if (Node.n == k) return true;
            if (k < Node.n) return BinarySearch(Node.left, k);
            return BinarySearch(Node.right, k);
        }

        public int Max()
        {
            return Max(Root, int.MinValue);
        }
        private static int Max(BinaryTreeNode Node, int currentMax)
        {
            if (Node == null) return currentMax;
            if (Node.n > currentMax) { currentMax = Node.n; }
            int anothermax = Math.Max(Max(Node.left, currentMax), Max(Node.right, currentMax));
            return Math.Max(currentMax, anothermax);
        }

        public int MaxDepth()
        {
            return MaxDepth(Root);
        }
        private static int MaxDepth(BinaryTreeNode Node)
        {
            if (Node == null) return 0;
            return MaxDepth(Node.left) + MaxDepth(Node.right) + 1;
        }

        //deepest Node
        private static int? DeepestNode(BinaryTreeNode Node)
        {
            if (Node == null) return null;
            BinaryTreeNode prevs = null;
            Queue<BinaryTreeNode> q = new Queue<BinaryTreeNode>();
            q.Enqueue(Node);
            q.Enqueue(null);

            while (q.Count > 0)
            {
                BinaryTreeNode Temp = q.Dequeue();
                if (Temp == null)
                {
                    if (q.Count > 0)
                    {
                        q.Enqueue(null);
                    }

                }
                else
                {
                    prevs = Temp;
                    if (Temp.left != null) { q.Enqueue(Temp.left); }
                    if (Temp.right != null) { q.Enqueue(Temp.right); }
                }
            }
            return prevs.n;
        }


        public void PritnAllPaths()
        {
            PrintAllPaths(Root, "");
        }
        //print all paths to leaves
        private static void PrintAllPaths(BinaryTreeNode Node,string str)
        {
            if (Node == null) return;
            string newStr = (str.Length==0)? (str + Node.n): (str+ " -> " + Node.n);
            if (Node.left == null && Node.right == null)
            {
                Console.WriteLine(newStr);
            }
            else
            {
                PrintAllPaths(Node.left, newStr);
                PrintAllPaths(Node.right, newStr);
            }
        }

        //level with maximum sum
        private static int LevelWithMaxSum(BinaryTreeNode Node)
        {
            if (Node == null) return -1;
            int maxLevel  = -1;
            int maxLevelSum = 0;

            int currentLevelSum = 0;
            int currentLevel = 1;

            Queue<BinaryTreeNode> q = new Queue<BinaryTreeNode>();
            q.Enqueue(Node);
            q.Enqueue(null);

            while (q.Count > 0)
            {
                BinaryTreeNode Temp = q.Dequeue();
                if (Temp != null)
                {
                    currentLevelSum += Temp.n;
                    if (Temp.left != null) { q.Enqueue(Temp.left); }
                    if (Temp.right != null) { q.Enqueue(Temp.right); }
                }
                else
                {
                    if (currentLevelSum > maxLevelSum)
                    {
                        maxLevel = currentLevel;
                        maxLevelSum = currentLevelSum;
                    }
                    if (q.Count > 0)
                    {
                        currentLevel++;
                        currentLevelSum = 0;
                        q.Enqueue(null);
                    }
                }
            }

            return maxLevel;
        }
        
        //LCA of binary tree
        private static BinaryTreeNode LCA_BT(BinaryTreeNode Root, BinaryTreeNode Node1,BinaryTreeNode Node2)
        {
            if (Root == null || Node1 == null || Node2 == null) return null;
            if (Root == Node1 || Root == Node2) return Root;
            BinaryTreeNode leftLca = LCA_BT(Root.left, Node1, Node2);
            BinaryTreeNode rightLca = LCA_BT(Root.right, Node1, Node2);
            if (leftLca != null && rightLca != null) return Root;
            if (leftLca != null) return leftLca;
            return rightLca;
        }

        //two trees are identical
        private static bool AreIdentical(BinaryTreeNode Node1, BinaryTreeNode Node2)
        {
            if (Node1 == null && Node2 == null) return true;
            if ((Node1 != null && Node2 == null) || (Node1 == null && Node2 != null)) return false;
            if (Node1.n != Node2.n) return false;
            return AreIdentical(Node1.left, Node2.left) && AreIdentical(Node1.left, Node2.left);
        }

        //is there a path with given sum - path : from root to leaf
        private static bool IsPathSumPresent(BinaryTreeNode Node, int targetSum, int currentPathSum)
        {
            if (Node == null) return false;
            currentPathSum += Node.n;
            if (Node.left == null && Node.right == null)
            {
                if (currentPathSum == targetSum) return true;
                return false;
            }
            return IsPathSumPresent(Node.left, targetSum, currentPathSum) || IsPathSumPresent(Node.right, targetSum, currentPathSum);
        }

        //sum of all elements

        //are mirrors
        private static bool AreMirrors(BinaryTreeNode Node1, BinaryTreeNode Node2)
        {
            if (Node1 == null && Node2 == null) return true;
            if ((Node1==null && Node2!=null )||(Node1!=null && Node2==null)) return false;
            if (Node1.n != Node2.n) return false;
            return AreMirrors(Node1.left, Node2.right) && AreMirrors(Node1.right, Node2.left);
        }

        //covert tree to its mirror
        private static BinaryTreeNode Convert2Mirror(BinaryTreeNode Node)
        {
            if (Node == null) return Node;
            BinaryTreeNode newNode = new BinaryTreeNode(Node.n);
            newNode.left = Convert2Mirror(Node.right);
            newNode.right = Convert2Mirror(Node.left);
            return newNode;
        }

        //construct binary tree from Inorder and preOrder

        //vertical sum
        private static void VerticalSums1(BinaryTreeNode Node,int vertical_index, ref Dictionary<int,int> dict)
        {
            if (Node == null) return;
            if (dict.ContainsKey(vertical_index))
            {
                dict[vertical_index] += Node.n;
            }
            else
            {
                dict.Add(vertical_index, Node.n);
            }

            VerticalSums1(Node.left, vertical_index - 1, ref dict);
            VerticalSums1(Node.right, vertical_index + 1, ref dict);
        }

        //are two same binary tree
        private static bool AreSame(BinaryTreeNode node1, BinaryTreeNode node2)
        {
            if (node1 == null && node2 == null) return true;
            if (node1 == null && node2 != null) return false;
            if (node1 != null && node2 == null) return false;
            if (node1.n != node2.n) return false;
            return AreSame(node1.left, node2.left) && AreSame(node1.right, node2.right);
        }

        private static int ClosestToGivenValue(BinaryTreeNode node,int k,int prevClosest)
        {
            if (node == null) return prevClosest;
            int prevDiff = Math.Abs(prevClosest - k);
            int currDiff = Math.Abs(node.n - k);

            if (currDiff > prevDiff)
            {
             //   return ClosestToGivenValue(node.left)
            }
            return 0;
        }

    }

    public class GenericTree {

        public class GenericTreeNode {
            public int n;
            public GenericTreeNode Silbling;
            public GenericTreeNode Child;
            public GenericTreeNode(int n)
            {
                this.n = n;
                Silbling = null;
                Child = null;
            }
        }

        private GenericTreeNode Root;

        public GenericTree()
        {
            Root = null;
        }

        private static int SumAll(GenericTreeNode Node)
        {
            if (Node == null) return 0;
            int sum = Node.n;
            GenericTreeNode sib = Node.Silbling;
            while (sib != null)
            {
                sum += SumAll(sib);
                sib = sib.Silbling;
            }
            return sum + SumAll(Node.Child);
        }






    }

    public class DP {

        //T(n) = T(n-1)  + O(1) => O(n)
        public static int Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * Factorial(n - 1);
        }

        //memoization
        //O(n)
        private static int[] F = new int[100];
        public static int Factorial_mem(int n)
        {
            if (F[n] != 0) return F[n];
            if (n == 0 || n == 1)
            {
                F[n] = 1;
            }
            else
            {
                F[n] = n * Factorial_mem(n - 1);
            }
            return F[n];
        }

        //tabulation
        //O(n)
        public static int Factorial_Tab(int n)
        {
            int[] Fact = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                if (i == 0 || i == 1)
                {
                    Fact[i] = 1;
                }
                else
                {
                    Fact[i] = Fact[i - 1] * i;
                }
            }

            return F[n];
        }

        //fibonacci
        //recursive
        //T(n) = T(n-1)+T(n-2)
        //O(n2)
        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 2) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        //memoization
        //O(n)
        private static int[] Fibo = new int[100];
        public static int Fibo_Mem(int n)
        {
            if (Fibo[n] != 0) return Fibo[n];
            if(n==1||n==2)
            {
                Fibo[n] = n;
            }
            else
            {
                Fibo[n] = Fibo_Mem(n - 1) + Fibo_Mem(n - 2);
            }
            return Fibo[n];
        }

        //Tabulation
        //O(n)
        private static int Fibo_Tab(int n)
        {
            int[] Fibo = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    Fibo[i] = i + 1;
                }
                else
                {
                    Fibo[i] = Fibo[i - 1] + Fibo[i - 2];
                }

            }

            return Fibo[n - 1];
        }

        //LCS 
        public static string LCS(string x, string y)
        {
            int m = x.Length;
            int n = y.Length;

            int[,] L = new int[m+1, n+1];
            int[,] P = new int[m, n];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        L[i, j] = 0;
                    }
                    else
                    {
                        if (x[i - 1] == y[j - 1])
                        {
                            L[i, j] = L[i - 1, j - 1] + 1;
                            P[i - 1, j - 1] = 1; //cross
                        }
                        else
                        {
                            if (L[i - 1, j] >= L[i, j - 1])
                            {
                                L[i, j] = L[i - 1, j];
                                P[i - 1, j - 1] = 2; //up
                            }
                            else
                            {
                                L[i, j] = L[i, j - 1];
                                P[i - 1, j - 1] = 3; //left
                            }
                        }
                    }
                }
            }

            int p = m-1;
            int q = n-1;
            StringBuilder sb = new StringBuilder();

            while (p >= 0 && q >= 0)
            {
                if (P[p, q] == 1)
                {
                    sb.AppendFormat("{0}", x[p]);
                    p--;
                    q--;
                }
                else if (P[p, q] == 2)
                {
                    //up
                    p--;
                }
                else
                {
                    q--;
                }
            }

            return sb.ToString();
        }

        //maximum value continous sum 
        //O(n)
        public static int Max_Continous_sum(int[] A)
        {
            if (A.Length == 0) return 0;

            int[] M = new int[A.Length];
            //M[i] - maximum contiguous sum of all the sequences that end at i

            for (int i = 0; i < M.Length; i++)
            {
                if (i == 0)
                {
                    M[i] = A[i];
                }
                else {
                    M[i] = Math.Max(M[i - 1] + A[i], A[i]);

                }
            }

            //HashSet<int> s = new HashSet<int>();
            //s.Add()
            return M.Max();
        }

        //maximum contiguous sum - no two consequtive
        //public static int Max_Continous_Sum_NoTwo_Consequtive(int[] A)
        //{
        //    if (A.Length == 0) return 0;
        //    int[] M = new int[A.Length];
        //    //M[i] represents max val of a subsequence that end at i st no two elments are consequtive 

        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            M[i] = 
        //        }
        //    }

        //}




    }    
}





