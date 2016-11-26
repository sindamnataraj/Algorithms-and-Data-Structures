using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    //important things to remember for linked list
    //1.Get Middle element logic 
    //          If odd pointer to middle is returned, if even pointer to last element in left half is returned
    //2.Reverse the list
    //          Most complex problems on Linked List are based on above two points.
    public class MyLinkedList
    {
        public class MyLinkedListNode {
            public int n;
            public MyLinkedListNode next;
        }

        private MyLinkedListNode Head;

        public MyLinkedList() {
            Head = null;
        }

        public void Insert(int n)
        {
            MyLinkedListNode temp = new MyLinkedListNode();
            temp.n = n;
            temp.next = null;
            if (Head == null)
            {
                Head = temp;

            }
            else
            {
                MyLinkedListNode temp1 = Head;
                while (temp1.next != null)
                {
                    temp1 = temp1.next;
                }
                temp1.next = temp;
            }
        }

        public void PrintMyList()
        {
            MyLinkedListNode Temp = Head;
            while (Temp != null)
            {
                Console.Write("{0} ", Temp.n);
                Temp = Temp.next;
            }
            Console.WriteLine();
        }

        public void DeleteDups()
        {
            Head = DeleteDuplicates(Head);
            PrintMyList();
        }

        private MyLinkedListNode DeleteDuplicates(MyLinkedListNode head)
        {

            if (head == null || head.next == null) return head;

            MyLinkedListNode prev = head;
            MyLinkedListNode cur = head.next;

            while (cur != null)
            {
                if (cur.n == prev.n)
                {
                    prev.next = cur.next;
                    cur = prev.next;
                }
                else
                {
                    prev = cur;
                    cur = cur.next;
                }
            }
            return head;
        }

        public void DeleteNode(int n)
        {
            if (Head == null) return;
            if (Head.n == n) { Head = Head.next; return; }
            MyLinkedListNode temp = Head.next;
            MyLinkedListNode temp1 = Head;
            while (temp != null && temp.n != n)
            {
                temp1 = temp;
                temp = temp.next;
            }
            if (temp != null)
            {
                temp1.next = temp.next;
            }
        }

        public void ReverseList()
        {
            Head = ReverseList(Head);
        }
        private static MyLinkedListNode ReverseList(MyLinkedListNode node)
        {
            if (node == null || node.next == null) return node;
            MyLinkedListNode second = node.next;
            MyLinkedListNode ReverseOfSecond = ReverseList(second);
            second.next = node;
            node.next = null;
            return ReverseOfSecond;
        }

        public void MergeSort()
        {
            Head = MergeSort(Head);
        }
        private MyLinkedListNode MergeSort(MyLinkedListNode Node)
        {
            if (Node == null || Node.next == null) return Node;

            //split the list
            MyLinkedListNode slow = Node;
            MyLinkedListNode prevslow = null;
            MyLinkedListNode fast = Node;

            int i = 1;

            while (fast != null)
            {
                fast = fast.next;
                if (i % 2 == 0)
                {
                    prevslow = slow;
                    slow = slow.next;
                }
                i++;
            }

            MyLinkedListNode second = prevslow.next;
            prevslow.next = null;

            Node = MergeSort(Node);
            second = MergeSort(second);

            //combine Node and second
            MyLinkedListNode finalhead = null;
            MyLinkedListNode finaltail = null;
            while (Node != null && second != null)
            {
                if (Node.n <= second.n)
                {
                    if (finalhead == null && finaltail == null)
                    {
                        finalhead = Node;
                        finaltail = Node;
                        Node = Node.next;
                    }
                    else
                    {
                        finaltail.next = Node;
                        Node = Node.next;
                        finaltail = finaltail.next;
                        finaltail.next = null;
                    }

                }
                else
                {
                    if (finalhead == null && finaltail == null)
                    {
                        finalhead = second;
                        finaltail = second;
                        second = second.next;
                    }
                    else
                    {
                        finaltail.next = second;
                        second = second.next;
                        finaltail = finaltail.next;
                        finaltail.next = null;
                    }

                }
            }

            while (Node != null)
            {
                if (finalhead == null && finaltail == null)
                {
                    finalhead = Node;
                    finaltail = Node;
                    Node = Node.next;
                }
                else
                {
                    finaltail.next = Node;
                    Node = Node.next;
                    finaltail = finaltail.next;
                    finaltail.next = null;
                }

            }

            while (second != null)
            {
                if (finalhead == null && finaltail == null)
                {
                    finalhead = second;
                    finaltail = second;
                    second = second.next;
                }
                else
                {
                    finaltail.next = second;
                    second = second.next;
                    finaltail = finaltail.next;
                    finaltail.next = null;
                }
            }

            return finalhead;

        }

        //quick sort of linked list
        private void QuickSort(MyLinkedListNode Node)
        {
            if (Node == null || Node.next == null) return;

            //find the last node
            MyLinkedListNode lastnode = Node;
            while (lastnode.next != null)
            {
                lastnode = lastnode.next;
            }

            MyLinkedListNode left = null;
            MyLinkedListNode leftTail = null;

            MyLinkedListNode right = null;
            MyLinkedListNode rightTail = null;

            while (Node != lastnode)
            {
                if (Node.n <= lastnode.n)
                {
                    //add to left
                    if (left == null && leftTail == null)
                    {
                        left = Node;
                        leftTail = Node;
                        Node = Node.next;
                        leftTail.next = null;
                    }
                    else
                    {
                        leftTail.next = Node;
                        Node = Node.next;
                        leftTail = leftTail.next;
                        leftTail.next = null;
                    }
                }
                else
                {
                    //add to right
                    if (right == null && rightTail == null)
                    {
                        right = Node;
                        rightTail = Node;
                        Node = Node.next;
                        rightTail.next = null;
                    }
                    else
                    {
                        rightTail.next = Node;
                        Node = Node.next;
                        rightTail = rightTail.next;
                        rightTail.next = null;
                    }
                }
            }




        }

        //Reorder List
        //given {1,2,3,4} output {1,4,2,3}
        //very imp
        public void ReorderList()
        {
            Head = ReorderList(Head);
            PrintMyList();
        }
        private MyLinkedListNode ReorderList(MyLinkedListNode Node)
        {
            if (Node == null || Node.next == null) return Node;

            MyLinkedListNode mid = GetMiddleNode(Node);
            mid.next = ReverseList(mid.next);

            MyLinkedListNode first = Node;
            MyLinkedListNode second = mid.next;
            mid.next = null;


            while (second != null)
            {
                MyLinkedListNode temp1 = first.next;
                MyLinkedListNode temp2 = second.next;

                first.next = second;
                second.next = temp1;
                first = temp1;
                second = temp2;
            }

            return Node;

        }

        //Rotate list
        //input: {1,2,3,4,5,6} k =2 implies rotate twice and give {5,6,1,2,3,4}
        //solved in leetcode "rotate-list"


        //Reverse a linked list from position m to n. Do it in-place and in one-pass.
        //For example:
        //Given 1->2->3->4->5->NULL, m = 2 and n = 4,
        //return 1->4->3->2->5->NULL.
        private static MyLinkedListNode ReverseBetween(MyLinkedListNode head, int m, int n)
        {
            if (head == null || head.next == null) return head;
            if (m == n) return head;
            MyLinkedListNode pointmprev = null;
            MyLinkedListNode pointm = head;
            int i = 0;
            for (i = 1; (i < m) && (pointm != null); i++)
            {
                pointmprev = pointm;
                pointm = pointm.next;
            }

            //Implies invalid m value
            if (i != m) return head;

            MyLinkedListNode pointn = head;
            int j = 0;
            for (j = 1; (j < n) && (pointn != null); j++)
            {
                pointn = pointn.next;
            }

            //Invalid n value is given
            if (j != n) return head;

            MyLinkedListNode temp = pointn.next;
            pointn.next = null;

            if (pointmprev != null)
            {
                pointmprev.next = ReverseList(pointmprev.next);
                pointm.next = temp;
                return head;
            }
            else
            {
                head = ReverseList(head);
                pointm.next = temp;
                return head;
            }


        }

        public int GetMiddle()
        {
            MyLinkedListNode temp = GetMiddleNode(Head);
            if (temp != null) return temp.n;
            return -1;
        }
        private MyLinkedListNode GetMiddleNode(MyLinkedListNode Node)
        {
            if (Node == null || Node.next == null) return Node;

            int i = 1;
            MyLinkedListNode fast = Node;
            MyLinkedListNode prevslow = null;
            MyLinkedListNode slow = Node;
            while (fast != null)
            {
                fast = fast.next;
                if (i % 2 == 0)
                {
                    prevslow = slow;
                    slow = slow.next;
                }
                i++;
            }
            if (i % 2 == 0) return slow;
            return prevslow;
        }

        //get min
        private int GetMin(MyLinkedListNode Node)
        {
            if (Node == null) return 99999;
            if (Node.next == null) return Node.n;
            return Math.Min(Node.n, GetMin(Node.next));
        }



        #region practice on the go
        private MyLinkedListNode ReverseList1(MyLinkedListNode Node)
        {
            if (Node == null || Node.next == null) return Node;

            MyLinkedListNode second = Node.next;
            MyLinkedListNode reverseSecond = ReverseList1(second);

            second.next = Node;
            Node.next = null;
            return reverseSecond;
        }



        #endregion




    }
}
