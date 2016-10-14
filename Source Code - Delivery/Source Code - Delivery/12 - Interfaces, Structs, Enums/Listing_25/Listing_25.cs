using System;

public enum PaintColor : long {
    Black = 10,
    Red,
    Green = 15,
    Silver
}

class Listing_25 {

    static void Main(string[] args) {

        Console.WriteLine("Numeric Value of Red: {0}", (int)PaintColor.Red);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
