/*******************************************************************************************/
/*      AppleStocks program. Created by Lucas Costa, May 26, 2016                          */
/*  the point of the program is to Write an efficient function that takes                  */
/*  stockPricesYesterday and returns the best profit I could have made from                */
/* 1 purchase and 1 sale of 1 Apple stock yesterday.                                       */
/*******************************************************************************************/

import java.util.Scanner; //imports all libraries

public class AppleStocks {
    public static void myFunction(int[] stockPricesYesterday) {

        int smallestNumber = 100;
        int largestNumber = 0;
        int difference = 0;
        int smallestNumberIndex = 0;
        int largestNumberIndex = 0;

        System.out.println("Stocks prices, every minute: ");
        for(int i = 0; i < stockPricesYesterday.length; i++)
        {
            System.out.print(stockPricesYesterday[i] + ",");
        }
        System.out.print("\n\n");

        for(int i = 0; i < stockPricesYesterday.length; i++) //Finding the smallest number
        {
          if(stockPricesYesterday[i] < smallestNumber)
          {
            smallestNumber = stockPricesYesterday[i];
            smallestNumberIndex = i;
          }
        }


        for(int i = smallestNumberIndex; i < ((stockPricesYesterday.length) - 1); i++)     //for loop to find the difference
        {
          if((stockPricesYesterday[i + 1] - smallestNumber) > difference) //finding profit
          {
              difference = (stockPricesYesterday[i + 1] - smallestNumber);
              largestNumberIndex = i + 1;
          }
        }
        System.out.println("The best profit I could have made from 1 purchase and 1 sale of 1 Apple stock yesterday is " + difference + ".");
          System.out.println("You would have to buy stocks at minute " + (smallestNumberIndex + 1) + " for $" + smallestNumber);
        System.out.println("By selling stocks at minute: " + (largestNumberIndex + 1) + " for $" + stockPricesYesterday[largestNumberIndex]);

       /*for(int i = 0; i < stockPricesYesterday.length; i++)   //Finding the biggest number
        {
          if(stockPricesYesterday[i] > largestNumber)
          {
            largestNumber = stockPricesYesterday[i];
          }
        }
        System.out.println("Largest Number: " + largestNumber); */

    }

    public static void main(String[] args) {
        // run your function through some test cases here
        int[] stockPricesYesterday = new int[]{10, 7, 5, 8, 9, 6, 22};

        myFunction(stockPricesYesterday);
    }
}
