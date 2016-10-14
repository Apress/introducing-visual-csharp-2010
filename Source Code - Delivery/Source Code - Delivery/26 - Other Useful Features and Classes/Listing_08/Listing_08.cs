using System;

class Listing_08 {

    static void Main(string[] args) {

        Console.Beep();

        Console.Beep(850, 200);
        Console.Beep(900, 200);
        Console.Beep(950, 200);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}