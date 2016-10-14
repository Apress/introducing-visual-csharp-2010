using System;

class Listing_01 {

    static void Main(string[] args) {

        // define an int value
        int myInt = int.MaxValue;

        // convert the int to a long
        long myLong = Convert.ToInt64(myInt);
        Console.WriteLine("Long value: {0}", myLong);

        // try to represent the int as a byte - this 
        // won't work because the value is too large
        try {
            byte myByte = Convert.ToByte(myInt);
        } catch (OverflowException) {
            Console.WriteLine("Got an OverflowException converting to a byte");
        }

        // define a string that contains a numeric value
        string myString = "23";

        // convert the string to an int
        int myParsedInt = Convert.ToInt32(myString);
        Console.WriteLine("Int value: {0}", myParsedInt);

        // convert the string to a float
        float myParsedFloat = Convert.ToSingle(myString);
        Console.WriteLine("Float value: {0}", myParsedFloat);

        // try to parse a string that doesn't contain a numeric value
        string myBadString = "Hello";
        try {
            int myBadInt = Convert.ToInt32(myBadString);
        } catch (FormatException) {
            Console.WriteLine("Cannot parse {0} to an int", myBadString);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
