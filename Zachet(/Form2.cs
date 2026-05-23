using System;
using Zachet_.Classes;
using Zachet_.Enums;

namespace Zachet_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Введите название заметки");
                return;
            }

            if (!Enum.TryParse(comboBox1.Text, out Priority date))
            {
                return;
            }

            var reminder = new Reminder(textBox2.Text, dateTimePicker1.Value, date, checkBox1.Checked);

            Reminders.reminders.Add(reminder);

            MessageBox.Show("Заметка создана!");

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
