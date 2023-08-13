#include<iostream>
#include<iomanip>
using namespace std;

int main()
{
	float bill, tax, tip;
	int numOfPeople;

	cout << "How much is the bill? ";
	cin >> bill;

	cout << "How much is the tax (%)? ";
	cin >> tax;
	tax /= 100;

	cout << "How much is the tip (%)? ";
	cin >> tip;
	tip /= 100;

	cout << "How many people are paying? ";
	cin >> numOfPeople;
	cout << endl;

	cout << "Bill before tax: $" << fixed << setprecision(2) << bill << endl;
	bill = bill * (1 + tax);
	cout << "Bill after tax: $" << fixed << setprecision(2) << bill << endl;
	bill = bill * (1 + tip);
	cout << "Bill after tip: $" << fixed << setprecision(2) << bill << endl;
	bill = bill / numOfPeople;
	cout << "Bill per person: $" << fixed << setprecision(2) << bill << endl;

	return 0;
}
