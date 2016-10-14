using System;
using System.Text.RegularExpressions;

class Listing_13 {

    static void Main(string[] args) {

        // define an array of strings
        string[] bookTitles = { "Introduction to C#", 
                                "Visual C# Recipes", 
                                "Pro .NET Parallel Programming", 
                                "Pro LINQ" };

        // define the term we will search for 
        string searchTerm = "pro";

        // enumerate through the title strings and look for the search term
        foreach (string title in bookTitles) {
            Console.WriteLine("--- Title ---");
            Console.WriteLine("Book title: {0}", title);
            if (Regex.IsMatch(title, searchTerm, RegexOptions.IgnoreCase)) {
                Console.WriteLine("Title contains search term!");
            } else {
                Console.WriteLine("No match found");
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
