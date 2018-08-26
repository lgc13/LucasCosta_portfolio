# LINQ - Language Integrated Query project

<!-- Project BIO -->
This project demonstrates how someone can use LINQ - Language Integrated Query to interact with data. It can be used to query many different types of data including relational, XML, and even objects. LINQ uses uses SQL-like syntax to produce usable objects.

This application displays some of my skills with:

- LINQ methods
- Using SQL-like syntax expressions
- querying through objects and lists
- manipulation of arrays through for and foreach loops
- user input validation

<!-- Screenshots -->
<img src="img/program.png" width= 80% length= 80%>

<!-- Code explanation -->
By importing the LINQ library, I have access to the SingleOrDefault method. This returns the only element of a sequence, or a default value if the sequence is empty. I use this in order to search in 'people' for a specific person who has last name given by the user. I can then return that entire object's information attributes from this simple search.

<!-- Code snippet -->
You can see that in this code snippet:

```c#

Console.Write("\nPlease enter the last name: ");
string searchName = Console.ReadLine();
Person Name = people.SingleOrDefault(x => x.LastName == searchName);
if (Name != null)
{
  Console.WriteLine("Matching criteria: " + Name.FirstName + " " + Name.LastName + " is a " + Name.Occupation + ", and is " + Name.Age + " years old.");
}

```

<!-- Back to Projects folder -->
<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/c%23/" class="previous">&laquo; Back to C# projects</a>
