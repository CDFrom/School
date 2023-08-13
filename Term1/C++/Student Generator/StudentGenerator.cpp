#include<iostream>
#include<ctime>
using namespace std;

struct Student {
	int id;
	string name;
	int marks[5];
	float average;

	void randomlyPopulate()
	{
		id = rand() % 900 + 100;

		char c;
		int nameLen = rand() % 5 + 4;
		name = "";
		for (int i = 0; i < nameLen; i++)
		{
			c = rand() % 26 + 'A';
			name += c;
		}

		average = 0;
		for (int i = 0; i < 5; i++)
		{
			marks[i] = rand() % 81 + 20;
			average += marks[i];
		}
		average /= 5.0;
	}

	void displayStudent()
	{
		cout << "Student Id: " << id << ", Name: " << name << ", Average Mark: " << average << endl;
		cout << "Subject marks: ";
		for (int i = 0; i < 5; i++)
		{
			cout << marks[i] << ", ";
		}
		cout << "\b\b " << endl;
	}

	void checkFails()
	{
		int fails = 0;
		for (int i = 0; i < 5; i++)
		{
			if (marks[i] < 40)
			{
				fails++;
			}
		}
		if (fails >= 2)
		{
			displayStudent();
		}
	}
};

void sortAverage(Student s[], int n)
{
	Student temp;

	for (int i = 0; i < n; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (s[i].average < s[j].average)
			{
				temp = s[i];
				s[i] = s[j];
				s[j] = temp;
			}
		}
	}
}

int main()
{
	int num;
	cout << "Please enter total number of students: ";
	cin >> num;
	Student stu[num];
	srand(time(0));

	for (int i = 0; i < num; i++)
	{
		stu[i].randomlyPopulate();
	}

	cout << "\nStudents:" << endl;
	for (int i = 0; i < num; i++)
	{
		stu[i].displayStudent();
	}

	cout << "\nList of students sorted according to their average mark:" << endl;
	sortAverage(stu, num);
	for (int i = 0; i < num; i++)
	{
		stu[i].displayStudent();
	}

	cout << "\nList of students who failed more than one subject:" << endl;
	for (int i = 0; i < num; i++)
	{
		stu[i].checkFails();
	}

	return 0;
}
