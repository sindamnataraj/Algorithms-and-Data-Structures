using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    //https://leetcode.com/problems/implement-trie-prefix-tree/
    public class MyTrie
    {
        public class TrieNode {
           //public char c;
            public bool IsEnd;
            public TrieNode[] Child;

            public TrieNode()
            {
                Child = new TrieNode[26];
                for (int i = 0; i < 26; i++)
                {
                    Child[i] = null;
                }
            }
        }

        private TrieNode Head;
        public MyTrie()
        {
            Head = null; 
        }
        
        public void Insert(string s)
        {
            Head = Insert_Trie(Head, s, 0);
        }
        private TrieNode Insert_Trie(TrieNode Node, string s, int i)
        {
            //Char c = s[i];
            if (Node == null)
            {
                Node = new TrieNode();
                if (i == s.Length)
                {
                    Node.IsEnd = true;
                }
                else
                {
                    Node.Child[(int)s[i] - 97] = Insert_Trie(Node.Child[(int)s[i] - 97], s, i + 1);
                }
                return Node;
            }
            if (s.Length== i)
            {
                //covers tha case of inserting "te" in "tea" 
                Node.IsEnd = true;
                return Node;
            }
            Node.Child[(int)s[i]-97] = Insert_Trie(Node.Child[(int)s[i] - 97], s, i + 1); ;
            return Node;
        }
        
        public void PrintAllStrings()
        {
            PrintAllStrings_Trie(Head,"");
        }
        private void PrintAllStrings_Trie(TrieNode Node, String s)
        {
            if (Node == null) return;
            StringBuilder sb = new StringBuilder(s);

            if (Node.IsEnd)
            {
                Console.WriteLine("{0}",sb.ToString());
            }
            for (int i = 0; i < 26; i++)
            {
                if (Node.Child[i] != null)
                {
                    string s1 = string.Format("{0}{1}", sb.ToString(), (char)(i + 97));
                    PrintAllStrings_Trie(Node.Child[i], s1);
                }
            }
        }

        public bool Search(string s)
        {
            return Search_Trie(Head, s, 0);
        }
        private bool Search_Trie(TrieNode Node,string s,int i)
        {
            if (Node == null) return false;
            if (i == s.Length)
            {
                if (Node.IsEnd) return true;
                return false;
            }
            int n = (int)s[i] - 97;
            return Search_Trie(Node.Child[n], s, i + 1);


        }
    }
}
