using ModelLayer;
using ViewLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterLayer
{
    public class StudentPresenter
    {
        private IModel<Student> model = null;
        private IView view = null;

        public StudentPresenter(IView view, IModel<Student> model)
        {
            this.model = model;
            this.view = view;

            model.EventStudentAdd += AddStudentFromModelToView;
            model.EventStudentDelete += DeleteStudentFromModelToView;

            view.AddDataEvent += AddStudentFromViewToModel;
            view.DeleteDataEvent += DeleteStudentFromViewToModel;
        }

        private void OnModelDataChanged(IEnumerable<Student> students)
        {
            List<StudentArgs> args = new List<StudentArgs>();

            foreach (Student st in students)
            {
                args.Add(new StudentArgs(st));
            }
            view.RedrawForm(args);
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
 