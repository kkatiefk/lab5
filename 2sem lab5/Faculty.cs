using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_lab5
{
    public class Faculty: EducationalInstitution
    {
        public int YearOfFoundation { get; set; }

        public Faculty(string name, int students, int teachers, int yearoffoundation) : base(name, students, teachers)
        {
            YearOfFoundation = yearoffoundation;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Number of Students: {NumberOfStudents}, Number of Teachers: {NumberOfTeachers}, Year of foundation: {YearOfFoundation}");
        }
    }
}
