#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main(void)
{
        double number = 0.0;

        cout << "Enter in a positive floating point number ";
        cin >> number;

        while (number < 0.0)

                {
                        cout << "Dummy. Greater than or equal to zero " << endl;
                        cout << "Enter in a posivitve floating point number: ";
                        cin >> number;
                }

                cout << "The natural log of " << setw(10) << number << "is " << log(number) << endl;
        return 0;
}
