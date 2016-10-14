using System;

class Listing_06 {

    static void Main(string[] args) {

        // define a string using a literal that contains escape sequences
        string myString = "Introduction\nto\nC#";
        // print out the string
        Console.WriteLine(myString);

        // define a sample file path
        string myFilePath = "c:\\Books\\Intro to C#\\Manuscript\\Chapter 16";
        // print out the file path
        Console.WriteLine("File path: {0}", myFilePath);

        // define the file path as a veratim string literal
        myFilePath = @"c:\Books\Intro to C#\Manuscript\Chapter 16";
        Console.WriteLine("Verbatim path: {0}", myFilePath);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
