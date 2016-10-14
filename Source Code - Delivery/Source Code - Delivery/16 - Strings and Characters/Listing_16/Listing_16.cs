using System;

class Listing_16 {

    static void Main(string[] args) {

        // define a string using a literal
        string myString = "Hello World";

        // get the length of the string
        int len = myString.Length;
        Console.WriteLine("Length: {0}", len);

        // get the characters from the string
        char[] charArray = myString.ToCharArray();
        // enumerate the character array
        foreach (char c in charArray) {
            Console.WriteLine("Char: {0}", c);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
