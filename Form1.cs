using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManager
{
    // Основна форма на приложението за управление на студенти
    public partial class Form1 : Form
    {
        // Списък с всички добавени студенти
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        // бутона "Добави студент"
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Четем данните от текстовите полета
            string fullName = txtFullName.Text.Trim();
            string facultyNumber = txtFacultyNumber.Text.Trim();
            string major = txtMajor.Text.Trim();

            // Проверяваме дали всички полета са попълнени
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(facultyNumber) ||
                string.IsNullOrWhiteSpace(major))
            {
                MessageBox.Show("Моля, попълнете всички полета.");
                return;
            }

            // Създаваме нов обект Student
            Student student = new Student(fullName, facultyNumber, major);

            // Добавяме студента в списъка и в ListBox-а
            students.Add(student);
            lstStudents.Items.Add(student);

            // Изчистваме полетата и връщаме курсора в първото
            txtFullName.Clear();
            txtFacultyNumber.Clear();
            txtMajor.Clear();
            txtFullName.Focus();
        }

        // бутона "Изтрий избрания"
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            // Проверяваме дали има избран студент в ListBox-а
            if (lstStudents.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете студент.");
                return;
            }

            // Вземаме избрания студент
            Student selectedStudent = (Student)lstStudents.SelectedItem;

            // Премахваме го от списъка и от ListBox-а
            students.Remove(selectedStudent);
            lstStudents.Items.Remove(selectedStudent);
        }

        // Празен обработчик за label1, ако дизайнерът още го изисква
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMajor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
