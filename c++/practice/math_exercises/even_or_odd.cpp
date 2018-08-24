#include <iostream>
#include <iomanip>
using namespace std;

int main(void)
{
	int x=0;

	cout <<"Input a number: ";
	cin >> x;

	if(x%2==0 )
	  cout <<"The number is even "<<endl;
	else
	  cout <<"It is a very odd number"<<endl;
	return 0;
}
