namespace StudentManager
{
    partial class Form1
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
            label1 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtMajor = new TextBox();
            txtFacultyNumber = new TextBox();
            lstStudents = new ListBox();
            btnAddStudent = new Button();
            btnDeleteStudent = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 70);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Име";
            label1.Click += label1_Click_1;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(6, 44);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(168, 23);
            txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 70);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "Факултетен номер";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(566, 70);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 3;
            label3.Text = "Специалност";
            label3.Click += label3_Click;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(528, 44);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(168, 23);
            txtMajor.TabIndex = 4;
            txtMajor.TextChanged += txtMajor_TextChanged;
            // 
            // txtFacultyNumber
            // 
            txtFacultyNumber.Location = new Point(271, 44);
            txtFacultyNumber.Name = "txtFacultyNumber";
            txtFacultyNumber.Size = new Size(168, 23);
            txtFacultyNumber.TabIndex = 5;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(514, 160);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(222, 259);
            lstStudents.TabIndex = 6;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(305, 235);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(172, 23);
            btnAddStudent.TabIndex = 7;
            btnAddStudent.Text = "Добави";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(305, 264);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(172, 23);
            btnDeleteStudent.TabIndex = 8;
            btnDeleteStudent.Text = "Изтрий";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(txtFacultyNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMajor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(34, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 106);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данни за студент";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(lstStudents);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Система за студенти - Божидар F113740";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private Label label3;
        private TextBox txtMajor;
        private TextBox txtFacultyNumber;
        private ListBox lstStudents;
        private Button btnAddStudent;
        private Button btnDeleteStudent;
        private GroupBox groupBox1;
    }
}
