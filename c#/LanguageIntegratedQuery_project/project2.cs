using System;
using System.Collections.Generic;
using System.Linq;

public class project2 //declared class
{
    public static void Main(String[] args)
    {
      DateTime dat = DateTime.Now;

      string requirements =
      @"
      ************************************************************
      Information and Requirements:
      Title: Project 2 - Using LINQ (Language Integrated Query)
      Author: Lucas Costa

      After completing the required tutorial, create the following programs:
        1) Prompt user for last name. Return full name, occupation, and age.

        2) Prompt user for age and occupation (Dev or Manager). Return full name.
          (Must include data validation on numeric data)

        3) Allow user to press any key to return back to command line

        Notes:
        - LINQ uses programming language syntax to query data.
        - LINQ uses SQL-like syntax to produce usable objects/
        - LINQ can be used to query many different types of data,
          including relational, XML, and even objects.
        **************************************************************
       ";
      Console.WriteLine(requirements);

      Console.WriteLine("  Now: {0:d}, {0:T}    ", dat);       //display current date and time
      //program starts
      var people = GenerateListOfPeople(); // create people list object

      Console.WriteLine("*** Finding items in collection ***");

      var peopleOverTheAgeOf30 = people.Where(x => x.Age > 30);
      Console.WriteLine("\nPeople over 30:");
      foreach(var person in peopleOverTheAgeOf30)
      {
        Console.WriteLine(person.FirstName);
      }

      Console.WriteLine("\nSkip first two people. People list:");
      IEnumerable<Person> afterTwo = people.Skip(2);
      foreach(var person in afterTwo)
      {
        Console.WriteLine(person.FirstName);
      }

      Console.WriteLine("\nTake first two people. People list:");
      IEnumerable<Person> takeTwo = people.Take(2);
      foreach(var person in takeTwo)
      {
        Console.WriteLine(person.FirstName);
      }

      Console.WriteLine("\n*** Changing Each Item in Collections ***");

      Console.WriteLine("\nSelect:");
      IEnumerable<string> allFirstNames = people.Select(x => x.FirstName);
      foreach(var firstName in allFirstNames)
      {
        Console.WriteLine(firstName);
      }

      Console.WriteLine("\nFullname class and objects:");
      IEnumerable<FullName> allFullNames = people.Select(x => new FullName { First = x.FirstName, Last = x.LastName });
      foreach(var fullName in allFullNames)
      {
        Console.WriteLine($"{fullName.Last}, {fullName.First}");
      }

      Console.WriteLine("\n*** Finding One Item in Collections ***");

      Console.WriteLine("\nFirst or default:");
      Person firstOrDefault = people.FirstOrDefault();
      Console.WriteLine(firstOrDefault.FirstName);

      Console.WriteLine("\nFirst or default as filter:");
      var firstThirtyYearOld1 = people.FirstOrDefault(x => x.Age == 30);
      var firstThirtyYearOld2 = people.Where(x => x.Age == 30).FirstOrDefault();
      Console.WriteLine(firstThirtyYearOld1.FirstName); //Will output "Brendan"
      Console.WriteLine(firstThirtyYearOld2.FirstName); //Will also output "Brendan"

      Console.WriteLine("\nHow ordefault works:");
      List<Person> emptyList = new List<Person>();
        Person willBeNull = emptyList.FirstOrDefault();

        //List<Person> people2 = GenerateListOfPeople();
        Person willAlsoBeNull = people.FirstOrDefault(x => x.FirstName == "John");

        Console.WriteLine(willBeNull == null); // true
        Console.WriteLine(willAlsoBeNull == null); //true

      Console.WriteLine("\nLastordefault as filter:");
      Person lastOrDefault = people.LastOrDefault();
        Console.WriteLine(lastOrDefault.FirstName);
        Person lastThirtyYearOld = people.LastOrDefault(x => x.Age == 30);
        Console.WriteLine(lastThirtyYearOld.FirstName);

      Console.WriteLine("\nSingleordefault as filter:");
      Person single = people.SingleOrDefault(x => x.FirstName == "Eric");
      Console.WriteLine(single.FirstName);

      Console.WriteLine("\n*** Finding Data About Collections ***");

      Console.WriteLine("\nCount():");
      int numberOfPeopleInList = people.Count();
      Console.WriteLine(numberOfPeopleInList);

      Console.WriteLine("\nCount() with predicate expression:");
      int peopleOverTwentyFive = people.Count(x => x.Age > 25);
      Console.WriteLine(peopleOverTwentyFive);

      Console.WriteLine("\nAny():");
      bool thereArePeople = people.Any();
      Console.WriteLine(thereArePeople);
      bool thereAreNoPeople = emptyList.Any();
      Console.WriteLine(thereAreNoPeople);

      Console.WriteLine("\nAll():");
      bool allDevs = people.All(x => x.Occupation == "Dev");
      Console.WriteLine(allDevs);
      bool everyoneAtLeastTwentyFour = people.All(x => x.Age >= 24);
      Console.WriteLine(everyoneAtLeastTwentyFour);

      Console.WriteLine("\n*** Converting Results to Collections ***");

      Console.WriteLine("\nToList():");
      List<Person> listOfDevs = people.Where(x => x.Occupation == "Dev").ToList(); //This will return a List<Person>

      foreach(var Person in listOfDevs)
      {
        Console.WriteLine(Person.FirstName);
      }

      Console.WriteLine("\nToArray():");
      Person[] arrayOfDevs = people.Where(x => x.Occupation == "Dev").ToArray(); //This will return a Person[] array
      foreach(var Person in arrayOfDevs)
      {
        Console.WriteLine(Person.FirstName);
      }

      Console.WriteLine("\n*** Required program ***");

      Console.WriteLine("\nNote: Searches are case sensitive");

      Console.Write("\nPlease enter the last name: ");
      string searchName = Console.ReadLine();
      Person Name = people.SingleOrDefault(x => x.LastName == searchName);
      if (Name != null)
      {
        Console.WriteLine("Matching criteria: " + Name.FirstName + " " + Name.LastName + " is a " + Name.Occupation + ", and is " + Name.Age + " years old.");
      }

      int input_age = 0;
      Console.Write("\nPlease enter age: ");
      while(!int.TryParse(Console.ReadLine(), out input_age))
      {
        Console.Write("Please input a numeric age: ");
      }

      Console.Write("\nPlease enter occupation: ");
      string occupation_input = Console.ReadLine();

      Person[] arrayOfAge = people.Where(x => x.Age == input_age).ToArray();
      Person[] arrayOfOccupation = arrayOfAge.Where(x => x.Occupation == occupation_input).ToArray();
      for (int i = 0; i < arrayOfOccupation.Length; i++)
      {
        Console.WriteLine("Matching criteria: " + arrayOfOccupation[i].FirstName + " " + arrayOfOccupation[i].LastName);
      }

      Console.WriteLine("\nPress any key to exit");
      Console.ReadKey();
    }

    public static List<Person> GenerateListOfPeople()
    {
      var people = new List<Person>();

      people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
      people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
      people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
      people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
      people.Add(new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });

      return people;
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
}

public class FullName
{
    public string First { get; set; }
    public string Last { get; set; }
}
