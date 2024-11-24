using System;
using System.Collections.Generic;
using Shared;

namespace ModelLayer
{
    public class Model : IModel<Student>
    {
        private List<Student> _students = new List<Student>();
        public event EventHandler<Student> AddStudentEvent = delegate { };
        public event EventHandler<int> DeleteStudentEvent = delegate { };

        public void Add(Student student) {
            _students.Add(student);
            AddStudentEvent?.Invoke(this, student);
        }
        public void Delete(int index) {
            _students.RemoveAt(index);
            DeleteStudentEvent?.Invoke(this, index);
        }
    }
}
