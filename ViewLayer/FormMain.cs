using System;
using System.Windows.Forms;
using Shared;

namespace ViewLayer
{
    public partial class FormMain : Form, IView<StudentArgs>
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public event EventHandler<StudentArgs> AddDataEvent = delegate { };
        public event EventHandler<int> DeleteDataEvent = delegate { };

        public void AddStudent(StudentArgs args) {
            listBox1.Items.Add($"{args.Name} {args.Speciality} {args.Group}");
        }
        public void DeleteStudent(int index) {
            listBox1.Items.RemoveAt(index);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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

            AddDataEvent?.Invoke(this, new StudentArgs
            {
                Name = name,
                Speciality = speciality,
                Group = group
            });

            textBoxName.Text = "";
            textBoxSpeciality.Text = "";
            textBoxGroup.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selected = listBox1.SelectedIndex;
            
            if (selected < 0)
            {
                MessageBox.Show("Выберите студента для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DeleteDataEvent?.Invoke(this, selected);

            listBox1.SelectedIndex = -1;
        }
    }
}
