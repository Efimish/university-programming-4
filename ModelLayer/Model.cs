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
        public event EventHandler<StudentArgs> EventStudentAdd = delegate { };
        public event EventHandler<int> EventStudentDelete = delegate { };
        public void Add(Student student) {
            _students.Add(student);
            EventStudentAdd(this, new StudentArgs(student));
        }
        public void Delete(int index) {
            _students.RemoveAt(index);
            EventStudentDelete(this, index);
        }
    }
}
