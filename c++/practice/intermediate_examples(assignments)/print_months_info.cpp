//* Created and edit by Lucas Costa *

#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

void PrintMonth(const int month, const int startday, const bool leap);

int main(void)
{
        // ******************************************************************
        // * Print just a bunch of Random months - Assignment #3 *
        // ******************************************************************


        PrintMonth(1,0,false); // Print January 1st, on a Sunday
        PrintMonth(2,1,true); // Print February 1st leap year, on Monday
        PrintMonth(1,2,false); // Print January 1st, on a Tuesday
        PrintMonth(2,3,false); // Print February 1st not leap, on Wednesday
        PrintMonth(1,4,false); // Print January 1st, on a Thursday
        PrintMonth(2,5,false); // Print February 1st, on a Friday
        PrintMonth(1,6,false); // Print January 1st, on a Saturday
        PrintMonth(6,1,false); // Print June 1st, on Monday
        PrintMonth(12,4,false); // Print December 1st, on a Thursday

        return 0;
}

//Code below

void PrintMonth(const int month, const int startday, const bool leap)
{
        const string MONTHS[13] = {" ", "January", "February", "March", "April",
                                   "May", "June", "July", "August", "September",
                                    "October", "November","December" };
        int daysinmonth[13] = {0,31,28,31,30,31,30,31,31,30,31,30,31};
        if (leap == true)
            {
                daysinmonth[2] = 29;
            }


        // center months names
        int len = 0;
        string word = MONTHS[month];
        len = word.length();
        len = ((29 - len) / 2) + len;

        //print out month
        cout << setw(len) << MONTHS[month] << endl;

        cout << " SUN MON TUE WED THU FRI SAT" << endl;

        //startday parameter
        for (int space = 0; space < startday; space++)
          {
              cout << setw(4) << " ";
          }

        //days of the MONTHS
        for (int day = 1; day <= daysinmonth[month]; day++)
        {
                cout << setw(4) << day;
                if (day != daysinmonth[month] && (day+startday)%7 == 0) {
                        cout << endl;
                }
        }
        cout << endl;


}
