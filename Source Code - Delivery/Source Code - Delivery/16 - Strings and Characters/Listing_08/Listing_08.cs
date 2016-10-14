using System;

class Listing_08 {

    static void Main(string[] args) {

        // print a message to the console
        Console.WriteLine("Enter a line of text and press enter");
        Console.WriteLine("Enter 'x' and press enter to quit");

        while (true) {
            string userString = Console.ReadLine();

            if (userString == string.Empty) {
                Console.WriteLine("String is empty");
            } else {
                Console.WriteLine("Read line: {0}", userString);
                if (userString == "x") {
                    break;
                }
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
