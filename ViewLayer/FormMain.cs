using ModelLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayer
{
    public partial class FormMain : Form, IView
    {
        private List<Student> _students = new List<Student>();
        public FormMain()
        {
            InitializeComponent();
        }

        public event EventHandler<StudentArgs> AddDataEvent;
        public event EventHandler<int> DeleteDataEvent;

        public void AddStudent(StudentArgs args) {
            _students.Add(args.student);
        }
        public void DeleteStudent(int index) {
            _students.RemoveAt(index);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Student s in _students)
            {
                listBox1.Items.Add(s);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string speciality = textBoxSpeciality.Text;
            string group = textBoxGroup.Text;

            if (name.Length == 0 || speciality.Length == 0 || group.Length == 0)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddDataEvent(this, new StudentArgs(new Student
            {
                Name = name,
                Speciality = speciality,
                Group = group
            }));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selected = listBox1.SelectedIndex;

            DeleteDataEvent(this, selected);
        }
    }
}
