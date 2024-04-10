using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_lab5
{
    public abstract class EducationalInstitution
    {
        public string Name { get; set; }
        public int NumberOfStudents { get; set; }
        public int NumberOfTeachers { get; set; }

        public EducationalInstitution(string name, int students, int teachers)
        {
            Name = name;
            NumberOfStudents = students;
            NumberOfTeachers = teachers;
            
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Number of Students: {NumberOfStudents}, Number of Teachers: {NumberOfTeachers}");
        }
    }
}
