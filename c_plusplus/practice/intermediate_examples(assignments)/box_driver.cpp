#include <iostream>

#include <iomanip>

#include "box.h"

using namespace std;

// ************************************************************

// * Sample Box Driver:                                       *

// * Tests your Box Class.  Makes a simple box and insures    *

// * that all of the public member functions that you should  *

// * have are defined and called properly.  Does not ckeck    *

// * default setttins or values out of bounds ( i.e. box      *

// * too big, too small, fill and border characters out of    *

// * range).                                                  *

// * Author: Dr. David Gaitros                                *

// * Date: March 24th, 2016                                   *

// ************************************************************

int main(void)

{

  Box mybox(5,'^','@');  // Box of size 5 with ^ and @ characters

  mybox.Draw();    // Draw the box

  mybox.Summary(); // Print Summary

  mybox.Grow();    // Grow the box

  mybox.Shrink();  // Shrink the box...should be 5 now.

  mybox.SetBorder('*');  // Set the border

  mybox.SetFill('#');   // Set Fill

  mybox.Draw();         // Show the new box.

  cout << "The size, area, and perimeter are" ;

  cout << setw(4) << mybox.GetSize();

  cout << setw(4) << mybox.Area();

  cout << setw(4) << mybox.Perimeter() << endl;



  return 0;

}
