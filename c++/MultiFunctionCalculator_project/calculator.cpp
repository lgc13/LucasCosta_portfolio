//Assignment 2 for COP class made by Lucas Costa

#include <iostream>
#include <cmath>

using namespace std;

void SquareRoot();
void Cube();
void Log();
void Inverse();
void AbsoluteValue();


int main(void)
{
        char running = 1;
        while (running ==1)
        {
                cout << " \n          M E N U     " << endl;
                cout << " 1 - Calculate Square Root" << endl;
                cout << " 2 - Calculate Cube" << endl;
                cout << " 3 - Calculate Natural Logarithm" << endl;
                cout << " 4 - Calculate Inverse" << endl;
                cout << " 5 - Calculate Absolute Value" << endl;
                cout << " 0 - Exit Program" << endl;
                cout << " ________________________________ \n" << endl;
                cout << "Enter menu option = ";

                char menu = ' ';
                cin >> menu;
                switch (menu)
                {
                case '1': SquareRoot();
                        break;
                case '2': Cube();
                        break;
                case '3': Log();
                        break;
                case '4': Inverse();
                        break;
                case '5': AbsoluteValue();
                        break;
                case '0': return 0;
                }
        }

        return 0;
}

void SquareRoot()
{
        int number = 0.0;
        cout << "Enter in a non-negative decimal number: ";
        cin >> number;
        while (number <0.0)

        {
                cout << "Please put in a number than is higher than 0 " << endl;
                cout << "Enter in a non-negative decimal number: ";
                cin >> number;
        }

        cout << "The square root of " <<number << " is " << sqrt(number) <<endl;

        return;
}

void Cube()
{
        int number = 0.0;
        cout << "Enter in a decimal number: ";
        cin >> number;
        cout << "The cube of " <<number << " is " << number*number*number <<endl;

        return;
}

void Log()
{
        int number = 0.0;
        cout << "Enter in a non-negative decimal number: ";
        cin >> number;
        while (number <0.0)

        {
                cout << "Please put in a number than is higher than 0 " << endl;
                cout << "Enter in a non-negative decimal number: ";
                cin >> number;
        }

        cout << "The natural log of " <<number << " is " << log(number) <<endl;

        return;
}

void Inverse()
{
        int number = 0.0;
        cout << "Enter in decimal number: ";
        cin >> number;
        cout << "The inverse of " <<number << " is " << 1.0/number <<endl;

        return;
}

void AbsoluteValue()
{
        int number = 0.0;
        cout << "Enter in decimal number: ";
        cin >> number;
        cout << "The absolute value of " <<number << " is " << fabs(number) <<endl;

        return;
}

// AND I'M DONE!!!!
