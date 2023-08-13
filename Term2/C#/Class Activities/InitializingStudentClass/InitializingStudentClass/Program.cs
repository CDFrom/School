using System;   // Starter Code
namespace Programming_Fundamentals
{
	public class Student
	{   // Add access modifiers
		public int ID;
		public string FName;
		public string LName;
		public string Department;
		public string Year;
		public string Email;

		// Add Constructor methods
		public Student()
        {
			ID = 0;
			FName = LName = Department = Year = Email = "";
        }
		public Student(int id, string fName, string lName, string department, string year, string email)
        {
			ID = id;
			FName = fName;
			LName = lName;
			Department = department;
			Year = year;
			Email = email;
        }

		public void DisplayStudentInformation() // The display method
		{
			Console.WriteLine("\nStudent Name: " + FName + " " + LName);
			Console.WriteLine("Student ID: " + ID);
			Console.WriteLine("Department: " + Department);
			Console.WriteLine("Study Year: " + Year);
			Console.WriteLine("e-mail address: " + Email);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{   // ToDo: Instatiation object using default constructor and initialize fields by accessing them
			var std1 = new Student();
			std1.ID = 111;
			std1.FName = "Harry";
			std1.LName = "Potter";
			std1.Department = "Potions";
			std1.Year = "Third";
			std1.Email = "HPotter@Hogwarts.net";

			// ToDo: object initialization using parameterized constructor
			var std2 = new Student(222, "Ronald", "Weasley", "Defense Against the Dark Arts", "Fourth", "RWeasley@Hogwarts.net");

			// ToDo: initialization using object initializers
			var std3 = new Student() { LName = "Granger", FName = "Hermione", ID = 333, Email = "HGranger@Hogwarts.net", Year = "First", Department = "Herbology" };

			std1.DisplayStudentInformation();
			std2.DisplayStudentInformation();
			std3.DisplayStudentInformation();
		}
	}
}