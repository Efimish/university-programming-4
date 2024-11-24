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
        event Action<EventArgs> AddDataEvent;
        event Action<int> DeleteDataEvent;

        void AddStudent(StudentArgs args);
        void DeleteStudent(int args);
        void RedrawForm(IEnumerable<EventArgs> args);
    }
}
