using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public interface IModel
    {
        void AddEmployee(Employee employee);
        event EventHandler<EmployeeArgs> EventEmployeeAddModel;
    }
}
