using System;

class Listing_16 {

    static void Main(string[] args) {

        // define a number
        float f = 26.765f;

        // use the unary plus operator
        float up = +f;

        // use the unary minus operator
        float um = -f;

        // print out the results
        Console.WriteLine("Unary plus result: {0}", up);
        Console.WriteLine("Unary minus result: {0}", um);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
