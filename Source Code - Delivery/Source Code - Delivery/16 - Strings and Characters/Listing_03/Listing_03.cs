using System;

class Listing_03 {

    static void Main(string[] args) {

        char myChar = 'a';

        if (myChar == 'b') {
            Console.WriteLine("Characters are the same");
        } else {
            Console.WriteLine("Characters are different");
        }

        switch (myChar) {
            case 'a':
                Console.WriteLine("Char is a");
                break;
            case 'b':
            case 'c':
                Console.WriteLine("Char is b or c");
                break;
            default:
                Console.WriteLine("Char is not a, b or c");
                break;
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
