using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    public class MyHeap
    {
        private int heapLength;

        public void HeapSort(ref int[] A)
        {
            BuildMaxHeap(ref A, ref heapLength);

            while (heapLength > 0)
            {
                InterChange(ref A, heapLength, 0);
                heapLength--;
                MaxHeapify(ref A, 0, heapLength);
            }
        }

        private void InterChange(ref int[] A, int p, int q)
        {
            int temp = A[p];
            A[p] = A[q];
            A[q] = temp;
        }

        private void BuildMaxHeap(ref int[] A, ref int heapLength)
        {
            heapLength = A.Length - 1;
            for (int i = (A.Length / 2) - 1; i >= 0; i--)
            {
                MaxHeapify(ref A, i, heapLength);
            }
        }

        private void MaxHeapify(ref int[] A, int i, int heapLength)
        {
            int left = Left(i);
            int right = Right(i);
            int Max = i;
            if (left <= heapLength && A[left] > A[Max])
            {
                Max = left;
            }

            if (right <= heapLength && A[right] > A[Max])
            {
                Max = right;
            }

            if (Max != i)
            {
                int temp = A[Max];
                A[Max] = A[i];
                A[i] = temp;
                MaxHeapify(ref A, Max, heapLength);
            }
        }

        private int Left(int i)
        {
            return (2 * i) + 1;
        }

        private int Right(int i)
        {
            return (2 * i) + 2;
        }

        private int Parent(int i)
        {
            return (i - 1) / 2;
        }


    }
}
