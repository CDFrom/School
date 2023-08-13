#include<iostream>
#include<iomanip>
#include<time.h>
using namespace std;

struct Fraction {
	int num;
	int den;
	double dec;

	void createFractions() {
		num = rand() % 20 + 1;
		den = rand() % 20 + 1;
		dec = 1.0 * num / den;
	}

	void displayFraction() {
		cout << "The fractional representation: " << num << "/" << den << endl;
	}

	void displayDecimal() {
		cout << "The decimal value: " << setprecision(2) << dec << endl << endl;
	}
};

int main()
{
	srand(time(0));
	Fraction frac[5];

	for (int i = 0; i < 5; i++) {
		frac[i].createFractions();
	}

	for (int i = 0; i < 5; i++) {
		frac[i].displayFraction();
		frac[i].displayDecimal();
	}

	return 0;
}
