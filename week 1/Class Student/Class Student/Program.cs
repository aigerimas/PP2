using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student
{
    class Student
    {

        private string name;
        private string surname;
        private int attestation;
        public Student() : this("None", "None", 0)
        {

        }
        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Student(string name, string surname, int attestation)
        {
            this.name = name;
            this.surname = surname;
            this.attestation = attestation;
        }
        public Student(Student s) : this(s.name, s.surname, s.attestation)
        {

        }
        public void SetMark(int mark)
        {
            attestation += mark;
        }
        public override string ToString()
        {
            return this.name + " " + surname + " " + attestation;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(name: "Karzhas", surname: "Tokbolatov");
            student1.SetMark(30);
            student1.SetMark(30);
            student1.SetMark(40);
            Console.WriteLine(student1);
            Student empty_student = new Student();
            Console.WriteLine(empty_student);
            empty_student = student1;
            Console.WriteLine(empty_student);
            Console.ReadKey();
        }
    }
}
