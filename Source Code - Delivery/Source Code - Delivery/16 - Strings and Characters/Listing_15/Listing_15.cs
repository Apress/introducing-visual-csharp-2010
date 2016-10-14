using System;

class Listing_15 {

    static void Main(string[] args) {

        // define a string to work with
        string myString = "Introduction to C#";

        // use the Contains method
        bool contains = myString.Contains("duct");
        Console.WriteLine("Contains: {0}", contains);

        // use the StartsWith and EndsWith methods
        bool startsWith = myString.StartsWith("Intro");
        bool endsWith = myString.EndsWith("Intro");
        Console.WriteLine("StartsWith: {0}", startsWith);
        Console.WriteLine("EndsWith: {0}", endsWith);

        // use the IndexOf and LastIndexOf methods
        int indexOf = myString.IndexOf('o');
        int lastIndexOf = myString.LastIndexOf('o');
        Console.WriteLine("IndexOf: {0}", indexOf);
        Console.WriteLine("LastIndexOf: {0}", lastIndexOf);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
