#include<iostream>
using namespace std;

struct ComplexNumber {
	float real;
	float imaginary;
};

void addition(ComplexNumber n1, ComplexNumber n2)
{
	cout << "Addition = " << n1.real + n2.real;
	if (n1.imaginary + n2.imaginary >= 0)
		cout << "+";
	cout << n1.imaginary + n2.imaginary << "i" << endl;
}

void subtraction(ComplexNumber n1, ComplexNumber n2)
{
	cout << "Subtraction = " << n1.real - n2.real;
	if (n1.imaginary - n2.imaginary >= 0)
		cout << "+";
	cout << n1.imaginary - n2.imaginary << "i" << endl;
}

void multiplication(ComplexNumber n1, ComplexNumber n2)
{
	cout << "Multiplication = " << n1.real * n2.real - n1.imaginary * n2.imaginary;
	if (n1.real * n2.imaginary + n1.imaginary * n2.real >= 0)
		cout << "+";
	cout << n1.real * n2.imaginary + n1.imaginary * n2.real << "i" << endl;
}

int main()
{
	ComplexNumber n1, n2;
	cout << "Enter real and imaginary parts only.\nPlease separate inputs by space or enter key.\nDo not use 'i' after the complex part, thank you." << endl;
	cout << "\nPlease enter the first complex number: ";
	cin >> n1.real >> n1.imaginary;
	cout << "Please enter the second complex number: ";
	cin >> n2.real >> n2.imaginary;
	cout << endl;

	addition(n1, n2);
	subtraction(n1, n2);
	multiplication(n1, n2);

	return 0;
}
