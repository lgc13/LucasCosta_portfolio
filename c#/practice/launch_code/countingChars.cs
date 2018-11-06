using System;
using System.Collections.Generic;

class countingCharacters
{
  static void Main(string[] args)
  {
    // Console.Write("Hello");

    // for items in list:
    //   print(items)
    //
    // string item;
    // foreach item in List{
    //   Console.Write(item)
    // }
    int[] scores = new int[] { 97, 92, 81, 60 };

    for (int i = 0; i < scores.Length; i++)
    {
      // i = 1
      Console.Write("Index number: " + i); // 1
      Console.WriteLine("scores[i] value: " + scores[i]);
    } // i + 1 = 2
  }
}
