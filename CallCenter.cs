using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    class CallCenter
    {
    }

    public class Employee {
        public int empId { get; set; }
        public Employee(int Id)
        {
            empId = Id;
        }
    }

    public class Respondent : Employee {

        public Respondent(int Id) : base(Id)
        {
        }
    }
    public class Manager : Employee {
        public Manager(int Id) : base(Id)
        {

        }
    }
    public class Director:Employee {
        public Director(int Id) : base(Id)
        {

        }
    }
}
