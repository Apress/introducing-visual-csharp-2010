using System;
using Listing_13.WCFServer;

class WCFClient {

    static void Main(string[] args) {

        // create a new client object
        CalculatorServerClient calcClient = new CalculatorServerClient();

        // perform some calculations
        int result = calcClient.PerformAddition(10, 20);
        Console.WriteLine("Addition result: {0}", result);

        result = calcClient.PerformMultiplcation(20, 30);
        Console.WriteLine("Multiplication result: {0}", result);

        result = calcClient.PerformSubtraction(30, 40);
        Console.WriteLine("Subtraction result: {0}", result);

        float divisionResult = calcClient.PerformDivision(40, 50);
        Console.WriteLine("Division result: {0}", divisionResult);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
