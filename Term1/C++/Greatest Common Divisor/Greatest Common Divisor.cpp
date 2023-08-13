#include<iostream>
using namespace std;

int main()
{
	int n1;
	int n2;

	cout << "Enter first number: ";
	cin >> n1;

	cout << "Enter second number: ";
	cin >> n2;

	if (n1 <= n2)
	{
		for (int i = 0; i <= n1; i++)
		{
			if (n1 % (n1 - i) == 0 && n2 % (n1 - i) == 0)
			{
				cout << "The GCD of " << n1 << " and " << n2 << " is: " << n1 - i << endl;
				break;
			}
		}
	}
	else
	{
		for (int i = 0; i <= n2; i++)
		{
			if (n1 % (n2 - i) == 0 && n2 % (n2 - i) == 0)
			{
				cout << "The GCD of " << n1 << " and " << n2 << " is: " << n2 - i << endl;
				break;
			}
		}

	}

	return 0;
}
