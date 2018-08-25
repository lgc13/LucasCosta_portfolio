# MultiFunctionCalculator_project

<!-- Project BIO -->
For this console app, I created a small calculator which would take in a number from user input and perform a mathematical calculation to it depending on another choice given by the user. I also had to check the user input was not negative.

This application displays some of my skills with:

- switch statements
- user input validation
- function calls
- use of external libraries
- mathematical algorithms

<!-- Screenshot -->
<img src="MultiFunctionCalculator_project/img/calc_pic.png" width= 60% length= 60%>

<!-- Code explanation -->
I used a switch statement to call the specific function needed to be performed on the value given by the user input. By creating a few different "case numbers", that makes this code very easy to read, and edit.

<!-- Code snippet -->
You can see that in this code snippet:

```c++

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

```

<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/c++/" class="previous">&laquo; Back to C++ projects</a>
