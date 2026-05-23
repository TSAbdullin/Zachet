using System.ComponentModel.Design;
using Zachet_.Classes;
using static System.Reflection.Metadata.BlobBuilder;

namespace Zachet_
{
    public partial class FormMain : Form
    {
        public List<Reminder> remindersList = Reminders.reminders;

        public FormMain()
        {
            InitializeComponent();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var formAdd = new Form2();
            formAdd.ShowDialog();

            dgvNotes.DataSource = null;
            dgvNotes.DataSource = remindersList;
        }

        private void buttonDeleteOne_Click(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow selectedRow = dgvNotes.SelectedRows[0];

            if (selectedRow.DataBoundItem is Reminder reminder)
            {
                remindersList.Remove(reminder);
            }

            dgvNotes.DataSource = null;
            dgvNotes.DataSource = remindersList;
        }

        private void buttonDeleteDone_Click(object sender, EventArgs e)
        {
            var allDoneToDelete = remindersList.Where(r => r.Status == true).ToList();

            foreach (var reminder in allDoneToDelete)
            {
                remindersList.Remove(reminder);
            }

            dgvNotes.DataSource = null;
            dgvNotes.DataSource = remindersList;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dgvNotes.DataSource = null;
            dgvNotes.DataSource = remindersList;
        }
    }
}
