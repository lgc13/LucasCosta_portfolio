#include <iostream>
#include <string>
using namespace std;


int SquareIT(const int x);

int main (void)
{
        cout << "The Square of 5 is " << SquareIT(5) << endl;
        DisplayMenu();
        cout << "Goodbye" << endl;

        return 0;
}

int SquareIT(const int x)
{
        return x*x;
}

void DisplayMenu()
{
        cout << "M E N U O P T I O N  " << endl;
        cout << "1 - Square root " << endl;
        cout << "2 - Cube" <<endl;
        cout << "0 = Exit" <<endl;
        cout << "_______________________________" <<endl;
        cout << "Option: " << endl;

        return;
}
