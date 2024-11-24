using ViewLayer;
using ModelLayer;
using Shared;

namespace PresenterLayer
{
    public class StudentPresenter
    {
        private IView<StudentArgs> view = null;
        private IModel<Student> model = null;

        public StudentPresenter(IView<StudentArgs> view, IModel<Student> model)
        {
            this.view = view;
            this.model = model;

            view.AddDataEvent += AddStudentFromViewToModel;
            view.DeleteDataEvent += DeleteStudentFromViewToModel;

            model.AddStudentEvent += AddStudentFromModelToView;
            model.DeleteStudentEvent += DeleteStudentFromModelToView;
        }

        private void AddStudentFromModelToView(object sender, Student student)
        {
            StudentArgs args = new StudentArgs
            {
                Name = student.Name,
                Speciality = student.Speciality,
                Group = student.Group,
            };
            view.AddStudent(args);
        }
        private void DeleteStudentFromModelToView(object sender, int index)
        {
            view.DeleteStudent(index);
        }
        private void AddStudentFromViewToModel(object sender, StudentArgs args)
        {
            Student student = new Student
            {
                Name = args.Name,
                Speciality = args.Speciality,
                Group = args.Group,
            };
            model.Add(student);
        }
        private void DeleteStudentFromViewToModel(object sender, int index)
        {
            model.Delete(index);
        }
    }
}
