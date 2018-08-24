#include <iostream>

using namespace std;

int main (void)
{
	char grade = ' ';
	cout << "Start of Program" << endl;
	cin >> grade;
	switch (grade)

	{
		case 'A': case 'a':
		   cout << "Great job...parents would be proud" <<endl;
		   break;
		case 'B': case 'b':
		   cout << "Also a good job" <<endl;
		   break;
		case 'C': case 'c':
                   cout << "Ah you passed" <<endl;
                   break;
		default:
		cout << "Well that sucks" << endl;
	}
	return 0;
}
