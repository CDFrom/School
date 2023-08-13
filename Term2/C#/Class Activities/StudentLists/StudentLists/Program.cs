using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLists
{
    class Student
    {
        public int Id;
        public string Name;
        public double Cgpa;

        public Student()
        {

        }

        public Student(int id, string name, double cgpa)
        {
            Id = id;
            Name = name;
            Cgpa = cgpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stdObj = new Student();
            stdObj.Name = "Tareq";
            stdObj.Cgpa = 3.95;
            stdObj.Id = 12345;

            Student std2Obj = new Student(11111, "David", 4.0);

            Student std3Obj = new Student() { Name = "Harry", Cgpa = 3.99, Id = 77777 };

            List<Student> stdList = new List<Student>();

            stdList.Add(stdObj);
            stdList.Add(std2Obj);
            stdList.Add(std3Obj);
            stdList.Add(new Student() { Cgpa = 3.90, Id = 22222, Name = "Max" });

            foreach(var std in stdList)
            {
                Console.WriteLine("Name: {0}, ID: {1}, CGPA: {2}", std.Name, std.Id, std.Cgpa);
            }
        }
    }
}
