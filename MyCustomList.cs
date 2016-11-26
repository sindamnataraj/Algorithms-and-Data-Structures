using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    //sorted list in which duplicates cannot be added a

    //delegate is esentially a method type with certain type of input and output
    public delegate void Delegate_DuplicateAdded(int n);
    
    class MyCustomList
    {
        public event Delegate_DuplicateAdded Event_DuplicateIsAdded;
        private List<int> nums;
        public MyCustomList()
        {
            nums = new List<int>();
        }


        public void AddNum(int n)
        {
            if (nums.Contains(n))
            {
                RaiseEvent(n);
            }
            else {
                nums.Add(n);
            }
        }

        private void RaiseEvent(int n)
        {
            if (Event_DuplicateIsAdded != null)
            {
                Event_DuplicateIsAdded(n);
            }
        }

    }
}
