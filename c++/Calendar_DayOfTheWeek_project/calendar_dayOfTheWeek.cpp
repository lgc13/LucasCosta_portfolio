#include <iostream>
#include <string>
using namespace std;

int main(void)
{
	string Days[7]={ "Sunday","Monday","Tuesday","Wednesday","Thursday",
	"Friday","Saturday"};
	int a=0, month=1, year=1995, y=0, day=1, m=0, d=0;

// **********************************************************************
// * Gregorian Calendar       *
// * Edited by Lucas Costa
// **********************************************************************

	cout << "Enter Month: ";
	cin >> month;
	cout <<endl << "Enter in the day (1...31): ";
	cin >> day;
	cout << endl <<"Enter in the Year (>1582): ";
	cin >> year; \

a = (14-month)/12;
y=year-a;
m = month+12*a-2;
d = (day+y+y/4-y/100+y/400+(31*m/12))%7;


	//Print out a statement asking for month, and read in month.
	//Print out a statement asking for the day, and read in the day.
	//Print out a statement asking for the year, and read in the year.
	//Put the formula here to calculate the day of the week.

 cout <<endl <<"The Date: "<<month<<"/"<<day<<"/"<<year
 <<" Falls on a: "<< Days[d]<<endl;
 return 0;
}
