#include <iostream>
#include <iomanip>
#include "box.h"

using namespace std;

//  Date: March 24th, 2016

int main(void)

{
  cout << "Creating a box..." << endl;
  Box mybox(5,'^','@');  // Box of size 5 with ^ and @ characters

  mybox.Draw();    // Draw the box
  mybox.Summary(); // Print Summary

  mybox.Grow();    // Grow the box
  mybox.Grow();    // Grow the box
  mybox.Draw();    // Draw the box
  mybox.Summary(); // Print Summary

  mybox.Shrink();  // Shrink the box...
  mybox.SetBorder('*');  // Set the border
  mybox.SetFill('#');   // Set Fill
  mybox.Draw();    // Draw the box
  mybox.Summary(); // Print Summary


  // cout << "The size, area, and perimeter are" ;
  //
  // cout << setw(4) << mybox.GetSize();
  //
  // cout << setw(4) << mybox.Area();
  //
  // cout << setw(4) << mybox.Perimeter() << endl;

  return 0;

}
