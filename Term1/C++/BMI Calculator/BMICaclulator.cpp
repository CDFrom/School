#include<iostream>
#include<math.h>
#include<iomanip>
using namespace std;

int heightFeet, heightInches, massLbs;
float heightMeters, massKg, bmi;

float heightConversion(int feet, int inches);
float massConversion(int lbs);
float bmiCalculator(float massKg, float heightMeters);

int main()
{
	cout << "What is your height?" << endl;
	cout << "Feet: ";
	cin >> heightFeet;
	cout << "Inches: ";
	cin >> heightInches;
	heightMeters = heightConversion(heightFeet, heightInches);
	cout << "What is your weight (lbs)? ";
	cin >> massLbs;
	massKg = massConversion(massLbs);
	bmi = bmiCalculator(massKg, heightM);
	cout << endl;
	cout << "Height (m): " << fixed << setprecision(2) << heightM << endl;
	cout << "Weight (kg): " << fixed << setprecision(2) << massKg << endl;
	cout << "BMI: " << fixed << setprecision(2) << bmi << endl;

	return 0;
}

float heightConversion(int feet, int inches)
{
	float feetTotal, meters;
	feetTotal = feet + inches / 12.0;
	meters = feetTotal / 3.28084;

	return meters;
}

float massConversion(int lbs)
{
	// Return massKG
	return lbs / 2.20462;
}

float bmiCalculator(float massKg, float heightMeters)
{
	return massKg / pow(heightMeters, 2);
}
