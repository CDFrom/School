#include<iostream>
using namespace std;

int main()
{
	string studentName;
	string studentAddress;
	int age;
	double cgpa;

	cout << "Please enter your name: " << endl;
	getline(cin, studentName);

	cout << "Please enter your age: " << endl;
	cin >> age;

	cout << "Please enter your CGPA: " << endl;
	cin >> cgpa;

	cout << "Please enter your address: " << endl;
	cin.ignore();
	getline(cin, studentAddress);

	cout << studentName << " who lives in " << studentAddress
		<< " is " << age << " years old; \n"
		<< " has a great CGPA: " << cgpa << endl;

	return 0;
}
