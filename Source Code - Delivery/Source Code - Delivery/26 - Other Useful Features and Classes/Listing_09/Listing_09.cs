using System;

class Listing_09 {

    static void Main(string[] args) {

        Console.WriteLine("Press Enter to change appearance");
        Console.ReadLine();

        // get the settings that we want to restore to
        int originalWidth = Console.WindowWidth;
        string originalTitle = Console.Title;

        // change the appearance of the console
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WindowWidth = 40;
        Console.Title = "Introduction to C#";



        // prompt the user to change things back
        Console.WriteLine("Press Enter to restore appearance");
        Console.ReadLine();

        // reset the appearance
        Console.ResetColor();
        Console.WindowWidth = originalWidth;
        Console.Title = originalTitle;

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}