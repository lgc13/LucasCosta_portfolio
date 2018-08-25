<!-- Project section -->
<h2><a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/c%23/CreateRoom_objectCalculator_project">1- Create Room Calculator</a></h2>

<!-- Project BIO -->
This application creates different "Room" objects, by asking user input for information such as a Room name, length, width, and height. Afterwards, methods are called in order to return attribute values about this Room, such as its name, area, volume in cubed feet and in cubed yards. It also provides information about a default Room (from default constructor properties.)

This application displays some of my skills with:

- polymorphism: method overloading
- encapsulation: keeping private data hidden
- abstraction: calling methods from a class in a separate file
- use of default constructor, getter and setter methods
- mathematical algorithms

<!-- Screenshots -->
<img src="img/room_calculator.png" width= 80% length= 80%>
<img src="img/room_calculator2.png" width= 80% length= 80%>

<!-- Code explanation -->
I use Setter method calls from my main .cs file in order to change a given Room's attributes, such as their length, width, and height. The Setter methods have default values which if not changed, will be used by the default constructor of this program.

<!-- Code snippet -->
You can see that in this code snippet:

```c#

public void SetLength(double l = 0.0)
{ //setter method
  this.roomLength = l;
}

public void SetWidth(double w = 0.0)
{ //setter method
  this.roomWidth = w;
}

public void SetHeight(double h = 0.0)
{ //setter method
  this.roomHeight = h;
}


roomObject2.SetLength(rLength);
roomObject2.SetWidth(rWidth);
roomObject2.SetHeight(rHeight);

```

<!-- Back to Projects folder -->
<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/c#/" class="previous">&laquo; Back to C# projects</a>
