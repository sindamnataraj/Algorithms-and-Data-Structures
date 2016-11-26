using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    public class MyStack
    {
        private int top;

        private int[] A;

        public MyStack(int n)
        {
            A = new int[n];
            top = 0;
        }

        public void Push(int n)
        {
            if (top != A.Length)
            {
                A[top] = n;
                top++;
            }
        }

        public int Pop()
        {
            if (top > 0)
            {
                return A[--top];
            }
            return -999;
        }

        public void PrintStack()
        {
            for (int i = 0; i < top; i++)
            {
                Console.Write("{0} ",A[i]);
            }
            Console.WriteLine();
        }
    }
}
