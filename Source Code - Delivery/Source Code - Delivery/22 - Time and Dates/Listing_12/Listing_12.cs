using System;

class Listing_12 {

    static void Main(string[] args) {

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

       
        // create future and past DateTime values
        DateTime futureValue = new DateTime(2012, 1, 20);
        DateTime pastValue = new DateTime(2008, 1, 20);

        // use the addition operator
        TimeSpan ts = new TimeSpan(5, 0, 0, 0);
        DateTime additionResult = futureValue + ts;
        Console.WriteLine("Addition: {0}", additionResult);

        // use both subtraction operators
        TimeSpan difference = futureValue - pastValue;
        Console.WriteLine("Subtraction 1: {0}", difference);
        DateTime subDate = futureValue - ts;
        Console.WriteLine("Subtraction 2: {0}", subDate);

        // use the quality and inequality operators
        Console.WriteLine("Values are equal: {0}", futureValue == pastValue);
        Console.WriteLine("Values are unequal: {0}", futureValue != pastValue);

        // use the comparison operators
        Console.WriteLine("Future > Past: {0}", futureValue > pastValue);
        Console.WriteLine("Future < Past: {0}", futureValue < pastValue);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
