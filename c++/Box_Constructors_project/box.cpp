#include <iostream>
#include <iomanip>
#include "box.h"

/***********************************************************/
/*                constructor implementation              */
/* making sure the size is within 1 - 39, and setting     */
/* the denitions for border and fill chars                */
/***********************************************************/
Box::Box(int size, char BorderCharacter, char FillCharacter)  //constructor imprementation
{
  if (size < 1)
  {
    size = 1;
  }
  else if (size > 39)
  {
    size = 39;
  }
  _size = size;
  _BorderCharacter = BorderCharacter;
  _FillCharacter = FillCharacter;
}

/***********************************************************/
/*                constructor implementation              */
/* making sure the size is within 1 - 39, and setting     */
/* the denitions for border and fill chars                */
/***********************************************************/
Box::Box(int size)
{
  if (size < 1)
  {
    size = 1;
  }
  else if (size > 39)
  {
    size = 39;
  }
  _size = size;
  _BorderCharacter = '#';
  _FillCharacter = '*';
}

/***********************************************************/
/*                GetSize function                          */
/* used to return the size of each box                       */
/* this will be used afterward as this is called for returned*/
/***********************************************************/
int Box::GetSize()
{
  return _size;
}

/***********************************************************/
/*                Perimeter function                          */
/* used to return the perimeter of each box                       */
/* this will be used afterward as this is called for returned*/
/***********************************************************/
int Box::Perimeter()
{
  return _size * 4;
}

/***********************************************************/
/*                Area function                          */
/* used to return the area of each box                       */
/* this will be used afterward as this is called for returned*/
/***********************************************************/
int Box::Area()
{
  return _size * _size;
}

/***********************************************************/
/*                Grow function                          */
/* used to grow the size of the box by 1                   */
/* not actually used in this, but still requried           */
/***********************************************************/
void Box::Grow()
{
  cout << "Growing the size of the box" << endl;
  if (_size >= 1 || _size < 39)
  {
    _size++;
  }
}

/***********************************************************/
/*               Shrink function                          */
/* used to shrink the size of the box by 1                   */
/* not actually used in this, but still requried           */
/***********************************************************/
void Box::Shrink()
{
  cout << "Shrinking the size of the box" << endl;
  if (_size > 1 || _size <= 39)
  {
    _size--;
  }
}

/***********************************************************/
/*                SetBorder function                          */
/* sets the border to whatever was passed in                   */
/* otherwise sets it equal to default border char           */
/***********************************************************/
void Box::SetBorder(char NewBorderChar)
{
  cout << "Setting a new border..." << endl;
  if ((NewBorderChar - '!') >= 0 && (NewBorderChar - '~') <= 126)
  {
  _BorderCharacter = NewBorderChar;
  }
  else
  {
    _BorderCharacter = '#';
  }
}

/***********************************************************/
/*                SetFill function                          */
/* sets the fill chars to whatever was passed in                   */
/* otherwise sets it equal to default fill char           */
/***********************************************************/
void Box::SetFill(char NewFillChar)
{
  cout << "Setting a new fill..." << endl;
  if ((NewFillChar - '!') >= 0 && (NewFillChar - '~') <= 126)
  {
    _FillCharacter = NewFillChar;
  }
  else
  {
    _FillCharacter = '*';
  }
}

/***********************************************************/
/*                Draw function                          */
/* this draws out the boxes. Has for loops                 */
/* to print out the border and fill chars         */
/***********************************************************/
void Box::Draw()
{
  for (int i = 0; i < _size; i++)
  {
    cout << _BorderCharacter << " ";
  }
  cout << endl;

  for (int i = 0; i < _size - 2; i++)
  {
    cout << _BorderCharacter << " ";
    for (int j = 0; j < (_size - 2); j++)
    {
      cout << _FillCharacter << " ";
    }
    cout << _BorderCharacter << endl;
  }

  for (int i = 0; i < _size; i++)
  {
    cout << _BorderCharacter << " ";
  }
  cout << endl;

}

/***********************************************************/
/*                Summary function                          */
/*  this calls upon all the other implementations and functions */
/* prints out size, perimeter, area, and boxes          */
/***********************************************************/
void Box::Summary()
{
  cout << "The box size is: " << _size << endl;
  cout << "The box perimeter is: " << Perimeter() << endl;
  cout << "The area is: " << Area() << endl;
  cout << endl;
}
