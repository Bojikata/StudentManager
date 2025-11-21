using System;

namespace StudentManager
{
    // Автор: Божидар Спасов
    // Факултетен номер: 113740
    // Класът Student описва един студент
    public class Student
    {
        // Пълно име на студента
        public string FullName { get; set; }

        // Факултетен номер
        public string FacultyNumber { get; set; }

        // Специалност
        public string Major { get; set; }

        // Конструктор - създава нов студент с име, фак. номер и специалност
        public Student(string fullName, string facultyNumber, string major)
        {
            FullName = fullName;
            FacultyNumber = facultyNumber;
            Major = major;
        }

        // Как да се показва студентът в списъка
        public override string ToString()
        {
            return $"{FullName} ({FacultyNumber}) - {Major}";
        }
    }
}
