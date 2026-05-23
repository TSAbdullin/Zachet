namespace Zachet_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSave = new Button();
            buttonCancel = new Button();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(538, 361);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(176, 39);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(106, 361);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(176, 39);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(249, 97);
            textBox1.MinimumSize = new Size(0, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 100);
            textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13F);
            dateTimePicker1.Location = new Point(249, 263);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(368, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(249, 215);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(368, 31);
            comboBox1.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(249, 316);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Выполнено";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.Location = new Point(249, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 31);
            textBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(94, 54);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(69, 48);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 8;
            label2.Text = "Название заметки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(69, 100);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 9;
            label3.Text = "Текст заметки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(78, 215);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 10;
            label4.Text = "Приоритет";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(78, 263);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 11;
            label5.Text = "Дата напоминания";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}