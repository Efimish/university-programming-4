using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Model : IModel
    {
        public IList<Employee> employees { get; set; } = new List<Employee>();
        public event EventHandler<EmployeeArgs> EventEmployeeAddModel = delegate { };
        public void AddEmployee(Employee employee) {
            employees.Add(employee);
            EventEmployeeAddModel(this, new EmployeeArgs(employee));
        }
    }
}
