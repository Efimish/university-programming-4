using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class EmployeeArgs : EventArgs
    {
        public Employee employee { get; set; }
        public EmployeeArgs(Employee employee) {
            this.employee = employee;
        }
    }
}
