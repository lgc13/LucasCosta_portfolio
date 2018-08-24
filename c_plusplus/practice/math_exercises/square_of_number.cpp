#include <iostream>
#include <string>
using namespace std;
void SquareIt()
{
        int number = 0;
        cout << "Enter in a number to Square: ";
        cin >> number;
        cout << "The square of the number is: " << number*number <<endl;
        return;
}
int main (void)
{
        SquareIt();
        cout << "Goodbye" << endl;

        return 0;
}
