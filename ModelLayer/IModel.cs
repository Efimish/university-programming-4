using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public interface IModel<T>
        where T : class
    {
        void Add(T item);
        void Delete(int index);


        event EventHandler<T> AddStudentEvent;
        event EventHandler<int> DeleteStudentEvent;
    }
}
