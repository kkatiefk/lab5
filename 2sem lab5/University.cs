using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2sem_lab5
{
    public class University: EducationalInstitution
    {
        public int FacultiesCount { get; set; }

        public University(string name, int students, int teachers, int faculties) : base(name, students, teachers)
        {
            {
                FacultiesCount = faculties;
            }
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"University: {Name}, Students: {NumberOfStudents}, Teachers: {NumberOfTeachers},  Faculties: {FacultiesCount}");
        }
    }
}
