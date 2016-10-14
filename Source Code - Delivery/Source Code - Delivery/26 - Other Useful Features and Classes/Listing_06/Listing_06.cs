using System;

class Listing_06 {

    static void Main(string[] args) {

        int? myNullable = null;

        int myRegularInt = myNullable ?? 0;
        
        Console.WriteLine("Int value: {0}", myRegularInt);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}