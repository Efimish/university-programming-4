using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;

namespace PresenterLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormMain view = new FormMain();
            //view.Show();

            Model model = new Model();

            StudentPresenter presenter = new StudentPresenter( view, model );

            System.Windows.Forms.Application.Run(view);
            //while (true) { }
        }
    }
}
