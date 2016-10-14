using System;

class Listing_25 {

    static void Main(string[] args) {

        // print out the string field values
        Console.WriteLine("TrueString: {0}", bool.TrueString);
        Console.WriteLine("FalseString: {0}", bool.FalseString);

        // parse a string into a bool
        bool b1 = bool.Parse("true");
        Console.WriteLine("Parsed value: {0}", b1);

        // use the TryParse method
        bool result;
        bool parseOK = bool.TryParse("true", out result);
        Console.WriteLine("Parse result: {0}, bool value: {1}", parseOK, result);
 
        // convert a bool to a string
        string str = true.ToString();
        Console.WriteLine("String value: {0}", str);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}