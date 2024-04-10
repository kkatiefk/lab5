using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_lab5
{
    public class School : EducationalInstitution
    {
    
        public int NumberOfClasses { get; set; }
        public School(string name, int students, int teachers, int classes) : base(name, students, teachers)
        {
            NumberOfClasses = classes;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"School: {Name}, Students: {NumberOfStudents}, Teachers: {NumberOfTeachers},  Classes: {NumberOfClasses}");
        }
    }
}
