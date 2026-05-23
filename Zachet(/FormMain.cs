using System.ComponentModel.Design;
using Zachet_.Classes;

namespace Zachet_
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var formAdd = new Form2();
            formAdd.ShowDialog();
        }
    }
}
