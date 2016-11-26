using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    public delegate void DuplicateAddedEventHandler();
    public class MyOrderedSet
    {
        private List<int> l;
        private HashSet<int> s;
        public event DuplicateAddedEventHandler DuplicateAddedEvent;

        public MyOrderedSet()
        {
            l = new List<int>();
            s = new HashSet<int>();
        }


        public void Add(int n)
        {
            if (s.Contains(n))
            {
                //Raise event
                RaiseEvent();
            }
            else
            {
                s.Add(n);
                l.Add(n);
            }
        }

        public void RaiseEvent()
        {
            if (DuplicateAddedEvent != null)
            {
                DuplicateAddedEvent();
            }
        }



    }
}
