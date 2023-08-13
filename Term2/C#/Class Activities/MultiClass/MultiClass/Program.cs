using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiClass
{
    class Course
    {
        int CourseID;
        string Title;
        string InstructorName;
        int CreditHours;

        public Course(int id, string title, string instructor, int creditHour)
        {
            CourseID = id;
            Title = title;
            InstructorName = instructor;
            CreditHours = creditHour;
        }

        public void Display()
        {
            Console.WriteLine($"Course ID: {CourseID}, Title: {Title}, Instructor Name: {InstructorName}, Credit Hours: {CreditHours}");
        }
    }
    class Student
    {
        int ID;
        string Name;
        double CGPA;
        List<Course> courseList;

        public Student(int id, string name, double cgpa)
        {
            ID = id;
            Name = name;
            CGPA = cgpa;
            courseList = new List<Course>();
        }

        public string GetName()
        {
            return Name;
        }

        public void RegisterACourse(Course newCourse)
        {
            courseList.Add(newCourse);
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, CGPA: {CGPA}");
            Console.WriteLine("Information about all registered courses: ");
            foreach(var course in courseList)
            {
                course.Display();
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Course OOP = new Course(1, "Object Oriented Programming", "Mickey Mouse", 3);
            OOP.Display();

            Course CG = new Course(2, "Computer Graphics", "Donald Duck", 3);
            CG.Display();

            Course MA = new Course(3, "Mobile Application Development", "Daisy Duck", 3);
            MA.Display();

            List<Student> stdList = new List<Student>();

            Student goofy = new Student(1000, "Goofy Goof", 3.75);
            //Console.WriteLine($"\n\nInformation about: {tareq.GetName()}");
            goofy.RegisterACourse(OOP);
            //tareq.Display();

            stdList.Add(goofy);

            Student max = new Student(1001, "Max Goof", 4.00);
            //Console.WriteLine($"\n\nInformation about: {alex.GetName()}");
            max.RegisterACourse(CG);
            max.RegisterACourse(MA);
            //alex.Display();
            stdList.Add(max);

            Student minnie = new Student(1002, "Minnie Mouse", 3.00);
            //Console.WriteLine($"\n\nInformation about: {selma.GetName()}");
            minnie.RegisterACourse(OOP);
            minnie.RegisterACourse(CG);
            minnie.RegisterACourse(MA);
            //selma.Display();
            stdList.Add(minnie);

            Console.WriteLine("\n\nInformation about all students: ");
            foreach(var std in stdList)
            {
                std.Display();
            }
        }
    }
}
