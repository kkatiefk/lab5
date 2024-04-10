using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_lab5
{
    public class Cathedra : EducationalInstitution
    {
        public string DeanName { get; set; }


        public Cathedra(string name, int students, int teachers, string deanname) : base(name, students, teachers)
        {
            DeanName = deanname;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Number of Students: {NumberOfStudents}, Number of Teachers: {NumberOfTeachers}, Dean name: {DeanName}");
        }
    }
}
