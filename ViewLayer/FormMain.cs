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
    public partial class FormMain : Form
    {
        private IModel model = null;
        // private PresenterEmployee presenter;
        public FormMain()
        {
            InitializeComponent();
            model = new Model();
            // presenter = new PresenterEmployee(this, model);
        }
        public event EventHandler<EmployeeArgs> EventEmployeeAddView = delegate { };
    }
}
