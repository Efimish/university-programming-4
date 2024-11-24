using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayer
{
    public interface IView
    {
        void AddStudent(StudentArgs args);
        void DeleteStudent(int index);

        event EventHandler<StudentArgs> AddDataEvent;
        event EventHandler<int> DeleteDataEvent;
    }
}
