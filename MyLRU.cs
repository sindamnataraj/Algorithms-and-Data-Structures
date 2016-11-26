using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    class MyLRU
    {
        private int MaxSize;
        private int currentCount;
        private DoubleLinkedList frameList;
        private Dictionary<int, DListNode> pageDictionary;

        public MyLRU(int n)
        {
            MaxSize = n;
            currentCount = 0;
            frameList = new DoubleLinkedList();
            pageDictionary = new Dictionary<int, DListNode>();

        }

        //returns page node , but in practice it would return page address
        public DListNode getPage(int pageKey)
        {
            if (pageDictionary.ContainsKey(pageKey))
            {
                return pageDictionary[pageKey];
                
            }
            else
            {
                //page fault
                if (currentCount == MaxSize)
                {
                    //Delete head node since it will be the least recently used
                    pageDictionary.Add(pageKey, frameList.Insert(pageKey));
                }
                else {
                    pageDictionary.Add(pageKey, frameList.Insert(pageKey));
                }
            }
            return null;
        }


    }

    public class DListNode
    {
        public int n;
        public DListNode prev;
        public DListNode next;

        public DListNode(int n)
        {
            this.n = n;
            prev = null;
            next = null;
        }

    }

    public class DoubleLinkedList {
        

        private DListNode head;
        private DListNode tail;

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
        }

        public DListNode Insert(int n)
        {
            if (head == null && tail == null)
            {
                head = new DListNode(n);
                tail = head;
                return head;
            }
            else {
                DListNode temp = new DListNode(n);
                tail.next = temp;
                temp.prev = tail;
                tail = tail.next;
                return tail;
            }
        }

        public void PrintDoubleList()
        {
            PrintL(head);
        }

        private void PrintL(DListNode Node)
        {
            while (Node != null)
            {
                Console.Write("{0} ",Node.n);
                Node = Node.next;
            }
            Console.WriteLine();
        }


        
        
    }
}
