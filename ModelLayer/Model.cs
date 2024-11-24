using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Model : IModel<Student>
    {
        private List<Student> _students = new List<Student>();
        public event EventHandler<StudentArgs> AddStudentEvent = delegate { };
        public event EventHandler<int> DeleteStudentEvent = delegate { };
        public void Add(Student student) {
            _students.Add(student);
            AddStudentEvent(this, new StudentArgs(student));
        }
        public void Delete(int index) {
            _students.RemoveAt(index);
            DeleteStudentEvent(this, index);
        }
    }
}
