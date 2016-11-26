using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    public class PhoneDirectory
    {
        private PhoneTrie myPhoneTrie;

        public PhoneDirectory()
        {
            myPhoneTrie = new PhoneTrie();
        }

        public void AddNumber(string num, string name)
        {
            myPhoneTrie.Insert(num, name);
        }

        public string GetName(string num)
        {
            return myPhoneTrie.Search(num);
        }

    }

    public class PhoneTrieNode {
        public PhoneTrieNode[] next;
        public bool IsEnd;
        public string Name;

        public PhoneTrieNode()
        {
            next = new PhoneTrieNode[10];
            IsEnd = false;
            
        }

    }

    public class PhoneTrie
    {
        private PhoneTrieNode head;
        public PhoneTrie()
        {
            head = null;
        }

        public void Insert(string num, string name)
        {
            head = Insert(head, num, 0, name);
        }

        private static PhoneTrieNode Insert(PhoneTrieNode Node, string num, int i,string CustomerName)
        {
            if (Node == null)
            {
                Node = new PhoneTrieNode();
            }

            if (i == num.Length)
            {
                Node.IsEnd = true;
                Node.Name = CustomerName;
                return Node;
            }

            Node.next[((int)num[i]) - 48] = Insert(Node.next[((int)num[i]) - 48], num, i + 1, CustomerName);
            return Node;

        }
        public string Search(string num)
        {
            return Search(head, num, 0);
        }

        private static string Search(PhoneTrieNode Node, string num, int i)
        {
            if (Node == null) return "";
            if (i == num.Length)
            {
                if (Node.IsEnd) { return Node.Name; }
                return "";
            }
            return Search(Node.next[(int)num[i] - 48], num, i + 1);
        }
    }
}
