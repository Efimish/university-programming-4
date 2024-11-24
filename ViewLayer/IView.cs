using System;

namespace ViewLayer
{
    public interface IView<A>
        where A : EventArgs
    {
        void AddStudent(A args);
        void DeleteStudent(int index);

        event EventHandler<A> AddDataEvent;
        event EventHandler<int> DeleteDataEvent;
    }
}
