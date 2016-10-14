using System;

static class ExtensionMethods {

    public static bool ContainsLetter(this string s, char c) {
        // enumerate the characters in the string
        // and see if we have a match
        foreach (char ch in s) {
            if (ch == c) {
                return true;
            }
        }
        // we have finished checking all of the characters
        // in the string, meaning that there is no match
        return false;
    }
}

class Listing_66_Test {

    static void Main(string[] args) {

        // define a string 
        string str = "Hello World";

        // use the extension method on the string
        bool containsCharX = str.ContainsLetter('x');
        bool containsCharE = str.ContainsLetter('e');

        Console.WriteLine("String contains X: {0}", containsCharX);
        Console.WriteLine("String contains E: {0}", containsCharE);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
