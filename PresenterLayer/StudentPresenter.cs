using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;
using ModelLayer;

namespace PresenterLayer
{
    public class StudentPresenter
    {
        private IView view = null;
        private IModel<Student> model = null;

        public StudentPresenter(IView view, IModel<Student> model)
        {
            this.view = view;
            this.model = model;

            view.AddDataEvent += AddStudentFromViewToModel;
            view.DeleteDataEvent += DeleteStudentFromViewToModel;

            model.AddStudentEvent += AddStudentFromModelToView;
            model.DeleteStudentEvent += DeleteStudentFromModelToView;
        }

        private void AddStudentFromModelToView(object sender, StudentArgs args)
        {
            view.AddStudent(args);
        }
        private void DeleteStudentFromModelToView(object sender, int index)
        {
            view.DeleteStudent(index);
        }
        private void AddStudentFromViewToModel(object sender, StudentArgs args)
        {
            model.Add(args.student);
        }
        private void DeleteStudentFromViewToModel(object sender, int index)
        {
            model.Delete(index);
        }
    }
}
