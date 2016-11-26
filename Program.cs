using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prepPhase3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bit Problems

            #endregion

            #region Sorting
            //int[] A = { 98, 91, 1, 2,16,19,4,0};
            //Sorting.SelectionSort(ref A);
            //Sorting.InsertionSort(ref A, 0, A.Length - 1);
            //Sorting.QuickSort(ref A, 0, A.Length - 1);
            //Sorting.MergeSort(ref A, 0, A.Length - 1);
            //PrintArray(A);
            //int[] A = { 8, 9, 1, 2, 1, 9, 4, 0 };
            //Sorting.ShellSort(ref A);
            //MyHeap h = new MyHeap();
            //h.HeapSort(ref A);
            //PrintArray(A);
            //int[] A = { 1, 2, 3, 1, 3, 6, 6 };

            //Console.WriteLine("{0}",Sorting.IsAnyNumberRepeated(A,0,A.Length-1));
            //Console.WriteLine("{0}", Sorting.IsAnyNumberRepeated1(A, 0, A.Length - 1));

            #endregion

            #region Searching
            //Console.WriteLine("** Searching Section **");
            //int[] A1 = { 1, 60, -10, 70, -80, 85 };
            //int[] A3 = { 0, 1, 0, 1, 0, 1 };
            //int[] Z = {-1, 0, 1, 2, -1, -4};
            //int[] I = {1,1,1,1,1,0,0,0,0,0,0,0,0 };
            //int[] O = { 12, 11, 15, 10, 20 };

            //int[] T = { 10, 11,11,11,12, 12, 15, 20 };
            //int[] Triple = { 0,1,2,0,0,1,1,1,2,0,1,2,0,0};
            ////Console.WriteLine(Searching.FindMissingNum2(A1));
            //Searching.FindTheRepeatingTwo(A1);
            //Searching.FindTwoWhoseSumIsK2(A1,16);
            //Searching.SumClosestToZero(A1);
            //Searching.FindThreeSumIsK(A3, 24);
            //Searching.SumThreeClosestToZero(Z);
            //Console.WriteLine(Searching.FirstOccuerence(T,0,T.Length-1,12));
            //Searching.FindMedian(O, 0, O.Length - 1, T, 0, T.Length - 1);
            //Searching.NUmberOfRepeatitions(T, 13);
            //Searching.SeparateTriple(ref Triple, 0, Triple.Length - 1);
            //PrintArray(Triple);

            #endregion

            #region selection
            //Console.WriteLine("** Selection **");
            //int[] A = { 9, 8, 7, 6, 5 };
            //Console.WriteLine(Selection.KthElement(A,0,A.Length-1,1));


            #endregion

            #region strings

            //Console.WriteLine("** strings **");

            //Console.WriteLine (StringProblems.IsValidParenthesis("(((())()))"));
            //Console.WriteLine(sb.ToString());
            //string pattern = "abba";
            //string str = "dog cat cat dog";// should return true.
            //Console.WriteLine(StringProblems.WordPattern(pattern,str));
            //Console.WriteLine();
            //Console.WriteLine(StringProblems.ReverseVowels("leetcode"));
            #endregion

            #region MyLinkedList
            MyLinkedList L = new MyLinkedList();
            //L.Insert(7);
            //L.Insert(7);
            //L.Insert(7);
            //L.Insert(4);
            //L.Insert(4);
            //L.Insert(2);
            //L.Insert(1);
            L.DeleteDups();
            L.PrintMyList();

            //L.ReorderList();
            #endregion

            #region MyStack
            //MyStack s = new MyStack(5);
            //s.Push(1);
            //s.Push(2);
            //s.Push(3);
            //s.PrintStack();
            //int res = s.Pop();
            //s.Push(4);
            //s.PrintStack();
            #endregion

            #region MyBinaryTree
            //MyBinaryTree bt = new MyBinaryTree();

            //bt.Insert(3);
            //bt.Insert(2);
            //bt.Insert(1);
            //bt.Insert(5);
            //bt.Insert(4);
            //bt.Insert(7);
            //bt.PrintColumns();
            //Console.WriteLine();
            ////bt.ZigZag();
            //bt.PreOrder_NonRecursive();

            #endregion

            #region Stacks 

            #endregion

            #region Dynamic Programming
            //DynamicProgramming.LCS("ABCDGH","AEDFHR");
            //int[] A2 = { -2, -3, 4, -1, -2, 1, 5, -3 };
            //DynamicProgramming.Max_Value_Continous_Subsequence(A2);
            //int[] A3 = { 10, 9, 2, 5, 3, 7, 101, 18 };
            //int[] A4 = { 2 , 3, 5, 7, 9,10,  18,101 };
            //DynamicProgramming.LCS_Integers(A3, A4);
            //int[] A2 = { 5,5,10,40,50,35}; 
            //DynamicProgramming.Max_Value_Contigous_Subsequence_NoTwo_Continous(A2);
            //int[] W = { 9,6,5,1};
            //Console.WriteLine(DynamicProgramming.ChangeCoins(W,11));
            //int[] S = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
            //DynamicProgramming.Longest_Increasing_Subsequence(S);
            //int[] X = { 3, 34, 4, 12, 5, 2 };
            //Console.WriteLine(DynamicProgramming.IsThereSubset(X, 9));
            //int[] M = { 1, 101, 2, 3, 100, 4, 5 };
            //Console.WriteLine(DynamicProgramming.MaxSum_Increasing_sequence(M));
            #endregion

            #region Random Sites
            //Console.WriteLine("** Random Sites **");
            //int[] A = { 9, 9, 3, 4, 2, 2, 3, 6, 7, 6, 8, 9 };
            //int[] A = {123,321,432,433,232};
            //int[] B = FromRandonSites.CountingSort(A);
            //PrintArray(B);
            //Console.WriteLine(FromRandonSites.CountingSort_String("cccbbbaarrrttqqaaa"));
            //FromRandonSites.RadixSort(ref A);
            //PrintArray(A);
            #endregion

            #region Maths
            //Console.WriteLine(MathTricks.GetSum(1,4));
            //Console.WriteLine(MathTricks.GetSum(-1, 4));
            //Console.WriteLine(MathTricks.IsPalindrome(-748847));
            //Console.WriteLine(MathTricks.IsMultipleOf3(330));
            #endregion
            //int[] A = new int[10];

            //A.ToList()
            //List<int> l = new List<int>(A);


            //int[] K = { 100, 180, 260, 310, 40, 535, 695 };
            //Console.WriteLine(MaxProfit_1Transaction(K, 0, K.Length - 1));
            //ISet<int> n = new HashSet<int>();
            //List<int> li = n.ToList<int>();
            //    //Console.WriteLine();

            ////StringProblems.permte(new StringBuilder("abc"), 0, 2);
            //List<string> li = new List<string>();
            //li.Add("one");
            //li.Add("two");
            //StringProblems.PermuteListOfWords(li, 0, li.Count - 1);


            //BinrayTree2 bt = new BinrayTree2();
            //bt.Insert(1);
            //bt.Insert(2);
            //bt.Insert(3);
            //bt.Insert(4);
            //bt.Insert(5);
            //bt.practice_level();

            //int[] Ino = { 4,2,5,1,6,3};
            //int[] Pre = { 1,2,4,5,3,6};
            //bt.BuildTreeFrom_InorderAndPreOrder(Ino, Pre);
            ////bt.PrintAllPaths();
            //bt.Diameter();
            //bt.LevelOrder();
            //bt.DeepestNode();
            //int[] n = { 0, 1, 0, 1, 0, 1, 1, 2, 0, 2, 0 };
            //Partition(ref n, 0, n.Length - 1);
            //PrintArray(n);
            //Permute("abc", 0, 2);
            //int[] A = { 1,2,3,4,5,6};
            //SeparateEvenOdd(ref A);
            //PrintArray(A);
            //MoveZeroesRight(ref A);
            //Combinations(A, 0, A.Length - 1, 2, new List<int>(), 0);
            //PowerSet(A);

            //int[] A = { 1, 2, 3, 4, 5, 6, 7, 9};
            //QuickSort(ref A, 0, A.Length - 1);
            //PrintArray(A);
            //Console.WriteLine(MaxSumContinousSequence(A));
            //int[] A = new int[10];
            //EvenOddIndexSeparation(ref A);
            //PrintArray(A);
            //SortedSet<int> set = new SortedSet<int>();

            // MyTrie t = new MyTrie();
            // t.Insert("tea");
            // t.Insert("dead");
            // t.Insert("te");
            // t.PrintAllStrings();
            // Console.WriteLine("{0} {1}","tea",t.Search("tea"));
            // Console.WriteLine("{0} {1}", "te", t.Search("te"));
            // HashSet<string> dic = new HashSet<string>();
            // dic.Add("leet");
            // dic.Add("code");
            // Console.WriteLine(WordBreak("leetcode",dic));
            // Console.WriteLine("{0}", SumOffAllNumbersInString("a12b23b12"));
            // List<int> l = new List<int>();
            // int[] A = l.ToArray();
            // int[] AN = {2,4,12,3,3,4,5 };
            // Separate_Evn_odd(ref AN);
            // PrintArray(AN);
            // Print_All_Posssible("", 1, 2, false);
            // MyOrderedSet s = new MyOrderedSet();
            // s.DuplicateAddedEvent += SubscribeToDuplicateEvent;
            //PrintAllParenths(3, 0, 0, "");

            //BinaryTree3 tree = new BinaryTree3();
            //tree.Insert(8);
            //tree.Insert(10);
            //tree.Insert(14);
            //tree.Insert(13);

            //tree.Insert(3);
            //tree.Insert(6);
            //tree.Insert(1);
            //tree.Insert(7);
            //tree.Insert(4);

            //tree.Inorder();d
            //Console.WriteLine();
            //tree.PreOrder();
            //Console.WriteLine();
            //tree.PostOrder();
            //tree.Inorder();
            //tree.PreOrder();
            //tree.Deepest();

            //tree.PrintAllPaths();


            //BinaryTree bt = new BinaryTree();
            //bt.Insert(8);
            //bt.Insert(3);
            //bt.Insert(1);
            //bt.Insert(6);
            //bt.Insert(4);
            //bt.Insert(7);
            //bt.Insert(10);
            //bt.Insert(14);
            //bt.Insert(13);
            //bt.PritnAllPaths();

            //PhoneDirectory myPhone = new PhoneDirectory();
            //myPhone.AddNumber("6087703061", "nataraj");
            //myPhone.AddNumber("6087703062", "vindesiel");

            //Console.WriteLine(myPhone.GetName("6087703061"));
            //Console.WriteLine(myPhone.GetName("6087703062"));

            mylist l = new mylist();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            l.PrintList();
            l.Reverse();
            l.PrintList();



            Console.ReadLine();

        }

        public static void TestEvents1(int n)
        {
            Console.WriteLine("Test Events 1 = {0}",n);
        }

        public static int FirstMissingPositive(int[] nums)
        {

            int positiveXor = 0;
            int lowestPositive = int.MaxValue; //should be  >=1
            int positiveCount = 0;
            bool isPositivePresent = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    isPositivePresent = true;
                    positiveXor = positiveXor ^ nums[i];
                    positiveCount++;

                    if (nums[i] < lowestPositive)
                    {
                        lowestPositive = nums[i];
                    }
                }

            }
            if (!isPositivePresent) return 1;

            int n = positiveCount;
            int xor = lowestPositive;

            int j = 0;
            for (j = 1; j <= n; j++) 
            {
                xor = xor ^ (lowestPositive + j);
            }

            return xor ^ positiveXor;


            
        }

        public static void Text(int[] B)
        {
        }

        public static void SubscribeToDuplicateEvent()
        {
            Console.WriteLine("Duplicate is added");
        }

        public static void PrintArray(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            Console.WriteLine();
        }

        //()()()()
        public static void PrintAllParenths(int n, int openParenth, int closedParenth, string s)
        {
            if (closedParenth == n)
            {
                Console.WriteLine(s);
            }
            else
            {
                if (openParenth > closedParenth)
                {
                    StringBuilder sb = new StringBuilder(s);
                    sb.AppendFormat("{0}", ")");
                    PrintAllParenths(n, openParenth, closedParenth + 1, sb.ToString());
                }
                if (openParenth < n)
                {
                    StringBuilder sb = new StringBuilder(s);
                    sb.AppendFormat("{0}", "(");
                    PrintAllParenths(n, openParenth + 1, closedParenth, sb.ToString());
                }
            }
        }

        public static void Separate_Evn_odd(ref int[] A)
        {
            if (A.Length == 0) return;
            int i = -1;
            int j = 0;
            while (j < A.Length)
            {
                if (A[j] % 2 == 0)
                {

                    swap(ref A, i + 1, j);
                    i++;
                }
                j++;
            }
        }

        //remember words can be repeated
        public static int Shortest_word_Distance_1(string[] words, string word1, string word2)
        {
            int min = int.MaxValue;
            int index1 = -1; //track index where word1 occurs in case of min distance, 
                             //-1 indicates we havent found the word yet
            int index2 = -1;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word1)
                {
                    index1 = i;
                    if (index2 != -1)
                    {
                        min = Math.Min(min, Math.Abs(index1 - index2));
                    }
                }
                else if (words[i] == word2)
                {
                    index2 = i;
                    if (index1 != -1)
                    {
                        min = Math.Min(min, Math.Abs(index1 - index2));
                    }
                }
            }

            return min;


        }

        public static int[] KMPPrefix(string P)
        {
            int[] F = new int[P.Length];
            if (P.Length == 0) return F;
            int i = 1;
            int j = 0;
            F[0] = 0;

            while (i < P.Length)
            {
                if (P[i] == P[j])
                {
                    F[i] = j + 1;
                    i++;
                    j++;
                }
                else if (j > 0)
                {
                    j = F[j - 1];
                }
                else
                {
                    F[i] = 0;
                    i++;
                }

            }

            return F;
        }
        public static int IsSubstring_KMP(string T, string P)
        {
            int[] F = KMPPrefix(P);

            int i = 0;
            int j = 0;

            while (i < T.Length)
            {
                if (T[i] == P[j])
                {
                    if (j == P.Length - 1)
                    {
                        return i - j;
                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }
                else if (j > 0)
                {
                    j = F[j - 1];
                }
                else
                {
                    i++;
                }
            }

            return -1;
        }
        
        #region stock Problems

        //if 1 transaction is allowed what is the max profit that can be made ?
        public static int MaxProfit_1Transaction(int[] A, int p, int q)
        {
            if (p == q) return 0;
            int maxProfit = int.MinValue;
            int currentMin = A[p];
            int j = p + 1;
            while (j <= q)
            {
                int currentProfit = A[j] - currentMin;
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }
                if (A[j] < currentMin)
                {
                    currentMin = A[j];
                }
                j++;
            }
            if (maxProfit < 0) return 0;
            return maxProfit;
        }
        public static void Partition(ref int[] nums, int low, int high)
        {
            int pivot = 1;

            int p = low - 1;
            int q = high + 1;
            int r = low;

            while (r < q && r > p && p < q)
            {
                if (nums[r] < pivot)
                {
                    Interchange(ref nums, p + 1, r);
                    p++;
                    r++; ;
                }
                else if (nums[r] == pivot)
                {
                    r++;
                }
                else
                {
                    Interchange(ref nums, q - 1, r);
                    q--;

                }
            }

        }
        public static void Interchange(ref int[] A, int x, int y)
        {
            int temp = A[x];
            A[x] = A[y];
            A[y] = temp;
        }
        #endregion
        
        #region LinkedIn Practice
        public static int NumberOfOccurences(int[] A, int k)
        {
            if (A.Length == 0) return 0;
            int first = FirstOccurrence(A, 0, A.Length - 1, k);
            if (first == -1) return 0;
            int last = LastOccurence(A, 0, A.Length - 1, k);

            return last - first + 1;

        }
        public static int FirstOccurrence(int[] A, int p, int q, int k)
        {

            if (p <= q)
            {
                int mid = p + (q - p) / 2;
                if (A[mid] == k)
                {
                    if (mid == p || A[mid - 1] != k)
                    {
                        return mid;
                    }
                    else
                    {
                        return FirstOccurrence(A, p, mid - 1, k);
                    }
                }
                else if (k < A[mid])
                {
                    return FirstOccurrence(A, p, mid - 1, k);
                }
                else
                {
                    return FirstOccurrence(A, mid + 1, q, k);
                }

            }
            return -1;
        }
        public static int LastOccurence(int[] A, int p, int q, int k)
        {
            if (p <= q)
            {
                int mid = p + (q - p) / 2;
                if (A[mid] == k)
                {
                    if (mid == q || A[mid + 1] != k)
                    {
                        return mid;
                    }
                    else
                    {
                        return LastOccurence(A, mid + 1, q, k);
                    }
                }
                else if (k > A[mid])
                {
                    return LastOccurence(A, mid + 1, q, k);
                }
                else
                {
                    return LastOccurence(A, p, mid - 1, k);
                }
            }
            return -1;
        }

        //true exp = “[()]{}{[()()]()}” and false for exp = “[(])”
        public static bool ParenthesisMatching(string s)
        {
            int len = s.Length;

            //Parenthesis couldnt be balanced if the lenght is odd
            if (len % 2 != 0) return false;

            Stack<char> stackForLefts = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (IsLeft(c))
                {
                    stackForLefts.Push(c);
                }
                else if (IsRight(c))
                {
                    if (stackForLefts.Count == 0) return false;
                    char top = stackForLefts.Peek();
                    if (top != c) return false;
                    stackForLefts.Pop();
                }
                else
                {
                    //Not a valid input since char is not part of the 6 letterrs
                    return false;
                }
            }

            if (stackForLefts.Count > 0) return false;
            return true;
        }
        public static bool IsLeft(char c)
        {
            if (c == '(' || c == '[' || c == '{') return true;
            return false;
        }
        public static bool IsRight(char c)
        {
            if (c == ')' || c == ']' || c == '}') return true;
            return false;

        }

        #region Permutations Related

        //Gray Code


        //Permutations 1
        //Find all combinations of given integers
        public static void Permute(string s, int p, int q)
        {

            if (p == q)
            {
                Console.WriteLine(s);
            }
            else if (p < q)
            {
                StringBuilder sb = new StringBuilder(s);
                for (int i = p; i <= q; i++)
                {
                    char c = sb[i];
                    sb[i] = sb[p];
                    sb[p] = c;

                    Permute(sb.ToString(), p + 1, q);

                    c = sb[i];
                    sb[i] = sb[p];
                    sb[p] = c;

                }
            }
        }

        //Permutations 2
        //        Given a collection of numbers that might contain duplicates, return all possible unique permutations.
        //        For example,
        //        [1,1,2] have the following unique permutations:
        //[
        //          [1,1,2],
        //          [1,2,1],
        //          [2,1,1]
        //]
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            List<IList<int>> final = new List<IList<int>>();
            Permute(nums, 0, nums.Length - 1, ref final);
            return (IList<IList<int>>)final;
        }
        public static void Permute(int[] A, int p, int q, ref List<IList<int>> final)
        {
            if (p == q)
            {
                List<int> li = new List<int>(A);
                final.Add((IList<int>)li);
            }
            else if (p < q)
            {
                int prev = p;
                for (int i = p; i <= q; i++)
                {
                    if (HasDuplicate(A, p, i) == false)
                    {
                        Interchange(ref A, p, i);
                        Permute(A, p + 1, q, ref final);
                        Interchange(ref A, p, i);

                    }

                }
            }
        }
        //Checks if element A[q] is present in A[p]...A[q-1]
        public static bool HasDuplicate(int[] A, int p, int q)
        {
            for (int i = p; i < q; i++)
            {
                if (A[i] == A[q]) return true;
            }
            return false;
        }

        //Next Permutation (LeetCode)
        //Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
        //If such arrangement is not possible, it must rearrange it as the lowest possible order(ie, sorted in ascending order).
        //The replacement must be in-place, do not allocate extra memory.
        //Here are some examples.Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.
        //1,2,3 → 1,3,2
        //3,2,1 → 1,2,3
        //1,1,5 → 1,5,1
        //1. From right to left, find the first digit(PartitionNumber) which violate the increase trend.
        //2. From right to left, find the first digit which larger than PartitionNumber, call it ChangeNumber.
        //3. Swap the PartitionNumber and ChangeNumber.
        //4. Reverse all the digit on the right of partition index.
        public static void NextPermutation(ref int[] nums, int p, int q)
        {
            //    public void Next(ref int[] nums, int p, int q)

            int i = q - 1;
            while (i >= p && nums[i] >= nums[i + 1]) //here increasing sequence is not strictly increasing for ex [5,1,1]
            {
                i--;
            }

            if (i < p)
            {
                Reverse(ref nums, p, q);
                return;
            }
            int partition = i;
            int j = q;

            while (j >= p && nums[j] <= nums[partition])
            {
                j--;
            }

            if (j < p) return;

            swap(ref nums, partition, j);
            Reverse(ref nums, partition + 1, q);

        }
        public static void swap(ref int[] N, int p, int q)
        {
            int n = N[p];
            N[p] = N[q];
            N[q] = n;
        }
        public static void Reverse(ref int[] nums, int p, int q)
        {
            while (p < q)
            {
                int n = nums[p];
                nums[p] = nums[q];
                nums[q] = n;
                p++;
                q--;
            }
        }

        //Palindrome Permutation || (LeetCode)
        //Does the given string have a palindrome permutation
        public static bool HasPalindromePermutation(string s)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (d.ContainsKey(c))
                {
                    d[c]++;
                }
                else
                {
                    d.Add(c, 1);
                }
            }

            int countOdds = 0;

            foreach (char c in d.Keys)
            {
                if (d[c] % 2 != 0)
                {
                    countOdds++;
                }
            }

            //if s is odd length.... abc 
            if (s.Length % 2 != 0)
            {
                if (countOdds > 1) return false;
                return true;
            }
            //if s is even then odds should be even
            if (countOdds % 2 == 0) return true;
            return false;
        }

        //better way than above
        public static bool HasPalindromePermutation1(string s)
        {
            HashSet<char> unpairedChars = new HashSet<char>();

            foreach (char c in s)
            {
                if (unpairedChars.Contains(c))
                {
                    unpairedChars.Remove(c);
                }
                else
                {
                    unpairedChars.Add(c);
                }
            }
            if (s.Length % 2 == 0)
            {
                if (unpairedChars.Count == 0) return true;
                return false;
            }
            if (unpairedChars.Count <= 1) return true;
            return false;


        }

        //Palindrome Partitioning II
        //        Given a string s, partition s such that every substring of the partition is a palindrome.
        //Return the minimum cuts needed for a palindrome partitioning of s.
        //For example, given s = "aab",
        //Return 1 since the palindrome partitioning ["aa","b"] could be produced using 1 cut.


        //finding power set of given set
        public static void PowerSet(int[] A)
        {
            List<HashSet<int>> res = new List<HashSet<int>>();
            int n = A.Length;
            int m = (int)Math.Pow(2, n);

            for (int i = 0; i < m; i++)
            {
                res.Add(new HashSet<int>());

                for (int j = 1; j <= n; j++)
                {
                    if (Isset(i, j))
                    {
                        res[i].Add(A[j - 1]);
                    }
                }
            }

            foreach (HashSet<int> h in res)
            {
                Console.Write("{");
                foreach (int i in h)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.Write("}");
                Console.WriteLine();
            }
        }
        //is kth bit set in n
        public static bool Isset(int n, int k)
        {
            int m = 1;
            while (k > 1)
            {
                m = m << 1;
                k--;
            }
            return (n & m) != 0;
        }

        //http://www.martinbroadhurst.com/combinatorial-algorithms.html
        //combinations = ncr
        //selecting r elements from given n elements
        public static void Combinations(int[] A, int low, int high, int r, List<int> l, int index)
        {
            if (index == r)
            {
                PrintArray(l.ToArray());
                return;
            }
            else
            {
                for (int i = low; (i <= high) && ((high - i + 1) >= (r - index)); i++)
                {
                    if (index >= l.Count) l.Add(new int());
                    l[index] = A[i];
                    Combinations(A, i + 1, high, r, l, index + 1);
                }
            }
        }

        #endregion

        //the sum of any two sides must be greater than the value of third side).
        //given list of numbers whihc represent sides of triangle , how many valid traingles can be formed
        //This is of O(n2) while brute force is O(n3)
        public static int NumberOfTriangles(int[] A)
        {
            if (A.Length < 3) return 0;
            Array.Sort(A);
            return NumberOfTriangles(A, 0, A.Length - 1);
        }
        public static int NumberOfTriangles(int[] A, int p, int q)
        {
            int count = 0;

            for (int i = p; i < q - 1; i++)
            {

                for (int j = i + 1; j < q; j++)
                {
                    int k = j + 1;

                    while (k <= q && A[i] + A[j] > A[k])
                        k++;

                    count += k - j - 1;
                }
            }

            return count;
        }

        //Evalutate post fix expression
        public static int EvaluatePostFix(string s)
        {
            Stack<int> stackOfOperands = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (IsNumber(s[i]))
                {
                    stackOfOperands.Push((int)s[i]);
                }
                else
                {
                    //we have an operator
                    if (stackOfOperands.Count > 1)
                    {
                        int n1 = stackOfOperands.Pop();
                        int n2 = stackOfOperands.Pop();
                        stackOfOperands.Push(Operate(s[i], n1, n2));
                    }
                    else
                    {
                        //invalid expression
                        return -999;
                    }
                }
            }

            if (stackOfOperands.Count != 1) return -999;
            return stackOfOperands.Pop();
        }
        public static bool IsNumber(char c)
        {
            int asci = (int)c;
            if (asci >= 48 && asci <= 57) return true;
            return false;
        }
        public static int Operate(int c, int n1, int n2)
        {
            switch (c)
            {
                case '*':
                    return n1 * n2;
                case '/':
                    return n2 / n1;
                case '+':
                    return n1 + n2;
                case '-':
                    return n2 - n1;
                default:
                    return -999;
            }
        }

        //Given an array of numbers , replace each number with the product of 
        //all the numbers divided by the number at that index without using the division operator
        public static void SetProductOfAll(ref int[] A)
        {
            if (A.Length == 1) { A[0] = 1; return; }
            int[] left = new int[A.Length];
            for (int i = 0; i < left.Length; i++)
            {
                if (i == 0)
                {
                    left[i] = A[i];
                }
                else {
                    left[i] = left[i - 1] * A[i];
                }
            }

            int[] right = new int[A.Length];

            for (int i = right.Length - 1; i >= 0; i--)
            {
                if (i == right.Length - 1)
                {
                    right[i] = A[i];
                }
                else
                {
                    right[i] = right[i + 1] * A[i];
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0 && i + 1 < A.Length)
                {
                    A[i] = right[i + 1];
                }
                else if (i == A.Length)
                {
                    A[i] = left[i - 1];
                }
                else
                {
                    A[i] = left[i - 1] * right[i + 1];
                }
            }

        }

        //Minumim window string ********
        //see https://leetcode.com/problems/minimum-window-substring/
        public static string MinWindow(string s, string t)
        {
            //if (t.Length > s.Length) return "";

            ////HashSet<char> set = new HashSet<char>();
            ////HashSet<char> set1 = new HashSet<char>();

            //Dictionary<char, int> d = new Dictionary<char, int>();
            //Dictionary<char, int> d1 = new Dictionary<char, int>();

            //for (int b = 0; b < t.Length; b++)
            //{
            //    //set.Add(t[b]);

            //    if (d.ContainsKey(t[i]))
            //    {
            //        d[t[i]]++;
            //    }
            //    {
            //        d.Add(t[i], 1);
            //    }

            //    //set1.Add(t[b]);
            //    d1.Add(t[i], 1);
            //}


            //int i = 0;

            //while (!set.Contains(s[i]) && i < s.Length)
            //{
            //    i++;
            //}

            //if (i == s.Length) return "";

            //set.Remove(s[i]);

            //int j = i + 1;
            //while (j < s.Length && set.Count > 0)
            //{
            //    if (set.Contains(s[i]))
            //    {
            //        set.Remove(s[i]);
            //    }

            //    j++;
            //}

            //if (set.Count > 0) return "";
            //if (j >= s.Length) return s;

            //int minLen = j - i + 1;
            //j++;
            //while (j < s.Length)
            //{
            //    if (s[j] == s[i])
            //    {
            //        i++;

            //        while (!set1.Contains(s[i]))
            //        {
            //            i++;
            //        }

            //        int newLen = j - i + 1;
            //        if (newLen < minLen)
            //        {
            //            minLen = newLen;
            //        }
            //    }

            //    j++;
            //}

            //return s.Substring(i, minLen);
            ////return minLen;
            return "";
        }

        //Move zeroes to right
        //input  [0, 1, 0, 3, 12]
        //output  [1, 3, 12, 0, 0]
        public static void MoveZeroesRight(ref int[] A)
        {
            if (A.Length <= 1) return;

            int i = -1;

            int j = 0;
            while (j < A.Length)
            {
                if (A[j] != 0)
                {
                    Interchange(ref A, i + 1, j);
                    i++;
                    if (i == j) j++;
                }
                else
                {
                    j++;
                }
            }

            PrintArray(A);
        }

        //Atoi - string to number
        //returns zero if input has anything other than numbers
        public static int MyAtoi(string s)
        {
            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int asci = (int)s[i];
                if (asci < 48 || asci > 57) return 0;
                res = (res * 10) + asci;
            }
            return res;
        }

        //Separte Even odd
        public static void SeparateEvenOdd(ref int[] A)
        {
            if (A.Length <= 1) return;

            int i = -1;
            int j = 0;

            while (j < A.Length)
            {
                if (A[j] % 2 == 0)
                {
                    Interchange(ref A, i + 1, j);
                    i++;
                    if (i == j) j++;
                }
                else
                {
                    j++;
                }
            }
        }

        public static int depthSum(List<NestedInteger> input)
        { // ur implementation here 

            return sumCal(input, 1);
        }
        public static int sumCal(List<NestedInteger> input, int depth)
        {
            if (input == null || input.Count == 0) return 0;
            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                NestedInteger nestInt = input[i];
                if (nestInt.isInteger())
                {
                    sum = sum + depth * nestInt.getInteger();
                }
                else
                {
                    sum = sum + sumCal(nestInt.getList(), depth + 1);
                }
            }

            return sum;
        }
        //This is the interface that represents nested lists. 
        //You should not implement it, or speculate about its implementation. 
        public interface NestedInteger
        {
            // @return true if this NestedInteger holds a single integer, rather than a nested list */ 
            bool isInteger();

            // @return the single integer that this NestedInteger holds, if it holds a single integer 
            // Return null if this NestedInteger holds a nested list */ 
            int getInteger();

            // @return the nested list that this NestedInteger holds, if it holds a nested list 
            // Return null if this NestedInteger holds a single integer */ 
            List<NestedInteger> getList();
        }

        //Given a target and a sorted array, find the element that is strictly 
        //larger than the target.i.e. {a,c,d,e} b output: c
        public static int StrictlyGreater(int[] A, int p, int q, int k)
        {
            if (p == q)
            {
                if (A[p] > k) return p;
                return -1;
            }
            else if (p < q)
            {
                int mid = p + (q - p) / 2;
                if (A[mid] > k)
                {
                    if (A[mid - 1] <= k)
                    {
                        return mid;
                    }
                    else
                    {
                        return StrictlyGreater(A, p, mid - 1, k);
                    }
                }
                else
                {
                    return StrictlyGreater(A, mid + 1, q, k);
                }
            }
            return -1;
        }

        //find the max sum of continuous sequence in the array. {2,-1,3,-5,3} output: 4
        public static int MaxSumContinousSequence(int[] A)
        {
            if (A.Length == 0) return 0;

            int[] M = new int[A.Length];
            M[0] = A[0];

            for (int i = 1; i < M.Length; i++)
            {
                M[i] = Math.Max(M[i - 1] + A[i], A[i]);
            }

            return M.Max();
        }

        #region Interval Problems
        //{1,3}, {2,4}, {5,7}, {6,8} }. merge overlapping intervals
        public static List<Range> MergeRanges(List<Range> L)
        {
            if (L.Count == 0) return null;
            MergeSortRanges(ref L, 0, L.Count - 1);
            List<Range> result = new List<Range>();

            Range prev = L[0];

            for (int i = 1; i < L.Count; i++)
            {
                if (L[i].left <= prev.right)
                {
                    prev.right = L[i].right;
                }
                else {
                    result.Add(prev);
                    prev = L[i];
                }
            }

            return result;
        }
        //sort the list of ranges based on first elements
        public static void MergeSortRanges(ref List<Range> l, int p, int q)
        {
            if (p < q)
            {
                int mid = p + (q - p) / 2;
                MergeSortRanges(ref l, p, mid);
                MergeSortRanges(ref l, mid + 1, q);
                MergeSortedRanges(ref l, p, mid, q);
            }
        }
        public static void MergeSortedRanges(ref List<Range> l, int p, int r, int q)
        {
            int l1 = r - p + 1;
            int l2 = q - r;
            List<Range> left = new List<Range>();
            for (int i = 0; i < l1; i++)
            {
                left.Add(l[p + i]);
            }

            List<Range> right = new List<Range>();
            for (int j = 0; j < l2; j++)
            {
                right.Add(l[r + 1 + j]);
            }

            int i1 = 0;
            int j1 = 0;
            int k1 = 0;
            while (i1 < left.Count && j1 < right.Count)
            {
                if (left[i1].left <= right[j1].left)
                {
                    l[k1] = left[i1];
                    i1++;

                }
                else
                {
                    l[k1] = right[j1];
                    j1++;

                }
                k1++;
            }

            while (i1 < left.Count)
            {
                l[k1] = left[i1];
                i1++;
                k1++;
            }

            while (j1 < right.Count)
            {
                l[k1] = right[j1];
                j1++;
                k1++;
            }
        }


        //InsertInterval

        //Meeting Room 1
        //        Given an array of meeting time intervals consisting of start and end times[[s1, e1],[s2, e2],...] (si<ei), determine if a person could attend all meetings.
        //For example,
        //Given[[0, 30],[5, 10],[15, 20]],
        //return false.
        //the idea is: first sort the intervals according to the start times, then check if there is any overlap.


        //Meeting Room 2
        //Given an array of meeting time intervals consisting of start and end times[[s1, e1],[s2, e2],...] (si<ei), 
        //find the minimum number of conference rooms required.
        //For example,
        //Given[[0, 30],[5, 10],[15, 20]],
        //return 2.
        //http://buttercola.blogspot.com/2014/11/facebook-maximum-number-of-overlapping.html
        //Hint: Keep start times end times in two arrays sort them 


        #endregion

        //Are two strings isomorphic ??
        public static bool AreIsomorphic(string s, string t)
        {
            if (s.Length == 0 && t.Length == 0) return true;
            if (s.Length != t.Length) return false;
            Dictionary<char, char> Map = new Dictionary<char, char>();
            Dictionary<char, char> Map1 = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char key = s[i];
                char val = t[i];
                if (Map.ContainsKey(key))
                {
                    if (val != Map[key]) return false;

                }
                else
                {

                    if (Map1.ContainsKey(val))
                    {
                        char c1 = Map1[val];
                        if (c1 != key) return false;
                    }
                    Map.Add(key, val);
                    Map1.Add(val, key);
                }
            }

            return true;
        }

        //flood fill algo
        public static void FloodFill(ref int[,] Screen, int x, int y, int newColor)
        {
            int m = Screen.GetLength(0) - 1;
            int n = Screen.GetLength(1) - 1;

            if (AreValidInputs(x, y, m, n) == false) return;

            int oldColor = Screen[x, y];
            if (oldColor == newColor) return;
            FloodFill(ref Screen, m, n, oldColor, x, y, newColor);

        }
        public static void FloodFill(ref int[,] Screen, int m, int n, int oldCOlor, int x, int y, int newColor)
        {
            if (AreValidInputs(x, y, m, n) && Screen[x, y] == oldCOlor)
            {
                Screen[x, y] = newColor;
                FloodFill(ref Screen, m, n, oldCOlor, x - 1, y, newColor);
                FloodFill(ref Screen, m, n, oldCOlor, x - 1, y, newColor);
                FloodFill(ref Screen, m, n, oldCOlor, x - 1, y, newColor);
                FloodFill(ref Screen, m, n, oldCOlor, x - 1, y, newColor);
            }
        }
        public static bool AreValidInputs(int x, int y, int m, int n)
        {
            if (x < 0 || x > m) return false;
            if (y < 0 || y > n) return false;
            return true;
        }

        //Islands 
        public static int NumIslands(char[,] grid)
        {

            int m = grid.GetLength(0);
            int n = grid.GetLength(1);
            if (m == 0 && n == 0) return 0;
            bool[,] IsVisited = new bool[m, n];

            for (int a = 0; a < m; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    IsVisited[a, b] = false;
                }
            }

            m--;
            n--;
            int num = 0;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (IsVisited[i, j] == false)
                    {
                        if (grid[i, j] == 0)
                        {
                            IsVisited[i, j] = true;
                        }
                        else
                        {
                            num++;
                            DFSVisit(grid, i, j, ref IsVisited, m, n);
                        }
                    }
                }
            }

            return num;

        }
        public static void DFSVisit(char[,] grid, int x, int y, ref bool[,] IsVisited, int m, int n)
        {

            IsVisited[x, y] = true;
            if (IsValid(x - 1, y, m, n) == true && IsVisited[x - 1, y] == false && grid[x - 1, y] == 1) DFSVisit(grid, x - 1, y, ref IsVisited, m, n);
            if (IsValid(x, y - 1, m, n) == true && IsVisited[x, y - 1] == false && grid[x, y - 1] == 1) DFSVisit(grid, x, y - 1, ref IsVisited, m, n);
            if (IsValid(x, y + 1, m, n) == true && IsVisited[x, y + 1] == false && grid[x, y + 1] == 1) DFSVisit(grid, x, y + 1, ref IsVisited, m, n);
            if (IsValid(x + 1, y, m, n) == true && IsVisited[x + 1, y] == false && grid[x + 1, y] == 1) DFSVisit(grid, x + 1, y, ref IsVisited, m, n);
        }
        public static bool IsValid(int x, int y, int m, int n)
        {
            if (x < 0 || x > m) return false;
            if (y < 0 || y > n) return false;
            return true;
        }

        #region N Queen

        //N Queen Problem
        //https://www.youtube.com/watch?v=JkP-xats3no
        //called as follows:
        // if(solveQueen(Board,0,4)) { PrintBoard(Board); }

        public static bool SolveQueen(int[,] Board, int col, int N)
        {
            if (col >= N)
            {
                return true;
            }
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                if (canPutQueenAt(Board, i, col))
                {
                    Board[i, col] = 1;
                    if (SolveQueen(Board, col + 1, N))
                    {
                        return true;
                    }
                    Board[i, col] = 0;
                }
            }
            return false;
        }
        public static bool canPutQueenAt(int[,] Board, int row, int col)
        {
            int i = 0;
            for (i = 0; i < col; i++)
            {
                if (Board[row, i] == 1) return false;
            }

            int j = 0;
            j = col;
            i = row;
            for (; j >= 0 && i >= 0; j--, i--)
            {
                if (Board[i, j] == 1) return false;
            }

            j = col;
            i = row;

            for (; j >= 0 && i < col; j--, i++)
            {
                if (Board[i, j] == 1) return false;
            }
            return true;


        }
        public static void PrintBoard(int[,] Board)
        {
            int m = Board.GetLength(0);
            int n = Board.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Board[i, j] == 1)
                    {
                        Console.Write(" Q");
                    }
                    else
                    {
                        Console.Write(" -");
                    }
                }
                Console.WriteLine();
            }
        }

        #endregion

        //travelling salesman
        //http://www.geeksforgeeks.org/travelling-salesman-problem-set-2-approximate-using-mst/
        //http://www.csd.uoc.gr/~hy583/papers/ch11.pdf
        //        1.select a “root” vertex r ∈ V[G].
        //2.use MST-Prim(G, c, r) to compute a minimum spanning tree from r.
        //3.assume L to be the sequence of vertices visited in a preorder tree walk of T.
        //4.return the Hamiltonian cycle H that visits the vertices in the order L.
        public static void TravellingSalesman()
        {

        }

        //Producer-Consumer Problem - Important in multi threading - Also called as Bounded-Buffer problem
        //http://www.dcs.ed.ac.uk/home/adamd/essays/ex1.html single vs mutiple producer-consumer problem
        //https://www.cs.mtu.edu/~shene/NSF-3/e-Book/SEMA/VISUAL/VISUAL-sema-buffer.html
        //Related KeyWords = semaphore, threads, concurrent system, operating systems
        public static void ProducerConsumer()
        {

        }

        //Max flow and min cost flow

        //Vehicle Routing Problem

        //Job Shop problem


        //Given a collection of candidate numbers(C) and a target number(T), find all unique combinations in C where the candidate numbers sums to T.
        //Each number in C may only be used once in the combination.
        //Note:
        //All numbers (including target) will be positive integers.
        //The solution set must not contain duplicate combinations.
        //For example, given candidate set[10, 1, 2, 7, 6, 1, 5] and target 8,
        //A solution set is: 
        //[
        //  [1, 7],
        //  [1, 2, 5],
        //  [2, 6],
        //  [1, 1, 6]
        //]
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            //Array.Sort(candidates);
            return null;
        }
        public static void Helper(int[] Candidates, int index, int target, ref List<List<int>> res, List<int> curSet)
        {
            if (target == 0)
            {
                res.Add(curSet);
                return;
            }
            if (target < 0)
            {
                return;
            }

            int prev = -1;
            for (int i = index; i < Candidates.Length; i++)
            {
                if (Candidates[i] != prev)
                {
                    curSet.Add(Candidates[i]);
                    Helper(Candidates, index + 1, target - Candidates[i], ref res, curSet);
                    prev = Candidates[i];

                }
            }



        }

        //put even numbers in even indexes and odd numbers in odd indexes
        //http://thenoisychannel.com/2011/08/08/retiring-a-great-interview-problem

        #region WordBreak 1

        //word break
        //this returns true if you can split the given string in to two words given in a dicctionalry
        public static bool CanBreakWord(string s, HashSet<string> Dict)
        {
            for (int i = 1; i < s.Length; i++)
            {
                string prefix = s.Substring(0, i + 1);
                if (Dict.Contains(prefix))
                {
                    string suffix = s.Substring(i + 1, s.Length - i - 1);
                    if (Dict.Contains(suffix))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        //this returns true if you can split the given string in more than one word with the given dictionary
        //complexity O(2^n)
        public static bool CanBreakIntoMultipleWords(string s, HashSet<string> Dict)
        {
            if (Dict.Contains(s)) return true;

            for (int i = 1; i < s.Length; i++)
            {
                string prefix = s.Substring(0, i);
                if (Dict.Contains(prefix))
                {
                    string suffix = s.Substring(i, s.Length - 1 - i);
                    if (CanBreakIntoMultipleWords(suffix, Dict)) return true;
                }
            }

            return false;
        }

        //better way of  above problem using dynamic programming O(n^2)
        public static bool WordBreak(string s, ISet<string> wordDict)
        {
            return Break(s, wordDict, new HashSet<string>());
        }

        private static bool Break(string s, ISet<string> dict, HashSet<string> dp)
        {
            if (dict.Contains(s) || dp.Contains(s))
            {
                return true;
            }

            for (int i = 1; i < s.Length; i++)
            {
                string prefix = s.Substring(0, i);
                if (dict.Contains(prefix))
                {
                    string suffix = s.Substring(i, s.Length - i);
                    if (Break(suffix, dict, dp))
                    {
                        dp.Add(suffix);
                        return true;
                    }
                }
            }

            return false;
        }

        #endregion

        public static void test()
        {
            bool[,] isvis = new bool[2, 3];
            HashSet<string> s = new HashSet<string>();
            List<string> l = s.ToList<string>();
            Console.WriteLine("{0}  {1}", isvis.GetLength(0), isvis.GetLength(1));

        }

        #region Word Ladder 2
        //        Given two words(beginWord and endWord), and a dictionary's word list, find all shortest transformation sequence(s) from beginWord to endWord, such that:

        //Only one letter can be changed at a time
        //Each intermediate word must exist in the word list
        //For example,

        //Given:
        //beginWord = "hit"
        //endWord = "cog"
        //wordList = ["hot","dot","dog","lot","log"]
        #endregion

        //Word Search 2
        //Given a 2D board and a list of words from the dictionary, find all words in the board.
        //Each word must be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring.The same letter cell may not be used more than once in a word.
        //For example,
        //Given words = ["oath", "pea", "eat", "rain"] and board =
        //[
        //  ['o', 'a', 'a', 'n'],
        //  ['e','t','a','e'],
        //  ['i','h','k','r'],
        //  ['i','f','l','v']
        //]
        //Return["eat", "oath"].    
        public IList<string> FindWords(char[,] board, string[] words)
        {
            //see leetcode
            return null;
        }

        //http://www.allenlipeng47.com/blog/index.php/2016/03/15/palindrome-pairs/


        //print all factors 
        //
        private static void PrintFactors(int n, string curString)
        {


        }
        private static void PrintFactorsHelper(string currenExpression, int dividend, int prevFactor)
        {
            for (int factor = dividend - 1; factor >= 2; factor--)
            {
                if (dividend % factor == 0 && factor <= prevFactor)
                {

                }
            }
        }

        //1-D closest pair distance
        //given n points on one horizontal line ,find the closest pair points (1-D 1 dimensional)
        //since all points have same y we consider single dimension array whihc will represent the 
        //x coordinated of n points
        //see https://www.cs.ucsb.edu/~suri/cs235/ClosestPair.pdf
        private static int ClosesPairDistance(int[] N)
        {
            Array.Sort(N);
            return ClosesPair_Distance_Aux(N, 0, N.Length - 1);
        }
        private static int ClosesPair_Distance_Aux(int[] N, int p, int q)
        {
            if (p == q) return int.MaxValue; //return infinity
            if (p == q - 1)
            {
                return Math.Abs(N[p] - N[q]);
            }

            int mid = p + (q - p) / 2;
            int leftd = ClosesPair_Distance_Aux(N, p, mid);
            int rightd = ClosesPair_Distance_Aux(N, mid + 1, q);
            int mind = Math.Min(leftd, rightd);
            int x = Math.Min(Math.Abs(N[mid] - N[mid + 1]), Math.Abs(N[mid] - N[mid - 1]));

            return Math.Min(x, mind);
        }

        //closes pair given n pairs on a plane (2-D)
        //see https://www.cs.ucsb.edu/~suri/cs235/ClosestPair.pdf
        public static bool CompareX(Point a, Point b)
        {
            if (a.x < b.x) return true;
            return false;

        }
        public static bool CompareY(Point a, Point b)
        {
            if (a.y < b.y) return true;
            return false;
        }
        public static double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        }

        public static double ClosestPairIn2D(Point[] P)
        {
            if (P.Length == 1) return int.MaxValue;
            if (P.Length == 2) return Distance(P[0], P[1]);

            Point[] Px = new Point[P.Length];
            Array.Copy(P, Px, P.Length);

            Point[] Py = new Point[P.Length];
            Array.Copy(P, Py, P.Length);

            return 1.0;



        }
        public static double ClosesPair2D_Aux(Point[] Px, int xp, int xq, Point[] Py)
        {
            if (xq - xp + 1 <= 3)
            {
                return BruteForceClosestPair(Px, xp, xq);
            }

            int mid = xp + (xq - xp) / 2;
            double leftMin = ClosesPair2D_Aux(Px, xp, mid, Py);
            double rightMin = ClosesPair2D_Aux(Px, mid + 1, xq, Py);
            double delta = Math.Min(leftMin, rightMin);
            return 1.0;
        }
        public static double BruteForceClosestPair(Point[] A, int p, int q)
        {
            double totatMin = int.MaxValue;

            for (int i = p; i <= q; i++)
            {
                double curMin = int.MaxValue;
                for (int j = p; j <= q; j++)
                {
                    if (j != i)
                    {
                        double curDist = Distance(A[i], A[j]);
                        if (curDist < curMin)
                        {
                            curMin = curDist;

                        }
                    }
                }
                if (curMin < totatMin)
                {
                    totatMin = curMin;
                }
            }
            return totatMin;
        }

        public static void EvenOddIndexSeparation(ref int[] A)
        {

            int len = A.Length;
            if (len < 2) return;

            int evenIndex = 0;
            int oddIndex = 1;

            while (evenIndex < len && oddIndex < len)
            {
                while (evenIndex < len && A[evenIndex] % 2 == 0)
                {
                    evenIndex += 2;
                }
                while (oddIndex < len && A[oddIndex] % 2 != 0)
                {
                    oddIndex += 2;
                }
                if (evenIndex >= len || oddIndex >= len)
                {
                    return;
                }
                else {
                    int t = A[evenIndex];
                    A[evenIndex] = A[oddIndex];
                    A[oddIndex] = t;
                }
            }

        }

        public static void ReverseWords(StringBuilder sb, int p, int q)
        {
            int i = p - 1;
            int j = p;

            while (j < sb.Length && i < sb.Length)
            {
                while (j < sb.Length && sb[j] != ' ')
                {
                    j++;
                }

                if (j == sb.Length) break;

                ReverseString(ref sb, i + 1, j - i - 1);
                i = j;
                j++;

            }
            ReverseString(ref sb, i + 1, j - i - 1);
            ReverseString(ref sb, 0, sb.Length - 1);
        }
        public static void ReverseString(ref StringBuilder s, int p, int q)
        {
            while (p < q)
            {
                char c = s[p];
                s[p] = s[q];
                s[q] = c;
                p++;
                q--;
            }
        }

        //Iterate through K dimensional array

        //search for pattern - Brute force
        //O(mn)
        public static bool SearchPattern(string s, string p)
        {
            if (p.Length > s.Length) return false;

            for (int i = 0; i < s.Length - p.Length - 2; i++)
            {
                //compare s[i...i+s.Length-1] with p[0....p.Length-1]
                if (AreStringsSame(s, i, i + s.Length - 1, p, 0, p.Length - 1)) return true;
            }
            return false;
        }
        public static bool AreStringsSame(string s, int slow, int shigh, string p, int plow, int phigh)
        {
            int len1 = shigh - slow + 1;
            int len2 = phigh - plow + 1;
            if (len1 != len2) return false;
            while (slow <= shigh && plow <= phigh)
            {
                if (s[slow] != p[plow]) return false;
                slow++;
                plow++;
            }

            return true;
        }

        //Given two sorted arrays find the UNION and intersections of elements in them
        //Hint : Merge from MergeSort


        //find the element whihc occures more than n/2 times 
        //hint bst
        //struct bst
        //{ int n; int count; bst left; bst right; }


        //Longest increasing path in a matrix

        //Count primes less than n

        //

        #endregion

        #region Facebook Practice
        public static void Separate012(ref int[] A)
        {
            int i = -1;
            int j = 0;
            int k = A.Length;

            while (j < k)
            {
                if (A[j] == 0)
                {
                    swap1(ref A, i + 1, j);
                    i++;
                    j++;
                }
                else if (A[j] == 1)
                {
                    j++;
                }
                else
                {
                    swap1(ref A, j, k - 1);
                    k--;
                }
            }
        }
        public static void swap1(ref int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
        #endregion

        #region Amazon Practice
        public static void Separate_012(ref int[] A)
        {
            int i = -1;
            int j = 0;
            int k = A.Length;

            while (j < k)
            {
                if (A[j] == 0)
                {
                    Swap_1(ref A, i + 1, j);
                    i++;
                    j++;
                }
                else if (A[i] == 2)
                {
                    Swap_1(ref A, k - 1, j);
                    k--;
                }
                else {
                    j++;
                }

            }
        }
        public static void Swap_1(ref int[] A, int i, int j)
        {
            int t = A[i];
            A[i] = A[j];
            A[j] = t;
         }

        //course schedule 
        //is it possible to come up with a schedule 
        //[0,1] => 0 needs 1
        public static bool IsSchedulePossible(int n, int[,] prereq)
        {
            if (n == 0) return true;
            Dictionary<int, List<int>> Map = new Dictionary<int, List<int>>();
            BuildGraph(ref Map, prereq);

            int[] color = new int[n];
            //0 - white 1-grey 2 - black

            for (int i = 0; i < n; i++)
            {
                if (color[i] == 0)
                {
                    bool hasCycle = Visit(i, Map, ref color);
                    if (hasCycle) return false;
                }
            }

            return true; 
        }

        public static bool Visit(int i,Dictionary<int,List<int>> Map,ref int[] color)
        {
            color[i] = 1;

            List<int> adj = null;
            if (Map.ContainsKey(i))
            {
                adj = Map[i];
            }

            if (adj == null) {
                color[i] = 2;
                return false;
            }

            foreach (int adjacent in adj)
            {
                if(color[adjacent]==0)
                {
                    Visit(adjacent, Map, ref color); 
                }

                if (color[adjacent] == 1)
                {
                    return true;
                }
            }

            color[i] = 2;
            return false;
        }

        public static void BuildGraph(ref Dictionary<int, List<int>> Map, int[,] prereq)
        {
            int m = prereq.GetLength(0);

            for (int i = 0; i < m; i++)
            {
                int b = prereq[i, 0];
                int a = prereq[i, 1];

                //a->b
                if(Map.ContainsKey(a))
                {
                    Map[a].Add(b);
                }
                else {
                    Map.Add(a, new List<int>());
                    Map[a].Add(b);
                }
            }

        }

        #endregion

    }

    public struct Point {
        public int x;
        public int y;
    }

    public struct Range
    {
        public int left;
        public int right;
    }

    public static class Sorting
    {
        //SIBQMBRH


        /// <summary>
        /// Complexity is O(n^2)
        /// </summary>
        /// <param name="A"></param>
        public static void SelectionSort(ref int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[smallest])
                    {
                        smallest = j;
                    }
                }
                InterchangeInArray(ref A, smallest, i);
            }
        }

        public static void InterchangeInArray(ref int[] A, int first, int second)
        {
            int temp = A[first];
            A[first] = A[second];
            A[second] = temp;
        }

        /// <summary>
        /// Best case:   Already Sorted in right order - O(n)
        /// Avg Case:    O(n^2)
        /// Worst Case:  O(n^2) Reveresly sorted
        /// </summary>
        /// <param name="A"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public static void InsertionSort(ref int[] A, int p, int q)
        {
            for (int i = p + 1; i <= q; i++)
            {
                int j = i - 1;
                int k = A[i];
                while (j >= 0 && A[j] > k)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = k;
            }
        }

        /// <summary>
        /// https://www.khanacademy.org/computing/computer-science/algorithms/quick-sort/a/analysis-of-quicksort
        /// Best Case:   O(nlogn)
        /// Avg Case:    O(nlogn) 
        /// Worst Case:  O(n^2)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
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
            int pivot = A[q];
            int i = p;
            int j = i - 1;

            while (i < q)
            {
                if (A[i] <= pivot)
                {
                    InterchangeInArray(ref A, j + 1, i);
                    j++;
                }
                i++;
            }
            A[q] = A[j + 1];
            A[j + 1] = pivot;
            return j + 1;
        }

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
            int l1 = r - p + 1;
            int l2 = q - r;
            int[] left = new int[l1];
            int[] right = new int[l2];

            for (int i1 = 0; i1 < l1; i1++)
            {
                left[i1] = A[p + i1];
            }

            for (int j1 = 0; j1 < l2; j1++)
            {
                right[j1] = A[r + 1 + j1];
            }

            int i = 0;
            int j = 0;
            int k = p;
            while (i < l1 && j < l2)
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

            while (i < l1)
            {
                A[k] = left[i];
                i++;
                k++;
            }

            while (j < l2)
            {
                A[k] = right[j];
                j++;
                k++;
            }

        }

        public static void CountingSort(ref int[] A)
        {
            int[] c = new int[10];

            for (int i = 0; i < A.Length; i++)
            {
                c[A[i]]++;
            }

            for (int i = 1; i < c.Length; i++)
            {
                c[i] = c[i - 1] + c[i];
            }

            for (int i = c.Length - 1; i >= 0; i--)
            {
                while (c[i] > 0)
                {
                    A[c[i] - 1] = i;
                    c[i]--;
                }
            }

        }

        public static void ShellSort(ref int[] A)
        {
            int k = A.Length / 2;
            while (k > 0)
            {
                for (int i = 0; (i + k) < A.Length; i++)
                {
                    if (A[i] > A[i + k])
                    {
                        int n = A[i];
                        A[i] = A[i + k];
                        A[i + k] = n;
                    }
                }
                k--;
            }
        }

        //HeapSort See Heap.

        //IsAnyNumberRepeated
        //FOur methods
        //1 - O(n^2) brute force search
        //2 - O(nlogn) sorting
        //3 - O(n) Hash O(n) Memory too
        //4 - O(n) - Only if numbers in array are in range of (0,n)
        /// <summary>
        /// O(n^2) in all cases 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="lowIndex"></param>
        /// <param name="highIndex"></param>
        /// <returns></returns>
        public static bool? IsAnyNumberRepeated(int[] A, int lowIndex, int highIndex)
        {
            if (lowIndex > highIndex) return null;
            if (lowIndex < 0 || highIndex >= A.Length) return null;

            for (int i = lowIndex; i < highIndex; i++)
            {
                for (int j = i + 1; j <= highIndex; j++)
                {
                    if (A[i] == A[j]) return true;
                }
            }

            return false;
        }

        /// <summary>
        /// O(nLogn)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="lowIndex"></param>
        /// <param name="highIndex"></param>
        /// <returns></returns>
        public static bool? IsAnyNumberRepeated1(int[] A, int lowIndex, int highIndex)
        {
            if (highIndex < lowIndex) return null;
            if (lowIndex < 0 || highIndex >= A.Length) return null;

            QuickSort(ref A, lowIndex, highIndex);

            for (int i = lowIndex; i < highIndex; i++)
            {
                if (A[i] == A[i + 1]) return true;
            }

            return false;
        }

        public static bool? IsAnyNumberRepeated2(int[] A, int lowIndex, int highIndex)
        {
            if (highIndex < lowIndex) return null;
            if (lowIndex < 0 || highIndex >= A.Length) return null;

            Dictionary<int, bool> d = new Dictionary<int, bool>();

            for (int i = lowIndex; i <= highIndex; i++)
            {
                if (d.ContainsKey(A[i])) return true;
                d.Add(A[i], true);
            }

            return false;
        }

        public static bool? IsAnyNumberRepeated3(int[] A)
        {
            int n = A.Length;
            for (int i = 0; i < n; i++)
            {
                int temp = Math.Abs(A[i]);
                if (temp <= 0 || temp >= n) return null; //Meaning invalid input for this algorithm.
                if (A[temp] < 0) return true;
                A[temp] = A[temp] * (-1);
            }

            return false;
        }

        //A[0----n-1] represent votes of n people , tell who won
        //which number repeated maximum number of times is another way to put this question
        //O(n^2)
        public static int MaxRepeatedNumber1(int[] A)
        {

            int maxCount = 0;
            int maxCountNumber = -1;
            for (int i = 0; i < A.Length - 1; i++)
            {
                int currentNum = A[i];
                int currentCount = 1;
                for (int j = i + 1; j <= A.Length - 1; j++)
                {
                    if (A[j] == currentNum) currentCount++;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxCountNumber = i;
                }
            }

            if (maxCountNumber != -1) return A[maxCountNumber];
            return maxCountNumber;
        }

        //O(nlogn)
        public static int? MaxRepeatedNumber2(int[] A)
        {
            return null;
        }

        public static int? MaxRepeatedNumber3(int[] A)
        {
            if (A.Length == 0) return null;
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (d.ContainsKey(A[i]))
                {
                    d[A[i]]++;
                }
                else
                {
                    d.Add(A[i], 1);
                }
            }
            //find the key with max value.
            int maxKey = d.FirstOrDefault(x => x.Value == d.Values.Max()).Key;
            return maxKey;
        }

        //all numbers in array should be in rage [0,n)
        public static int? MaxRepeatedNumber4(int[] A)
        {
            if (A.Length == 0) return null;
            int len = A.Length;
            for (int i = 0; i < A.Length; i++)
            {
                int n = A[i] % len;
                A[n] = A[n] + len;
            }

            int maxTimes = 0;
            int maxNum = -1;
            for (int i = 0; i < A.Length; i++)
            {
                int q = A[i] / len;
                int r = A[i] % len;
                if (q > maxTimes)
                {
                    maxTimes = q;
                    maxNum = r;
                }
            }

            return maxNum;
        }

        //a+b=k a,b belong to arrays A and B respectively
        //O(nLog n)
        public static bool IsThereAplusBequalsK(int[] A, int[] B, int k)
        {
            QuickSort(ref A, 0, A.Length - 1);

            foreach (int b in B)
            {
                if (BinarySearch(A, 0, A.Length - 1, (k - b)))
                {
                    return true;
                }
            }

            return false;

        }


        //test cases for binary search
        public static void TestBinarySearch()
        {
            //Console.WriteLine("Expected - Actual");
            //Console.WriteLine("{0} - {1}",false, bt(new int[] { 1,2,3,4,5},0));
            //Console.WriteLine("{0} - {1}", false, bt(new int[] { 1, 2, 3, 4, 5 }, 6));
            //Console.WriteLine("{0} - {1}", false, bt(new int[] { 1, 2, 3, 4, 5 }, 3));
            //Console.WriteLine("{0} - {1}", false, bt(new int[] { 1, 2, 3, 4, 5 }, 2));
        }

        public static bool bt(int[] A, int k)
        {
            return BinarySearch(A, 0, A.Length - 1, k);
        }

        //O(log n)
        public static bool BinarySearch(int[] A, int p, int q, int k)
        {
            if (p <= q)
            {
                int mid = p + (q - p) / 2;
                if (A[mid] == k) return true;
                if (A[mid] < k) return BinarySearch(A, p, mid - 1, k);
                return BinarySearch(A, mid + 1, q, k);
            }
            return false;
        }

        //a+b+c=k
        //(n^2 Log n)
        public static bool IsThereAplusBplusCequalsK(int[] A, int[] B, int[] C, int k)
        {
            foreach (int a in A)
            {
                if (IsThereAplusBequalsK(B, C, (k - a)))
                {
                    return true;
                }
            }

            return false;
        }

        //Merge K sorted lists
        //O(nk)
        // where n is total number while k is size of each list.
        public static List<int> MergeKLists(List<List<int>> l)
        {
            if (l.Count == 0) return null;
            if (l.Count == 1) return l[0];
            int n = l.Count;

            List<int> first = l[n - 1];
            List<int> second = l[n - 2];

            l.RemoveAt(n - 1);
            l[n - 2] = Merge2Lists(first, second);

            return MergeKLists(l);
  
        }
        public static List<int> Merge2Lists(List<int> first, List<int> second)
        {
            if (first == null && second == null) return null;
            if (first == null) return second;
            if (second == null) return first;
             
            List<int> result = new List<int>();

            int i = 0; //first
            int j = 0; //second
            //int k = 0; //result 

            
            while (i < first.Count && j < second.Count)
            {
                if (first[i] <= second[j])
                {
                    result.Add(first[i]);
                    i++;
                }
                else
                {
                    result.Add(second[j]);
                    j++;
                }
            }

            while (i < first.Count)
            {
                result.Add(first[i]);
                i++;
            }

            while (j < second.Count)
            {
                result.Add(second[j]);
                j++;
            }

            return result;
        }

        //MErge K lists (linked lists) which are already sorted 
        //Solved in leetcode
            //public MyLinkedListNode MergeKLists(ListNode[] lists)
            //{
            //    if (lists == null) return null;
            //    if (lists.Length == 0) return null;
            //    if (lists.Length == 1) return lists[0];
            //    return MergeKLists1(lists, lists.Length);
            //}

            //public ListNode MergeKLists1(ListNode[] lists, int n)
            //{
            //    if (lists == null) return null;
            //    if (n == 0) return null;
            //    if (n == 1) return lists[0];

            //    ListNode result = Merge2Lists(lists[n - 1], lists[n - 2]);
            //    lists[n - 1] = null;
            //    lists[n - 2] = result;

            //    return MergeKLists1(lists, n - 1);
            //}
            //public ListNode Merge2Lists(ListNode first, ListNode second)
            //{
            //    if (first == null) return second;
            //    if (second == null) return first;

            //    ListNode result = null;
            //    ListNode resultTail = null;
            //    ListNode temp = null;

            //    while (first != null && second != null)
            //    {
            //        if (first.val <= second.val)
            //        {
            //            temp = first;
            //            first = first.next;
            //            temp.next = null;
            //        }
            //        else
            //        {
            //            temp = second;
            //            second = second.next;
            //            temp.next = null;

            //        }
            //        Insert(ref result, ref resultTail, ref temp);
            //    }

            //    while (first != null)
            //    {
            //        temp = first;
            //        first = first.next;
            //        temp.next = null;
            //        Insert(ref result, ref resultTail, ref temp);
            //    }

            //    while (second != null)
            //    {

            //        temp = second;
            //        second = second.next;
            //        temp.next = null;
            //        Insert(ref result, ref resultTail, ref temp);
            //    }

            //    return result;

            //}

            //public void Insert(ref ListNode result, ref ListNode resultTail, ref ListNode temp)
            //{
            //    if (result == null && resultTail == null)
            //    {
            //        result = temp;
            //        resultTail = temp;
            //    }
            //    else
            //    {
            //        resultTail.next = temp;
            //        resultTail = resultTail.next;
            //    }

            //}


    }

    public static class Searching {

        /// <summary>
        /// Brute force O(n^2)
        /// </summary>
        public static bool IsDUplicatePresent1(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int n = A[i];
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (n == A[j]) return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Using sort -  O(n^2)
        /// </summary>
        public static bool IsDuplicatePresent2(int[] A)
        {
            Sorting.QuickSort(ref A, 0, A.Length - 1);
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i - 1] == A[i]) return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool IsDuplicatePresent3(int[] A)
        {
            Dictionary<int, bool> d = new Dictionary<int, bool>();
            for (int i = 0; i < A.Length; i++)
            {
                if (d.ContainsKey(A[i]))
                {
                    return true;
                }
                else
                {
                    d.Add(A[i], true);
                }
            }

            return false;
        }

        /// <summary>
        /// negation technique
        /// n >0 && n <=A.length-1
        /// </summary>
        public static bool IsDupllicatePresent4(int[] A)
        {
            foreach (int n in A)
            {
                if (A[Math.Abs(n)] < 0) return false;
                else {
                    A[Math.Abs(n)] = A[Math.Abs(n)] * (-1);
                }
            }
            return false;

        }

        /// <summary>
        /// Brute force - O(n^2)
        /// </summary>
        public static int MostRepeatedNum1(int[] A)
        {
            int MaxCount = 0;
            int MaxNum = -1;
            for (int i = 0; i < A.Length - 1; i++)
            {
                int count = 1;
                int n = A[i];

                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] == n) count++;
                }

                if (count > MaxCount)
                {
                    MaxCount = count;
                    MaxNum = n;
                }
            }

            return MaxNum;
        }

        /// <summary>
        /// O(n)
        /// mem - O(k) where k is the number values that can occur in a given place of array
        /// </summary>
        public static int MostRepeatedNum2(int[] A)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            foreach (int n in A)
            {
                if (d.ContainsKey(n))
                {
                    d[n]++;

                }
                else
                {
                    d.Add(n, 1);
                }
            }

            int keywithmaxval = d.FirstOrDefault(x => x.Value == d.Values.Max()).Key;
            return keywithmaxval;
        }

        /// <summary>
        /// using sorting O(n logn)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MostRepeatedNum3(int[] A)
        {
            Sorting.QuickSort(ref A, 0, A.Length - 1);

            int maxCount = 0;
            int maxNum = -1;

            int i = 0;
            int n = A[i];
            int currCount = 1;

            while (i < A.Length - 1)
            {
                if (A[i + 1] == n)
                {
                    currCount++;
                    i++;
                }
                else
                {
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                        maxNum = n;
                    }
                    i++;
                    n = A[i];
                }
            }

            return maxNum;
        }

        /// <summary>
        /// negation thnique 
        /// valid incase if  n E [0,A.length-1]
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int? MostRepeatedNum4(int[] A)
        {
            int len = A.Length;
            if (len == 0) return null;

            for (int i = 0; i < A.Length; i++)
            {
                int n = (A[i]) % len;
                if (n < 0 || n >= A.Length) return null; //Implies invalid data
                A[n] = A[n] + len;
            }

            int max = 0;
            int maxnum = -1;
            for (int i = 0; i < A.Length; i++)
            {
                int cur = (A[i] / len);
                if (cur > max)
                {
                    max = cur;
                    maxnum = i;
                }
            }

            return maxnum;
        }

        /// <summary>
        /// First Repeating number - brute force
        /// </summary>
        public static int FirstRepeatingNum1(int[] A)
        {
            return 0;
        }

        /// <summary>
        /// Run - O(n + k)
        /// Mem - O(k)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int FirstRepeatingNum2(int[] A)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (d.ContainsKey(A[i]))
                {
                    if (d[A[i]] > 0)
                    {
                        d[A[i]] = d[A[i]] * (-1);
                    }

                }
                else
                {
                    d.Add(A[i], (i + 1));
                }
            }

            int val = -999;
            foreach (int key in d.Keys)
            {
                if (d[key] < 0 && d[key] > val)
                {
                    val = d[key];
                }
            }

            return A[Math.Abs(val) - 1];

        }

        /// <summary>
        /// O(n) - based on formula
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int FindMissingNum1(int[] A)
        {
            int n = A.Length + 1;
            int sum = 0;
            foreach (int i in A)
            {
                sum += i;
            }

            int actualSum = n * (n + 1) / 2;
            return actualSum - sum;
        }

        /// <summary>
        /// O(n) XOR technique
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int FindMissingNum2(int[] A)
        {
            int n = A.Length + 1;
            int allXor = 0;
            int currentXor = 0;
            foreach (int i in A)
            {
                allXor ^= i;
            }
            for (int i = 1; i <= n; i++)
            {
                currentXor ^= i;
            }
            return currentXor ^ allXor;
        }

        //n+2 two are repeated twice find them
        public static void FindTheRepeatingTwo(int[] A)
        {
            int n = A.Length - 2;
            if (n <= 0) return;

            int XorY = 0;
            for (int i = 1; i <= n; i++)
            {
                XorY = XorY ^ i;
            }

            foreach (int k in A)
            {
                XorY ^= k;
            }

            int rightOne = (~(XorY - 1)) & XorY;
            int withOnes = 0;

            foreach (int k in A)
            {
                if ((rightOne & k) != 0) withOnes ^= k;
            }

            int x = withOnes;
            int y = withOnes ^ XorY;

            Console.WriteLine("{0} {1}", x, y);

        }

        //in an array all elements come thrice except for one whihc comes only once, find 
        //that number
        public static int FindOnceInThriceArray(int[] A)
        {
            int first = 0;
            int second = 0;
            
            for (int i = 0; i < A.Length; i++)
            {
                second = second | (first & A[i]);
                first = first ^ A[i];
             
                int mask = first & second;
                mask = ~mask;

                first = first & (mask);
                second = second & (mask);
            }

            return first;
        }

        //a+b ~ 0
        //input is sorted array
        public static int SumClosesToZero(int[] A, int p, int q, int prevsum)
        {
            if (p < q)
            {
                int sum = A[p] + A[q];
                if (sum == 0) return 0;
                else
                {
                    int prevdiff = Math.Abs(prevsum - 0);
                    int currdiff = Math.Abs(sum - 0);
                    if (currdiff < prevdiff)
                    {
                        prevsum = sum;
                    }
                    if (sum < 0)
                    {
                        return SumClosesToZero(A, p + 1, q, prevsum);
                    }
                    else
                    {
                        return SumClosesToZero(A, p, q - 1, prevsum);
                    }
                }
            }
            return prevsum;
        }

        //a+b+c ~ 0
        //input is sorted array
        public static int ThreeSumClosesToZero(int[] A, int p, int q)
        {
            int prevSum = int.MaxValue;
            for (int i = 0; i < q - 1; i++)
            {
                int sum = SumClosesToZero(A, i + 1, q, int.MaxValue);
                sum = sum + A[i];
                if (sum == 0) return 0;

                if (Math.Abs(sum) < Math.Abs(prevSum)) prevSum = sum;

            }
            return prevSum;
        }
        
        //a +b ~ k
        //sum of two numbers closest to K
        //input is sorted array
        public static int TwoSumClosestToK(int[] A, int p, int q, int k, int prevSum)
        {
            if (p < q)
            {
                int sum = A[p] + A[q];
                if (sum == k)
                {
                    return k;
                }
                else
                {
                    int currDiff = Math.Abs(sum - k);
                    int prevDiff = Math.Abs(prevSum - k);
                    if (currDiff < prevDiff)
                    {
                        prevSum = sum;
                    }

                    if (sum < k)
                    {
                        return TwoSumClosestToK(A, p + 1, q, k, prevSum);
                    }
                    else
                    {
                        return TwoSumClosestToK(A, p, q - 1, k, prevSum);
                    }


                }
            }
            return prevSum;
        }
        
        //a + b + c ~ k
        //sum of three numbers closest to k
        public static int ThreeSumClosestToK(int[] A, int p, int q, int k)
        {
            int prevSum = int.MaxValue;
            for (int i = p; i < q - 1; i++)
            {
                int sum = TwoSumClosestToK(A, i + 1, q, k - A[i], int.MaxValue);
                sum = sum + A[i];

                if (sum == k)
                {
                    return k;
                }

                int curDiff = Math.Abs(sum - k);
                int prevDiff = Math.Abs(prevSum - k);
                if (curDiff < prevDiff)
                {
                    prevSum = sum;
                }
            }
            return prevSum;
        }

        /// <summary>
        /// A[i] + A[j] = k --> Sorting method
        /// </summary>
        public static void FindTwoWhoseSumIsK(int[] A, int p, int q, int k)
        {
            Sorting.QuickSort(ref A, 0, A.Length - 1);
            int x = -99;
            int y = -99;
            bool res = __FindTwoWhoseSumIsK(A, 0, A.Length - 1, k, out x, out y);
        }

        public static bool __FindTwoWhoseSumIsK(int[] A, int p, int q, int k, out int one, out int two)
        {
            if (p < q)
            {
                int s = A[p] + A[q];
                if (s == k)
                {
                    //Console.WriteLine("{0} {1}",A[p],A[q]);
                    one = A[p];
                    two = A[q];
                    return true;

                }
                else if (s < k)
                {
                    return __FindTwoWhoseSumIsK(A, p + 1, q, k, out one, out two);
                }
                else
                {
                    return __FindTwoWhoseSumIsK(A, p, q - 1, k, out one, out two);
                }
            }
            one = -99;
            two = -99;
            return false;
        }

        /// <summary>
        /// A[i] + A[j] = k -> hashing method
        /// </summary>
        public static void FindTwoWhoseSumIsK2(int[] A, int k)
        {
            Dictionary<int, bool> hash = new Dictionary<int, bool>();
            foreach (int n in A)
            {
                if (hash.ContainsKey(k - n))
                {
                    Console.WriteLine("{0} + {1} = {2}", n, (k - n), k);
                    return;
                }
                else
                {
                    if (!hash.ContainsKey(n))
                    {
                        hash.Add(n, true);
                    }
                }
            }
        }

        /// <summary>C:\Users\sindamnataraj\Documents\Visual Studio 2013\Projects\2016 Practice\2016 Practice\LinkedList.cs
        /// A[i]^2 + A[j]^2 = k^2
        /// </summary>
        public static void FindTwoWhoseSquareSumIsK(int[] A, int k)
        {
            //square each number and use the sorting 
            for (int i = 0; i < A.Length; i++)
            {
                A[i] *= A[i];
            }
            FindTwoWhoseSumIsK(A, 0, A.Length - 1, (k * k));
        }


        //given an array find sum closest to zero
        //array has both negative and positive numbers
        // O(n Log n)
        public static void SumClosestToZero(int[] A)
        {
            Sorting.QuickSort(ref A, 0, A.Length - 1);
            int sum = 0;
            int p = -1;
            int q = -1;
            __SumClosestToZero(A, 0, A.Length - 1, out sum, out p, out q);
            Console.WriteLine("{0} + {1} = {2}", A[p], A[q], sum);
        }

        public static void __SumClosestToZero(int[] A, int p, int q, out int finalsum, out int finalp, out int finalq)
        {
            int low = p;
            int high = q;
            finalsum = int.MaxValue;
            finalp = -1;
            finalq = -1;


            while (low < high)
            {
                int sum = A[low] + A[high];
                if (sum == 0)
                {
                    //Console.WriteLine("closest is 0");
                    finalsum = 0;
                    finalp = low;
                    finalq = high;
                    return;
                }
                else
                {
                    if (Math.Abs(sum) < finalsum)
                    {
                        finalsum = Math.Abs(sum);
                        finalp = low;
                        finalq = high;
                    }

                    if (sum < 0)
                    {
                        low++;
                    }
                    else
                    {
                        high--;
                    }
                }
            }

            //Console.WriteLine("{0} + {1} = {2}", A[finalp], A[finalq], finalsum);

        }


        //x +y +z = k
        //given and array and K find three numbers in array whose sum is k
        public static void FindThreeSumIsK(int[] A, int k)
        {
            Sorting.QuickSort(ref A, 0, A.Length - 1);
            int x = 0;
            int y = 0;

            for (int i = 0; i < A.Length - 2; i++)
            {
                if (__FindTwoWhoseSumIsK(A, i + 1, A.Length - 1, (k - A[i]), out x, out y))
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", A[i], x, y, k);
                }
            }
        }
        
        //sum of three closest to zero
        public static void SumThreeClosestToZero(int[] A)
        {
            Sorting.QuickSort(ref A, 0, A.Length - 1);
            int superFinal = int.MaxValue;
            int finalsum = -999;
            int x = 0;
            int y = 0;
            for (int i = 0; i < A.Length - 2; i++)
            {
                __SumClosestToZero(A, i + 1, A.Length - 1, out finalsum, out x, out y);
                if (finalsum + A[i] == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", A[i], A[x], A[y], finalsum + A[i]);
                    return;
                }
                else {
                    if (Math.Abs(finalsum + A[i]) < superFinal)
                    {
                        superFinal = finalsum;
                    }
                }
            }

            Console.WriteLine(superFinal);
        }

        //find K such that A[0]..A[k] is increasing sequence and A[k]...A[n] is decreasing sequence
        public static int? FindPivotK(int[] A, int p, int q)
        {
            if (p <= q)
            {
                if (p == q)
                {
                    return p;
                }
                else if (p == (q - 1))
                {
                    if (A[p] > A[q])
                    {
                        return p;
                    }
                    else
                    {
                        return q;
                    }
                }
                else
                {
                    int mid = p + (q - p) / 2;
                    if (A[mid] > A[mid + 1] && A[mid] > A[mid - 1])
                    {
                        return mid;
                    }
                    else if (A[mid] < A[mid + 1] && A[mid] > A[mid - 1])
                    {
                        return FindPivotK(A, mid + 1, q);
                    }
                    else
                    {
                        return FindPivotK(A, p, mid - 1);
                    }

                }
            }
            return null;

        }
        
        //find right most 1 in 111111111111111111000000000000000000
        public static int FindRightMost1(int[] A, int p, int q)
        {
            if (p == q)
            {
                if (A[p] == 1) return p;
                return -1;
            }
            if (p == q - 1)
            {
                if (A[p] == 0) return -1;
                if (A[q] == 1) return q;
                return p;
            }
            if (p < q)
            {
                int r = p + (q - p) / 2;
                if (A[r] == 1 && A[r + 1] == 0)
                {
                    return r;
                }
                else if (A[r] == 1 && A[r + 1] == 1)
                {
                    return FindRightMost1(A, r + 1, q);
                }
                else
                {
                    return FindRightMost1(A, p, r - 1);
                }
            }
            return -1;
        }
        
        //BInary Search on sorted array = O(log n)
        public static bool BinarySearch(int[] A, int p, int q, int k)
        {
            if (p == q)
            {
                if (A[p] == k) return true;

            }
            if (p < q)
            {
                int r = p + (q - p) / 2;
                if (A[r] == k) return true;
                else if (k < A[r])
                {
                    return BinarySearch(A, p, r - 1, k);
                }
                else
                {
                    return BinarySearch(A, r + 1, q, k);
                }
            }
            return false;
        }

        //given an array sorted unknown times find a given number k
        public static int PivotInRotated(int[] A, int p, int q)
        {
            if (p == q)
            {
                return p;
            }
            if (p == q - 1)
            {
                if (A[p] > A[q]) return p;
                return q;
            }
            if (p < q)
            {
                int mid = p + (q - p) / 2;
                if (A[mid + 1] < A[mid] && A[mid - 1] < A[mid])
                {
                    return mid;
                }
                else if (A[mid + 1] > A[mid] && A[mid - 1] > A[mid])
                {
                    return mid - 1;
                }
                else if (A[p] > A[mid] && A[mid] < A[q])
                {
                    return PivotInRotated(A, p, mid - 1);
                }
                else
                {
                    return PivotInRotated(A, mid + 1, q);
                }
            }

            return -1;
        }


        //search in rotated array
        //O(log n)
        //first find the highest numbers index and then do binary search
        public static bool SearchInRotated(int[] A, int p, int q, int k)
        {
            int pivotIndex = PivotInRotated(A, p, q);
            if (pivotIndex != -1)
            {
                if (k <= A[pivotIndex] && k >= A[p])
                {
                    return BinarySearch(A, p, pivotIndex, k);
                }
                else
                {
                    return BinarySearch(A, pivotIndex, q, k);
                }
            }
            return false;
        }

        //find median of two sorted arrays.
        public static void FindMedian(int[] A, int alow, int ahigh, int[] B, int blow, int bhigh)
        {
            if (ahigh - alow + 1 + bhigh - blow + 1 <= 3)
            {
                int l = ahigh - alow + 1 + bhigh - blow + 1;
                int[] C = new int[l];
                int i = 0;
                int j = alow;
                int k = blow;
                while (i < C.Length)
                {
                    while (j <= ahigh)
                    {
                        C[i] = A[j];
                        i++;
                        j++;
                    }

                    while (k <= bhigh)
                    {
                        C[i] = B[k];
                        i++;
                        k++;
                    }
                }

                Sorting.QuickSort(ref C, 0, C.Length - 1);
                Console.WriteLine(C[C.Length / 2]);
            }
            else
            {
                int med1 = alow + (ahigh - alow) / 2;
                int med2 = blow + (bhigh - blow) / 2;
                if (A[med1] <= B[med2])
                {
                    FindMedian(A, med1, ahigh, B, blow, med2);
                }
                else
                {
                    FindMedian(A, alow, med1, B, med2, bhigh);
                }
            }

        }


        //given sorted array with duplicates search for first occurence of a number
        public static int FirstOccuerence(int[] A, int p, int q, int k)
        {
            if (p == q)
            {
                if (A[p] == k) return p;
                return -1;
            }
            if (p < q)
            {
                int mid = p + (q - p) / 2;
                if (A[mid] == k)
                {
                    if (A[mid - 1] != k) return mid;
                    return FirstOccuerence(A, p, mid - 1, k);
                }
                else if (k < A[mid])
                {
                    return FirstOccuerence(A, p, mid - 1, k);
                }
                else
                {
                    return FirstOccuerence(A, mid + 1, q, k);
                }
            }

            return -1;

        }

        //given sorted array with duplicates search for last occurencee of a number
        public static int LastOccurence(int[] A, int p, int q, int k)
        {
            if (p == q)
            {
                if (A[p] == k) return p;
                return -1;
            }
            if (p < q)
            {
                int mid = p + (q - p) / 2;
                if (A[mid] == k)
                {
                    if (A[mid + 1] != k) return mid;
                    return LastOccurence(A, mid + 1, q, k);
                }
                else if (k < A[mid])
                {
                    return LastOccurence(A, mid + 1, q, k);
                }
                else
                {
                    return LastOccurence(A, p, mid - 1, k);
                }
            }
            return -1;
        }

        //given an array of sorted numbers with possbile duplicates find the number of times a number is repaeadted
        public static void NUmberOfRepeatitions(int[] A, int k)
        {
            int first = FirstOccuerence(A, 0, A.Length - 1, k);
            int last = LastOccurence(A, 0, A.Length - 1, k);
            if (first == -1 || last == -1)
            {
                Console.WriteLine("{0} is not present", k);
            }
            else
            {
                int c = last - first + 1;
                Console.WriteLine("{0} is repeated {1} times.", k, c);
            }
        }

        //separate odd and even numbers
        //input :  1234567
        //output:  2461357
        public static void SeparateEvenOdd(ref int[] A, int p, int q)
        {
            int i = p - 1;
            int j = p;
            while (j <= q)
            {
                if (IsEven(A[j]))
                {
                    Interchange(ref A, j, i + 1);
                    i++;
                }
                j++;
            }
        }

        public static void Interchange(ref int[] A, int p, int q)
        {
            int t = A[p];
            A[p] = A[q];
            A[q] = t;
        }
        public static bool IsEven(int n)
        {
            if (n % 2 == 0) return true;
            return false;
        }


        //given array of 0s and 1s separate them
        public static void SeprateOs1s(ref int[] A, int p, int q)
        {
            int i = p - 1;
            int j = p;
            while (j < A.Length)
            {
                if (A[j] == 0)
                {
                    Interchange(ref A, i + 1, j);
                    i++;
                }
                j++;
            }
        }

        //input:01200011221210
        //output: 0000111122222
        public static void SeparateTriple(ref int[] A, int p, int q)
        {
            int i = p - 1;
            int j = p;
            int k = q + 1;

            while (j < k)
            {
                if (A[j] == 0)
                {
                    Interchange(ref A, i + 1, j);
                    i++;
                    j++;
                }
                else if (A[j] == 2)
                {
                    Interchange(ref A, k - 1, j);
                    k--;
                }
                else
                {
                    j++;
                }
            }
        }

        //Given a sequence of nonnegative integers A and an integer T, return whether there is a* continuous sequence* of A that sums up to exactly T
        //[23, 5, 4, 7, 2, 11], 20. Return True because 7 + 2 + 11 = 20
        public static bool IsThere_Sequence_With_Given_Sum(int[] A, int T)
        {
            if (A.Length == 0) return false;
            if (T == 0) return true;

            int i = 0;
            int j = 0;
            int sum = A[0];

            while (i <= j && i < A.Length && j < A.Length)
            {
                if (sum == T)
                {
                    return true;
                }
                else if (sum < T)
                {
                    j++;
                    sum = sum + A[j];
                }
                else {
                    sum = sum - A[i];
                    i++;
                    sum = sum + A[i];
                    if (j < i)
                    {
                        j = i;
                    }

                }
            }

            if (sum == T) return true;
            return false;
        }














    }

    public static class Selection {

        //O(n)
        public static int FindLargest1(int[] A, int p, int q)
        {
            int max = A[p];
            int j = p + 1;
            while (j <= q)
            {
                if (A[j] > max)
                {
                    max = A[j];
                }
            }

            return max;
        }

        //O(n)
        public static int FindSmallest1(int[] A, int p, int q)
        {
            int min = A[p];
            int j = p + 1;
            while (j <= q)
            {
                if (A[j] < min)
                {
                    min = A[j];
                }
            }

            return min;
        }

        public static int KthElement(int[] A, int p, int q, int k)
        {
            if (p < q)
            {
                int r = Partition(ref A, p, q);
                if (r == k)
                {
                    return A[r];
                }
                else if (k < r)
                {
                    return KthElement(A, p, r - 1, k);
                }
                else
                {
                    return KthElement(A, r + 1, q, k);
                }
            }
            return -9999;
        }

        public static int Partition(ref int[] A, int p, int q)
        {
            int n = A[q];
            int i = p;
            int j = i - 1;

            while (i < q)
            {
                if (A[i] <= n)
                {
                    Searching.Interchange(ref A, i, j + 1);
                    j++;
                }
                i++;
            }
            A[q] = A[j + 1];
            A[j + 1] = n;
            return j + 1;
        }

        public static int RandomizedPartition(ref int[] A, int p, int q)
        {
            //Debug.Assert(p >= 0 && q < A.Length && p <= q);
            //Random r = new Random();
            //int index = r.Next(p, q);
            ////A[q] A[index]
            //int t = A[index];
            //A[index] = A[q];
            //A[q] = t;
            //return Partition(ref A, p, q);
            return -1;
        }




    }

    public static class StringProblems {


        public static string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < (sb.Length) / 2; i++)
            {
                InterchangeChars(ref sb, i, sb.Length - 1 - i);
            }
            return sb.ToString();
        }

        //complexity:
        public static void Permute(StringBuilder sb, int p, int q)
        {
            if (p == q)
            {
                Console.WriteLine(sb.ToString());
                return;
            }
            if (p < q)
            {
                for (int i = p; i <= q; i++)
                {
                    InterchangeChars(ref sb, p, i);
                    Permute(sb, p + 1, q);
                    InterchangeChars(ref sb, i, p);
                }
            }
        }

        public static void permuteString(StringBuilder sb, int p, int q)
        {

            if (p == q)
            {
                Console.WriteLine(sb.ToString());
            }
            else if (p < q)
            {
                for (int i = p; i <= q; i++)
                {
                    InterchangeInSB(ref sb, p, i);
                    permuteString(sb, p + 1, q);
                    InterchangeInSB(ref sb, p, i);
                }
            }


        }

        public static void PermuteListOfWords(List<string> li, int p, int q)
        {
            if (p == q)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string s in li)
                {
                    sb.Append(s);
                }
                Console.WriteLine(sb.ToString());

            }
            else if (p < q)
            {
                for (int i = p; i <= q; i++)
                {
                    //interchange list(i,p)
                    InterchangeInList(ref li, p, i);
                    PermuteListOfWords(li, p + 1, q);
                    InterchangeInList(ref li, p, i);
                }
            }
        }

        //find permutations which are palindromes too


        public static void InterchangeChars(ref StringBuilder sb, int i, int j)
        {
            char c = sb[i];
            sb[i] = sb[j];
            sb[j] = c;
        }

        public static void InterchangeInList(ref List<string> li, int p, int q)
        {
            string temp = li[p];
            li[p] = li[q];
            li[q] = temp;
        }

        public static void InterchangeInSB(ref StringBuilder sb, int p, int q)
        {
            char temp = sb[p];
            sb[p] = sb[q];
            sb[q] = temp;
        }


        public static bool IsNumberPalindrome(int x)
        {
            long y = 0;
            long originalx = (long)x;

            originalx = Math.Abs(originalx);

            long xtemp = originalx;

            while (xtemp > 0)
            {
                int rem = (int)(xtemp % 10);
                xtemp = xtemp - rem;
                xtemp = xtemp / 10;
                y = (y * 10) + rem;
            }

            if (y == originalx) return true;
            return false;
        }

        //is a given sentence palindrome iff spaces are not considered
        public static bool IsSentencePalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1) return true;
            int low = 0;
            int high = s.Length - 1;
            while (low < high)
            {
                if (s[low] == ' ' || s[high] == ' ')
                {
                    if (s[low] == ' ')
                    {
                        low++;
                    }
                    else
                    {
                        high--;
                    }
                }
                else
                {
                    if (s[low] != s[high])
                    {
                        return false;
                    }
                    else
                    {
                        low++;
                        high--;
                    }
                }
            }
            return true;
        }

        //counting sort of string
        //written for lower case
        public static string CountingSort(string s)
        {
            StringBuilder ret = new StringBuilder(s);

            int[] c = new int[26];
            foreach (char letter in s)
            {
                int asci = (int)letter;
                asci = asci - 97;
                c[asci]++;
            }

            for (int i = 1; i < c.Length; i++)
            {
                c[i] = c[i - 1] + c[i];
            }

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int asci = (int)s[i];
                asci = asci - 97;

                ret[c[asci] - 1] = s[i];
                c[asci]--;
            }

            return ret.ToString();
        }

        //if given tow strings are anagrams
        //O(len1 + len2)
        public static bool AreAnagrams(string s1, string s2)
        {
            string s1Sorted = CountingSort(s1);
            string s2Sorted = CountingSort(s2);

            if (string.Equals(s1Sorted, s2Sorted)) return true;
            return false;
        }

        //are two strings isomorphic
        //"egg" & "add"
        public static bool AreIsomorphic(string s1, string s2)
        {
            Dictionary<char, char> d = new Dictionary<char, char>();
            if (s1.Length != s2.Length) return true;
            if (s1.Length == 0 && s2.Length == 0) return true;

            int i = 0;
            while (i < s1.Length)
            {
                if (d.ContainsKey(s1[i]))
                {
                    if (d[s1[i]] != s2[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (d.ContainsValue(s2[i]))
                    {
                        char x1 = d.FirstOrDefault(x => x.Value == s2[i]).Key;
                        if (x1 != s1[i])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        d.Add(s1[i], s2[i]);
                    }
                }
                i++;
            }
            return true;
        }

        //one string is reverse of the other
        public static bool ArePalindromes(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            if (s1.Length == 0 && s2.Length == 0) return true;
            string reverses1 = ReverseString(s1);
            if (string.Equals(reverses1, s2)) return true;
            return false;

        }


        //reverse words in a string
        public static void ReverseWords(ref StringBuilder sb, int p, int q)
        {
            Debug.Assert(p <= q && q < sb.Length && p >= 0);
            ReverseStringBuilder(ref sb, p, q);

            int i = p;
            while (i <= q && sb[i] == ' ')
            {
                i++;
            }
            int j = i;

            while (j <= q)
            {
                while (j <= q && sb[j] != ' ')
                {
                    j++;
                }
                ReverseStringBuilder(ref sb, i, j - 1);
                while (j <= q && sb[j] == ' ')
                {
                    j++;
                }
                i = j;
            }

        }

        //reverese auxiliary for stringbuilder
        public static void ReverseStringBuilder(ref StringBuilder sb, int p, int q)
        {
            Debug.Assert(p <= q && q < sb.Length && p >= 0);
            int mid = (q - p) / 2;

            for (int i = 0; i <= mid; i++)
            {
                InterchangeChars(ref sb, p + i, q - i);
            }

        }

        //reverse vowels of a string
        //aeiou

        //string to integer = atoi

        //valid parenthesis
        //() ((()
        //Complexity - O(s.length)
        public static bool IsValidParenthesis(string s)
        {
            Stack<char> stk = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                {
                    stk.Push(c);
                }
                else
                {
                    if (stk.Count == 0) return false;
                    stk.Pop();
                }
            }
            if (stk.Count == 0) return true;
            return false;
        }

        //Given a pattern and a string str, find if str follows the same pattern.
        //pattern = "abba", str = "dog cat cat dog" should return true.
        //pattern = "abba", str = "dog cat cat fish" should return false.
        //https://leetcode.com/problems/word-pattern/
        public static bool WordPattern(string pattern, string str)
        {
            Dictionary<char, string> d = new Dictionary<char, string>();

            int i = 0; //track pattern letters
            int j = 0; //track word start in str
            int k = j + 1;

            while (i < pattern.Length)
            {
                while (k < str.Length && str[k] != ' ')
                {
                    k++;
                }
                string word = str.Substring(j, k - j);
                if (d.ContainsKey(pattern[i]))
                {
                    if (d[pattern[i]] != word)
                    {
                        return false;
                    }
                }
                else
                {
                    char skey = d.FirstOrDefault(x => x.Value == word).Key;
                    if (skey != '\0' && skey != pattern[i])
                    {
                        return false;
                    }
                    d.Add(pattern[i], word);

                }
                j = k + 1;
                k++;
                i++;
            }

            return true;
        }

        //Given s = "leetcode", return "leotcede".
        public static string ReverseVowels(string s)
        {
            StringBuilder sb = new StringBuilder(s);

            int i = 0;
            int j = s.Length - 1;

            while (i <= j)
            {
                if (IsVowel(sb[i]) && IsVowel(sb[j]))
                {
                    InterchangeChars(ref sb, i, j);
                    i++;
                    j--;
                }
                else {
                    if (!IsVowel(s[i]))
                    {
                        i++;
                    }
                    if (!IsVowel(s[j]))
                    {
                        j--;
                    }
                }
            }
            return sb.ToString();
        }

        public static bool IsVowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') return true;
            return false;

        }

        //given a string and a dictionary of words 
        //see if the given string can be
        //split in to space separated wordsf
        //wordbreak problem
        public static void SeprateToWords(string s, HashSet<string> dict)
        {
            int i = 0;
            int j = 0;

            while (j <= s.Length - 1)
            {
                int l1 = j - i + 1;
                string left = s.Substring(i, l1);

                int l2 = s.Length - 1 - j;
                string right = (l2 != 0) ? s.Substring(j + 1, l2) : "";


            }
        }

        //Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.
        //For example,
        //Given 1->2->3->3->4->4->5, return 1->2->5.
        //Given 1->1->1->2->3, return 2->3.

        //A message containing letters from A-Z is being encoded to numbers using the following mapping:

        //'A' -> 1
        //'B' -> 2
        //    ...
        //'Z' -> 26
        //Given an encoded message containing digits, determine the total number of ways to decode it.

        //For example,
        //Given encoded message "12", it could be decoded as "AB" (1 2) or "L" (12).

        //The number of ways decoding "12" is 2.
        public static int Decode(string s, int p, int q)
        {
            if (p == q) return 1;
            int total = 0;
            if (p < q)
            {
                int c1 = int.Parse(s[p].ToString());
                int c2 = int.Parse(s[p + 1].ToString());
                int num = (c1 * 10) + c2;

                //int twoPossible = 0;
                if (num >= 1 && num <= 26)
                {
                    total = total + Decode(s, p + 2, q);
                }

                total += Decode(s, p + 1, q);
                return total;
            }
            return 0;

        }
    }

    public static class DynamicProgramming
    {

        //Overlapping sub problems
        //Optimal Substructure
        //  Dynamic Probblem = Recursion + Memory

        //Fibonnacci - Simple Recursion
        //Complexity = T(n) = T(n-1) + T(n-2) = 
        public static int Fibonacci_Simple_Recursion(int n)
        {
            if (n <= 1) return 1;
            if (n == 2) return 2;
            return Fibonacci_Simple_Recursion(n - 1) + Fibonacci_Simple_Recursion(n - 2);
        }

        //Fibonacci - Dynamic Programming with Memoization(top down) - Memory table fiilled on demand , incase of 
        //problem not all memory gaps are filled like in case of Fibo case.
        private static int[] Fibo = new int[100];
        public static int Fibonacci_Dp_Memoization(int n)
        {
            if (Fibo[n] != 0) return Fibo[n];
            if (n == 1)
            {
                Fibo[n] = 1;
            }
            else if (n == 2)
            {
                Fibo[n] = 2;
            }
            else
            {
                Fibo[n] = Fibonacci_Dp_Memoization(n - 1) + Fibonacci_Dp_Memoization(n - 2);
            }
            return Fibo[n];
        }

        //Fibonacci - Dynamic Programming with Tabularization
        public static int Fibonacci_Dp_tabulation(int n)
        {
            if (n == 1 || n == 2) return n;
            int[] fib = new int[100];
            fib[0] = 1;
            fib[1] = 2;
            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib[n];
        }

        //Factorial Recursion
        //complaxity: T(n) = T(n-1) + O(1) => O(n)
        public static int Factorial_Recursion(int n)
        {
            if (n <= 1) return 1;
            return Factorial_Recursion(n - 1) * n;
        }

        //Factorial Memoization
        //O(n)
        private static int[] Fact = new int[100];
        public static int Factorial(int n)
        {
            if (Fact[n] != 0) return Fact[n];
            if (n == 0)
            {
                Fact[n] = 1;
                return Fact[n];
            }
            else
            {
                Fact[n] = Factorial(n - 1) * n;
                return Fact[n];
            }
        }

        //Factorial Tabulization
        //O(n)
        public static int Factorial_Dp_Tabulation(int n)
        {
            int[] F = new int[100];
            F[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                F[i] = F[i - 1] * i;
            }
            return F[n];
        }

        //Binomial coeffecient
        //C(n,k) = C(n-1,k-1) + C(n-1,k)
        //C(n,0) = C(n,n) = 1
        //
        public static int BinomialCoeffecient(int n, int k)
        {
            return 0;
        }


        //longest common subsequence for two strings
        //X Y
        //O(mn)
        public static void LCS_String(string X, string Y)
        {
            int[,] LCS = new int[X.Length + 1, Y.Length + 1];
            int[,] D = new int[X.Length, Y.Length];
            //0 - cross
            //1 - up
            //2 -down

            for (int i = 0; i <= X.Length; i++)
            {
                LCS[i, 0] = 0;
            }

            for (int j = 0; j <= Y.Length; j++)
            {
                LCS[0, j] = 0;
            }

            for (int i = 1; i <= X.Length; i++)
            {
                for (int j = 1; j <= Y.Length; j++)
                {
                    if (X[i - 1] == Y[j - 1])
                    {
                        LCS[i, j] = LCS[i - 1, j - 1] + 1;
                        D[i - 1, j - 1] = 3;
                    }
                    else if (LCS[i - 1, j] >= LCS[i, j - 1])
                    {
                        LCS[i, j] = LCS[i - 1, j];
                        D[i - 1, j - 1] = 1; //up
                    }
                    else
                    {
                        LCS[i, j] = LCS[i, j - 1];
                        D[i - 1, j - 1] = 2; //left
                    }
                }
            }


            StringBuilder sb = new StringBuilder();

            int i1 = X.Length;
            int j1 = Y.Length;

            while (i1 > 0 && j1 > 0)
            {
                if (D[i1 - 1, j1 - 1] == 3)
                {
                    sb.Append(X[i1 - 1]);
                    i1--;
                    j1--;

                }
                else if (D[i1 - 1, j1 - 1] == 2)
                {
                    j1--;
                }
                else
                {
                    i1--;
                }
            }

            string res = sb.ToString();

            Console.WriteLine("LCS = {0} Length = {1}", StringProblems.ReverseString(res), LCS[X.Length, Y.Length]);
            string[] words = new string[10];
            foreach (string word in words)
            {
                
            }

        }
        
        //longest common subsequence - for two arrays of integers
        public static void LCS_Integers(int[] A, int[] B)
        {
            int[,] C = new int[A.Length + 1, B.Length + 1];
            int[,] S = new int[A.Length, B.Length];


            for (int i = 0; i <= A.Length; i++)
            {
                C[i, 0] = 0;
            }

            for (int j = 0; j <= B.Length; j++)
            {
                C[0, j] = 0;
            }


            for (int i = 1; i <= A.Length; i++)
            {
                for (int j = 1; j <= B.Length; j++)
                {

                    if (A[i - 1] == B[j - 1])
                    {
                        C[i, j] = C[i - 1, j - 1] + 1;
                        S[i - 1, j - 1] = 1; //across
                    }
                    else if (C[i - 1, j] >= C[i, j - 1])
                    {
                        C[i, j] = C[i - 1, j];
                        S[i - 1, j - 1] = 2; //up
                    }
                    else
                    {
                        C[i, j] = C[i, j - 1];
                        S[i - 1, j - 1] = 3; //left
                    }

                }
            }

            List<int> LCS = new List<int>();

            int i1 = A.Length - 1;
            int j1 = B.Length - 1;
            while (i1 >= 0 && j1 >= 0)
            {
                if (S[i1, j1] == 1)
                {
                    LCS.Add(A[i1]);
                    i1--;
                    j1--;
                }
                else if (S[i1, j1] == 2)
                {
                    i1--;
                }
                else
                {
                    j1--;
                }

            }

            LCS.Reverse();

            foreach (int n in LCS)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();
            Console.WriteLine("LCS Length = {0}", C[A.Length, B.Length]);
        }

        //maximum vlue continous subsequence
        public static void Max_Value_Continous_Subsequence(int[] A)
        {
            int[] M = new int[A.Length];

            for (int i = 0; i < M.Length; i++)
            {
                if (i == 0)
                {
                    M[i] = A[i];
                }
                else
                {
                    M[i] = Math.Max(M[i - 1] + A[i], A[i]);
                }
            }

            Console.WriteLine(M.Max());
        }

        //maximum value no two contious subsequence
        //  M[i] = Max(M[i-1],M[i-2]+A[i])
        //     
        //
        public static void Max_Value_Contigous_Subsequence_NoTwo_Continous(int[] A)
        {
            int[] M = new int[A.Length];

            for (int i = 0; i < M.Length; i++)
            {
                if (i == 0)
                {
                    M[i] = A[i];
                }
                else if (i == 1)
                {
                    M[i] = Math.Max(A[i], A[i - 1]);
                }
                else
                {
                    M[i] = Math.Max(M[i - 2] + A[i], M[i - 1]);
                }
            }

            Console.WriteLine(M.Max());
        }

        //Max sum no three continous
        public static void Max_Sum_NoThree_Continous(int[] A)
        {
            int[] M = new int[A.Length];

            for (int i = 0; i < M.Length; i++)
            {
                if (i == 0)
                {
                    M[i] = A[i];
                }
                else if (i == 1)
                {
                    M[i] = Math.Max(M[i - 1] + A[i], A[i]);
                }
                else if (i == 2)
                {
                    M[i] = Math.Max(M[i - 1], M[i - 2] + A[i]);
                }
                else
                {
                    M[i] = Math.Max(M[i - 1], Math.Max(M[i - 2] + A[i], M[i - 3] + A[i] + A[i - 1]));
                }
            }
        }

        public static int Knapsack_0_1(int[] W, int[] V, int sackWeight)
        {
            if (sackWeight <= 0) return 0;
            int N = W.Length;

            int[,] B = new int[N + 1, sackWeight + 1];



            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= sackWeight; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        B[i, j] = 0;
                    }
                    else
                    {
                        if (W[i - 1] > j)
                        {
                            B[i, j] = B[i - 1, j];
                        }
                        else
                        {
                            B[i, j] = Math.Max(B[i - 1, j - W[i - 1]] + V[i - 1], B[i - 1, j]);
                        }
                    }
                }
            }

            return B[N, sackWeight];
        }

        //given unlimited number or dertain denominations 
        //find the min number of coins required for changing a given value
        public static int ChangeCoins(int[] V, int Value)
        {
            int[] M = new int[Value + 1];
            for (int i = 0; i < M.Length; i++)
            {
                if (i == 0)
                {
                    M[i] = 0;
                }
                else
                {
                    M[i] = int.MaxValue;
                }
            }

            for (int i = 1; i < M.Length; i++)
            {

                int min = int.MaxValue;
                foreach (int vj in V)
                {
                    if (i - vj >= 0 && M[i - vj] < min)
                    {
                        min = M[i - vj];
                    }

                }

                if (min + 1 < int.MaxValue)
                {
                    M[i] = min + 1;
                }

            }

            return M[M.Length - 1];
        }

        //Longest increasing subsequence
        public static void Longest_Increasing_Subsequence(int[] Input)
        {
            int[] L = new int[Input.Length];
            int[] Path = new int[Input.Length]; //Keep track of predecessors

            for (int i = 0; i < L.Length; i++)
            {
                L[i] = 1;
                Path[i] = -1;
            }

            for (int i = 1; i < L.Length; i++)
            {
                int max = 0;
                int maxIndex = -1;
                for (int j = 0; j < i; j++)
                {
                    if (Input[j] <= Input[i] && L[j] > max)
                    {
                        max = L[j];
                        maxIndex = j;
                    }
                }
                if (max != 0 && maxIndex > -1)
                {
                    L[i] = max + 1;
                    Path[i] = maxIndex;
                }
            }

            int fmax = int.MinValue;
            int fmaxindex = -1;
            for (int i = 0; i < L.Length; i++)
            {
                if (L[i] > fmax) {
                    fmax = L[i];
                    fmaxindex = i;
                }
            }

            int start = fmaxindex;
            while (start > -1)
            {
                Console.Write("{0} ", Input[start]);
                start = Path[start];
            }
            Console.WriteLine();
            Console.WriteLine(fmax);

        }

        //Longest Decreasing subsequence
        public static void Longest_Decreasing_Subsequence(int[] Input)
        {
            int[] LD = new int[Input.Length];

            for (int i = 0; i < Input.Length; i++)
            {

            }
        }

        //is there a subset with given sum 
        public static bool IsThereSubset(int[] A, int V)
        {
            int N = A.Length;

            int[,] B = new int[N + 1, V + 1];
            //B[0, 0] = 1;
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= V; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        B[i, j] = 1;
                    }
                    else {
                        B[i, j] = 0;
                    }
                }
            }

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j <= V; j++)
                {
                    if (B[i - 1, j] == 1)
                    {
                        B[i, j] = 1;
                    }
                    else if (j - A[i - 1] > -1)
                    {
                        if (B[i - 1, j - A[i - 1]] == 1)
                        {
                            B[i, j] = 1;
                        }
                    }
                }
            }

            return (B[N, V] == 1);


        }

        //maximum sum increasing sequence
        public static int MaxSum_Increasing_sequence(int[] A)
        {
            if (A.Length == 0) return 0;

            int[] M = new int[A.Length];
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = A[i];
            }
            //M[0] = A[0];

            for (int j = 1; j < M.Length; j++)
            {
                int max = int.MinValue;
                for (int i = 0; i < j; i++)
                {
                    if (A[i] <= A[j] && M[i] > max)
                    {
                        max = M[i];
                    }
                }
                if (max != int.MinValue)
                {
                    M[j] = max + A[j];
                }
            }

            return M.Max();

        }

        //edit distance problem
        //        Given two strings str1 and str2 and below operations that can performed on str1.Find minimum number of edits (operations) required to convert ‘str1′ into ‘str2′.
        //Insert
        //Remove
        //Replace
        //All of the above operations are of equal cost.
        //Examples:
        //Input:   str1 = "geek", str2 = "gesek"
        //Output:  1
        //We can convert str1 into str2 by inserting a 's'.
        public static int MinOperations(string str1, string str2)
        {
            int[,] dp = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 0; i <= str1.Length; i++)
            {
                for (int j = 0; j <= str2.Length; j++)
                {
                    if (i == 0)
                        dp[i, j] = j;  // Min. operations = j

                    // If second string is empty, only option is to
                    // remove all characters of second string
                    else if (j == 0)
                        dp[i, j] = i; // Min. operations = i

                    // If last characters are same, ignore last char
                    // and recur for remaining string
                    else if (str1[i - 1] == str2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1];

                    // If last character are different, consider all
                    // possibilities and find minimum
                    else
                        dp[i, j] = 1 + Math.Min(dp[i, j - 1], Math.Min(dp[i-1,j],dp[i-1,j-1])); // Insert        // Remove // Replace
                                           
                }
            }

            return 0;
        }




        public class FromRandonSites
        {


            //complexity = O(n) running time 
            //O(k) = memory where k is number of digits that can be possible
            public static int[] CountingSort(int[] A)
            {
                if (A.Length == 0) return null;

                int[] C = new int[10];

                foreach (int i in A)
                {
                    C[i]++;
                }

                for (int i = 1; i < C.Length; i++)
                {
                    C[i] = C[i] + C[i - 1];
                }

                int[] sortedA = new int[A.Length];

                for (int i = A.Length - 1; i >= 0; i--)
                {
                    int position = C[A[i]] - 1;
                    sortedA[position] = A[i];
                    C[A[i]]--;
                }

                return sortedA;
            }

            #region Radix Sort for integer array with all numbers being of same size
            //Complexisty of radix sort O(d(n+k))
            // k is number of possible digits whihc is 10 in case of integers and 26 if only letters
            // d is the size of integer, like 3 is size of 769
            //assume that all the integers are of same nuber of digits
            public static void RadixSort(ref int[] A)
            {
                if (A.Length == 0) return;
                int digitCount = FindSize(A[0]);

                for (int i = 1; i <= digitCount; i++)
                {
                    //do counting sort of A on digit i
                    CountingSort_ForDigitI(ref A, i);
                }


            }

            public static void CountingSort_ForDigitI(ref int[] A, int d)
            {
                if (A.Length == 0) return;
                int[] C = new int[10];

                int[] output = new int[A.Length];

                for (int i = 0; i < A.Length; i++)
                {
                    int num = A[i];
                    int dnum = GetNthPlace(num, d);
                    C[dnum]++;
                }

                for (int i = 1; i < C.Length; i++)
                {
                    C[i] = C[i - 1] + C[i];
                }

                for (int i = A.Length - 1; i >= 0; i--)
                {
                    int num = A[i];
                    int dnum = GetNthPlace(num, d);
                    output[C[dnum] - 1] = A[i];
                    C[dnum]--;
                }

                Array.Copy(output, A, output.Length);
            }

            public static int FindSize(int n)
            {
                n = Math.Abs(n);
                int size = 1;
                while (n > 10)
                {
                    n = n / 10;
                    size++;
                }
                return size;
            }

            public static int GetNthPlace(int num, int n)
            {
                //123
                int rem = 0;
                int q = 0;

                while (n > 0)
                {
                    rem = num % 10;
                    num = (num - rem) / 10;
                    n--;
                }
                return rem;
            }
            #endregion

            //for small letters (a-z)(97-)
            public static string CountingSort_String(string s)
            {
                if (s.Length == 0) return "";

                int[] C = new int[26];

                StringBuilder sb = new StringBuilder(s);

                foreach (char c in s)
                {
                    int asci = (int)c;
                    asci -= 97;
                    C[asci]++;
                }

                for (int i = 1; i < C.Length; i++)
                {
                    C[i] = C[i - 1] + C[i];
                }

                for (int i = s.Length - 1; i >= 0; i--)
                {

                    int asci = (int)s[i];
                    asci = asci - 97;
                    sb[C[asci] - 1] = s[i];
                    C[asci]--;
                }

                return sb.ToString();

            }




        }
    }

    public static class MathTricks {
        public static int GetSum(int a, int b)
        {

            if (a < 0)
            {
                while (a != 0)
                {
                    b--;
                    a++;
                }
            }
            else
            {
                while (a != 0)
                {
                    b++;
                    a--;
                }
            }

            return b;
        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            //Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].

            Dictionary<int, bool> h = new Dictionary<int, bool>();

            Array.Sort(nums2);

            for (int i = 0; i < nums1.Length; i++)
            {
                int n = nums1[i];
                if (Searching.BinarySearch(nums2, 0, nums2.Length - 1, n))
                {
                    if (!h.ContainsKey(n))
                    {
                        h.Add(n, true);
                    }
                }
            }

            int[] ret = h.Select(x => x.Key).ToArray();
            return ret;
        }


        public static bool IsMultipleOf3(int n)
        {
            if (n == 0 || n == 1) return true;
            int oddCount = 0;
            int evenCount = 0;
            bool isOdd = true;
            while (n != 0)
            {
                if (isOdd)
                {
                    if (getLastbit(n))
                    {
                        oddCount++;
                    }
                }
                else
                {
                    if (getLastbit(n))
                    {
                        evenCount++;
                    }
                }
                n = n >> 1;
            }

            return IsMultipleOf3(Math.Abs(oddCount - evenCount));
        }

        public static bool getLastbit(int n)
        {
            return ((1 & n) == 1);
        }


    }

    public static class GraphProblems {

        //BFS - Shortest ddistance from given source to all reachable vertices.
        // O(E)

        //DFS - TB{FC} (Tree Edge, Back Edge, Forward Edge, Cross Edge) - WGB (White,Gray,Black)

        //DFS Application: Detect a cycle in a directed graph
        public static bool HasCycle_DirectedGraph(bool[,] Adj)
        {
            int count = Adj.GetUpperBound(0);
            List<Vertex> v = new List<Vertex>();
            for (int i = 0; i < count; i++)
            {
                v.Add(new Vertex());
                v[i].Color = 0;
                v[i].Parent = -1;
            }
            int time = 0;
            bool foundbackedge = new bool();
            for (int i = 0; i < count; i++)
            {
                if (v[i].Color == 0)
                {
                    //dfs visit 
                    DFSVisit(ref v, Adj, ref time, i, count, ref foundbackedge);
                    if (foundbackedge) return true;
                }
            }

            if (foundbackedge) return true;
            return false;
        }

        public static void DFSVisit(ref List<Vertex> v, bool[,] Adj, ref int time, int i, int count, ref bool foundBackEdge)
        {
            time++;
            v[i].StartTime = time;
            v[i].Color = 1; //gray

            for (int j = 0; j < count; j++)
            {
                if (Adj[i, j])
                {
                    if (v[j].Color == 0)
                    {
                        DFSVisit(ref v, Adj, ref time, i, count, ref foundBackEdge);
                    }
                    else if (v[j].Color == 1)
                    {
                        foundBackEdge = true;
                    }

                }
            }

            v[i].Color = 2;
            v[i].EndTime = ++time;
        }

        public class Vertex
        {

            //0 - white
            //1 - gray
            //2 - black
            public int Color { get; set; }

            public int Parent { get; set; }

            public int StartTime { get; set; }

            public int EndTime { get; set; }


        }

        public static void Test() {

        }

    }

    public static class StackProblems
    {

        private static Dictionary<char, int> Priority;

        static StackProblems()
        {
            Priority = new Dictionary<char, int>();
            Priority.Add('+', 1);
            Priority.Add('-', 1);
            Priority.Add('*', 2);
            Priority.Add('/', 2);
            Priority.Add('(', 3);
            Priority.Add(')', 3);
        }

        public static string InFix2PostFix(string s)
        {
            StringBuilder sb = new StringBuilder();
            Stack<char> stk = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (IsCapital(c))
                {
                    sb.AppendFormat("{0}", c);
                }
                else if (c == ')')
                {
                    while (stk.Count > 0 && stk.Peek() != '(')
                    {
                        sb.AppendFormat("{0}", stk.Pop());
                    }
                    stk.Pop();
                }
                else
                {
                    if (c == '(')
                    {
                        stk.Push(c);
                    }
                    else
                    {
                        while (stk.Count > 0 && (stk.Peek()!='(') &&  (Priority[stk.Peek()] >= Priority[c]))
                        {
                            sb.AppendFormat("{0}", stk.Pop());
                        }
                        stk.Push(c);
                    }
                }
            }

            
            
           
            while (stk.Count > 0)
            {
                sb.AppendFormat("{0}", stk.Pop());
            }

            return sb.ToString();

        }

        //infix to prefix

        public static void ReverseStack(ref Stack<int> s)
        {
            if (s.Count == 0) return;
            int n = s.Pop();
            ReverseStack(ref s);
            InsertAtBottom(ref s, n);
        }
        public static void InsertAtBottom(ref Stack<int> s,int n)
        {
            if (s.Count == 0)
            {
                s.Push(n);
                return;
            }
            int temp = s.Pop();
            InsertAtBottom(ref s, n);
            s.Push(temp);
        }

        //Remove duplicate letters

        //Evaluate Reverrse Polish Notation
        //Solved in LeetCode
        //basically same as evaluating post order 
        //ex: ["2","1","+","3","*"] => 9
        public static int EvaluatePolishNotation(string[] tokens)
        {
            return -1;
        }

        public static bool IsCapital(char c)
        {
            int n = (int)c;
            if (n <= 90 && n >= 65) return true;
            return false;
        }

        //{6, 2, 5, 4, 5, 2, 6}
        //stack problem: largest rectangle area in histogram
        public static int LargestRectangleArea(int[] heights)
        {
            if (heights.Length == 0) return 0;
           
            //store indexes not actual heights
            Stack<int> s = new Stack<int>();
            int maxarea = -1;
            int i = 0;
            while (i < heights.Length)
            {
                if (s.Count == 0 || heights[i] > heights[s.Peek()])
                {
                    s.Push(i);
                    i++;
                }
                else
                {
                    //heights[i] <= heights[s.Pop] 
                    int top = s.Pop();
                    int curarea = heights[top] * (s.Count == 0 ? i : (i - s.Peek() - 1));
                    if (curarea > maxarea) maxarea = curarea;
                }
            }

            while (s.Count > 0)
            {
                int top = s.Pop();
                int curarea = heights[top] * (s.Count == 0 ? i : (i - s.Peek() - 1));
                if (curarea > maxarea) maxarea = curarea;
            }

            return maxarea;

        }

        //Maximal Rectangle  QuestionEditorial Solution  My Submissions
        //Total Accepted: 46427
        //Total Submissions: 191926
        //Difficulty: Hard
        //Given a 2D binary matrix filled with 0's and 1's, find the largest rectangle containing only 1's and return its area.
        //For example, given the following matrix:
        //1 0 1 0 0
        //1 0 1 1 1
        //1 1 1 1 1
        //1 0 0 1 0
        //Return 6.
        //public static int MaxArea(char[,] Matrix)
        //{
        //    int maxarea = 0;
        //    int m = Matrix.GetLength(0);
        //    int n = Matrix.GetLength(1);

        //    bool[,] IsVisited = new bool[m, n];

        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (IsVisited[i, j] == false)
        //            {
        //                if (Matrix[i, j] == '0')
        //                {
        //                    IsVisited[i, j] = true;

        //                }
        //                else
        //                {
        //                    MaxArea_Aux(Matrix, i, j, 1, 1, ref maxarea);
        //                }
        //            }
        //        }
        //    }

        //}

        //public static void MaxArea_Aux(char[,] Matrix,int i,int j, int curwid, int curheight, ref int maxarea)
        //{

        //}



    }

    public static class Random {
        #region Named && Matrix Algorithms

        //Flood Fill algorithms
        public static void FillPaint(ref int[,] Screen, int x, int y, int NewColor)
        {
            int m = Screen.GetLength(0);
            int n = Screen.GetLength(1);

            if (!AreValidInputs(x, y, m, n)) return;

            int OldColor = Screen[x, y];
            if (OldColor == NewColor) return;
            FillPaintAux(ref Screen, m, n, x, y, OldColor, NewColor);
         }
        public static void FillPaintAux(ref int[,] Screen, int m,int n,int x, int y, int oldColor, int newColor)
        {
            
            if (!AreValidInputs(x, y, m, n)) return;

            if (Screen[x,y]!=oldColor) return;
            Screen[x, y] = newColor;
            FillPaintAux(ref Screen,m,n, x - 1, y, oldColor, newColor);
            FillPaintAux(ref Screen,m,n, x, y-1, oldColor, newColor);
            FillPaintAux(ref Screen,m,n, x+1, y, oldColor, newColor);
            FillPaintAux(ref Screen,m,n, x, y+1, oldColor, newColor);
        }
        public static bool AreValidInputs(int x, int y, int m, int n)
        {
            if (x < 0 || y < 0) return false;
            if (x >= m || y >= n) return false;
            return true;
        }

        //Islands 
        //complexity - O(m*n)
        public static int NumIslands(char[,] grid)
        {

            int m = grid.GetLength(0);
            int n = grid.GetLength(1);
            if (m == 0 && n == 0) return 0;
            bool[,] IsVisited = new bool[m, n];

            for (int a = 0; a < m; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    IsVisited[a, b] = false;
                }
            }

            m--;
            n--;
            int num = 0;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (IsVisited[i, j] == false)
                    {
                        if (grid[i, j] == 0)
                        {
                            IsVisited[i, j] = true;
                        }
                        else
                        {
                            num++;
                            DFSVisit(grid, i, j, ref IsVisited, m, n);
                        }
                    }
                }
            }

            return num;

        }
        public static void DFSVisit(char[,] grid, int x, int y, ref bool[,] IsVisited, int m, int n)
        {

            IsVisited[x, y] = true;
            if (IsValid(x - 1, y, m, n) == true && IsVisited[x - 1, y] == false && grid[x - 1, y] == 1) DFSVisit(grid, x - 1, y, ref IsVisited, m, n);
            if (IsValid(x, y - 1, m, n) == true && IsVisited[x, y - 1] == false && grid[x, y - 1] == 1) DFSVisit(grid, x, y - 1, ref IsVisited, m, n);
            if (IsValid(x, y + 1, m, n) == true && IsVisited[x, y + 1] == false && grid[x, y + 1] == 1) DFSVisit(grid, x, y + 1, ref IsVisited, m, n);
            if (IsValid(x + 1, y, m, n) == true && IsVisited[x + 1, y] == false && grid[x + 1, y] == 1) DFSVisit(grid, x + 1, y, ref IsVisited, m, n);
        }
        public static bool IsValid(int x, int y, int m, int n)
        {
            if (x < 0 || x > m) return false;
            if (y < 0 || y > n) return false;
            return true;
        }

        //word brak proble
        //given a string and a dictionary of words 
        //see if the given string can be
        //split in to space separated wordsf
        //wordbreak problem
        public static void SeprateToWords(string s, HashSet<string> dict)
        {
            int i = 0;
            int j = 0;

            while (j <= s.Length - 1)
            {
                int l1 = j - i + 1;
                string left = s.Substring(i, l1);

                int l2 = s.Length - 1 - j;
                string right = (l2 != 0) ? s.Substring(j + 1, l2) : "";


            }
        }

        //        Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n). 

        //For example,
        //S = "ADOBECODEBANC"
        //T = "ABC"
        //Minimum window is "BANC". 
        public static void MinimumWindow(string S,string T)
        {
        }

        //word distance problem or also called as edit distance
        //given you can replace remove 
        //edit distance problem
        //        Given two strings str1 and str2 and below operations that can performed on str1.Find minimum number of edits (operations) required to convert ‘str1′ into ‘str2′.
        //Insert
        //Remove
        //Replace
        //All of the above operations are of equal cost.
        //Examples:
        //Input:   str1 = "geek", str2 = "gesek"
        //Output:  1
        //We can convert str1 into str2 by inserting a 's'.
        public static int MinOperations(string s1, string s2)
        {
            int[,] Dp = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i <= s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                {

                }
            }

            return 0;
        }

        //word Ladder problem
        //given a dictionary of words , see if given given two words can be transformed from one to another by changing 1 leteer at a time.
        //Each intermediate word must exist in the word list
        //        For example,
        //        Given:
        //beginWord = "hit"
        //endWord = "cog"
        //wordList = ["hot","dot","dog","lot","log"]
        //        As one shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog",
        public static int LadderLength(string beginWord, string endWord, ISet<string> wordList)
        {
            return 0;

        }

        #endregion

        #region Matrix Problem

        //LeetCode - Longest Increasing path in a Matrix
        // nums = [
        //[9,9,4],
        //[6,6,8],
        //[2,1,1]
        //]        output is length 4 corresponding to path [1,2,6,9]
        //from any point you can move in four directions
        public static int LongestIncreasingPath(int[] Matrix)
        {
            return 0;
        }

        public static int[] KMPPrefix(string P)
        {
            int[] F = new int[P.Length];

            if (P.Length == 0) return F;
            F[0] = 0;

            int i = 1;
            int j = 0;

            while (i < P.Length)
            {
                if (P[i] == P[j])
                {
                    F[i] = j + 1;
                    i++;
                    j++;
                }
                else if (j > 0)
                {
                    j = F[j - 1];
                }
                else {
                    F[i] = 0;
                    i++;
                }
            }

            return F;

        }


        public static int FindPattern_KMP(string s, string p)
        {
            return 0;
        }




        #endregion
    }

}

   
   














