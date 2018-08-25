# Box_Constructors_project

<!-- Project BIO -->
For this application, I first created a Box object. Then I used different classes to access and modify this object, using methods such as grow, shrink, draw, getArea, and getPerimeter (among other functions.) The class was kept in a separate file with all the prototypes and the constructors.

This application displays some of my skills with:

- object oriented programming
- use of constructors
- method overloading
- classes across different files
- math algorithms

<!-- Screenshot -->
<img src="Box_Constructors_project/img/box_example.png" width= 60% length= 60%>

<!-- Code explanation -->
I kept the boxes attributes as private on a separate class. In addition, there was another class which held a basic method to print out the summary information of a given box, called Summary(). I instantiated the object from the main driver file.

<!-- Code snippet -->
You can see that in this code snippet:

```c++

Box mybox(5,'^','@');

private:                
  int size;
  char BorderCharacter;
  char FillCharacter;

void Box::Summary()
{
  cout << "The box size is: " << size << endl;
  cout << "The box perimeter is: " << Perimeter() << endl;
  cout << "The area is: " << Area() << endl;
  cout << endl;
}

```

<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/c++/" class="previous">&laquo; Back to C++ projects</a>
