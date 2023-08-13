#include<iostream>
#include<ctime>
using namespace std;

int createNum() {
	return rand() % 10 + 1;
}

int main()
{
	srand(time(0));
	int input;
	string again;
	bool flag = true;

	while (flag) {
		int num = createNum();
		cout << "Guess a number between 1 and 10... ";
		cin >> input;
		if (input == num) {
			cout << "Correct! The number was " << num << ".\nWould you like to play again?" << endl;
		}
		else {
			cout << "Sorry... the number was " << num << ".\nWould you like to play again?" << endl;
		}
		cout << "[Y/N] ";
		cin >> again;
		cout << endl;
		while (again != "Y" && again != "N") {
			cout << "Please enter correct input...\n[Y/N] ";
			cin >> again;
		}
		if (again == "N") flag = false;
	}

	return 0;
}
