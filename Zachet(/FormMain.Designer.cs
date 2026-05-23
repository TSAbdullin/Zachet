namespace Zachet_
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvNotes = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reminderBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDeleteOne = new Button();
            buttonDeleteDone = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reminderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvNotes
            // 
            dgvNotes.AutoGenerateColumns = false;
            dgvNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotes.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dgvNotes.DataSource = reminderBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvNotes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvNotes.Dock = DockStyle.Bottom;
            dgvNotes.Location = new Point(0, 202);
            dgvNotes.Name = "dgvNotes";
            dgvNotes.ReadOnly = true;
            dgvNotes.Size = new Size(800, 248);
            dgvNotes.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            priorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reminderBindingSource
            // 
            reminderBindingSource.DataSource = typeof(Classes.Reminder);
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(137, 34);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(155, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(137, 34);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOne
            // 
            buttonDeleteOne.Location = new Point(298, 12);
            buttonDeleteOne.Name = "buttonDeleteOne";
            buttonDeleteOne.Size = new Size(137, 34);
            buttonDeleteOne.TabIndex = 3;
            buttonDeleteOne.Text = "Удалить";
            buttonDeleteOne.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDone
            // 
            buttonDeleteDone.Location = new Point(441, 12);
            buttonDeleteDone.Name = "buttonDeleteDone";
            buttonDeleteDone.Size = new Size(174, 34);
            buttonDeleteDone.TabIndex = 4;
            buttonDeleteDone.Text = "Удалить все выполненные";
            buttonDeleteDone.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteDone);
            Controls.Add(buttonDeleteOne);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dgvNotes);
            Name = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dgvNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)reminderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNotes;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource reminderBindingSource;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDeleteOne;
        private Button buttonDeleteDone;
    }
}
