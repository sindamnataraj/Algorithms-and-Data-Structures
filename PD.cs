using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    public class TrieNode {
        public TrieNode[] next;
        public string customerName;
        public bool Isend;
        public TrieNode()
        {
            next = new TrieNode[10];
            Isend = false;
            customerName = null;
        }
    }
    
    //phone directory
    class PD
    {
        private TrieNode head;

        public void Insert(string number, string name)
        {
            if (number.Length != 10) return;
            if (name.Length == 0) return;
            head = Insert(head, number, 0, name);
        }
        private static TrieNode Insert(TrieNode Node, string number,int i, string name)
        {
            if (Node == null)
            {
                Node = new TrieNode();
            }

            if (i == number.Length)
            {
                Node.Isend = true;
                Node.customerName = name;
                return Node;
            }

            Node.next[((int)number[i]) - 48] = Insert(Node.next[((int)number[i]) - 48],number,i+1,name);
            return Node;
        }


    }
}
