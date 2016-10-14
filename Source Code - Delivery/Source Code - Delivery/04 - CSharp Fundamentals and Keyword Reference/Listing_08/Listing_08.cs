using System;

class Listing_08 {

    static void Main(string[] args) {

        int x = 0;
        do {
            // write out a message
            Console.WriteLine("Iteration for value: {0}", x);
            // increment the local variable
            x++;
        } while (x < 5);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}