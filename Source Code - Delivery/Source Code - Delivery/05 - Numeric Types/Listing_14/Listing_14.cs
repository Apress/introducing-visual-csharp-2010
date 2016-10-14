using System;

class Listing_14 {

    static void Main(string[] args) {

        // define two integer values
        int x = 5;
        int y = 2;

        // use the division operator
        int result1 = x / y;
        Console.WriteLine("Integer result: {0}", result1);

        // cast to a real numeric type and then use the operator
        float result2 = (float)x / (float)y;
        Console.WriteLine("Real result: {0}", result2);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}