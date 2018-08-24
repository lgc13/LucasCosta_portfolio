#include <iostream>
#include <Windows.h>  //gets me Sleep(time in ms units) system call

using namespace std;

int CountdownTentoZero(int x);

int main(void)
{
	int x=10;
	cout << "Countdown from: " << x << endl;
	CountdownTentoZero(x);
	return 0;
}
int CountdownTentoZero(int x)
{
	if(x==1) 
	{
		cout << "T-minus:  " << x << endl;
		Sleep(1000);
		cout << "Ignition"  << endl;
		return 0;
	}
	else
	{
		cout << "T-minus:  " << x << endl;
		Sleep(1000);  //why I #include <Windows.h> - we do something different for this in Unix
		return CountdownTentoZero(x-1);
	}
}