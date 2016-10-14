using System;

class Listing_34 {

    static void Main(string[] args) {

        string[][] jaggedArray = new string[3][];

        jaggedArray[0] = new string[] {"apples", "oranges"};
        jaggedArray[1] = new string[] {"bananas"};
        jaggedArray[2] = new string[] { "guavas", "pears", "cherries" };

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
