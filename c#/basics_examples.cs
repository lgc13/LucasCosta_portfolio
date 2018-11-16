using System;
using System.Collections.Generic;

class BasicsExamples
{
  public static void Main(string[] args)
  {
      Console.WriteLine("\t\t1- PRINT TO TERMINAL: 'Console.Write()' ");

      Console.WriteLine("\t\t2- For loops:");
      for (int i = 0; i < 3; i++) {
          Console.WriteLine("i is: " + i);
      }

      Console.WriteLine("\t\t3- LISTS: (You have to specify what type it is, and import System.Collections.Generic)");
      List<string> lucas_list = new List<string>();

      Console.WriteLine("List size: " + lucas_list.Count);

      lucas_list.Add("Lucas");
      lucas_list.Add("Sasha");
      Console.WriteLine("Edited list size: " + lucas_list.Count);

      Console.WriteLine("\t\t4- FOR EACH LOOPS:");
      foreach (string person in lucas_list) {
        Console.WriteLine("Item: " + person );
      }

      Console.WriteLine("\tBONUS: Nested FOR LOOP");
      for (int i = 1; i <= 5; i++) { //i = 2, is i(2) <= 5, TRUE

				for (int j = 1; j <= i; j++) // j = 2, is j <= i(1) TRUE
				{
					Console.Write(j + " ");  // print out j(1) + " "=  1 " "
        }
        Console.WriteLine();
			}

      Console.WriteLine("\t\t5- DICTIONARY");
      Dictionary<int, string> my_dict = new Dictionary<int, string>();
      my_dict.Add(1, "Burrito Border");
      my_dict.Add(2, "Qdoba");
      // Console.WriteLine("my_dict: ");

      // for (int i = 0; i < my_dict.Count; i++) {
      //   Console.WriteLine("Key: " + i + ", Value: " + my_dict[i + 1]);
      // }
      foreach (KeyValuePair<int, string> entry in my_dict) {
          Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
      }
  }
}
