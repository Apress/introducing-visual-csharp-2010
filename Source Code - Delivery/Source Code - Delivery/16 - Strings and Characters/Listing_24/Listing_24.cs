using System;

class Listing_24 {

    static void Main(string[] args) {

        float itemsPerCase = 3f;
        float costPerCase = 10f;
        
        // work out the cost per item
        float costPerItem = costPerCase / itemsPerCase;

        // define a format string
        string formatString1 = "Cost per item: {0}";
        // define a format string with a format string component
        string formatString2 = "Cost per item: {0:F2}";

        // use composite formatting
        Console.WriteLine(formatString1, costPerItem);
        Console.WriteLine(formatString2, costPerItem);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
