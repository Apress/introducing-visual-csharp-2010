using System;

class Listing_12 {

    static void Main(string[] args) {


        string myBook = "Introduction to C#";

        switch (myBook) {
            case "Pro .NET Parallel Programming":
                Console.WriteLine("This is a parallel programming book");
                break;
            case "Pro LINQ":
                Console.WriteLine("This is a LINQ book");
                break;
            case "Introduction to C#":
                Console.WriteLine("This is a C# introduction book");
                break;
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
