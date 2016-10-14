using System;

class Listing_02 {

    static void Main(string[] args) {

        int x = 20;
        int y;
        y = x;

        y = x = 40;
        Console.WriteLine("X: {0}", x);
        Console.WriteLine("Y: {0}", y);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
