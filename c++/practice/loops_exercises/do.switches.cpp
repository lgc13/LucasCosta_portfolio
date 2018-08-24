#include <iostream>
#include <string>
using namespace std;

int main (void)

{
	int count = 0;
	cout << "enter number :";
	cin >> count;
	do
	{
		cout << "Enter in a number: ";
		cin >> count;
		cout << "enter in " <<count << endl;
	} while (count < 3);


	return 0;
}
