using System;
using System.Text;

class Listing_19 {

    static void Main(string[] args) {

        // create a string builder
        StringBuilder myBuilder = new StringBuilder("Introduction to C#");

        // read some chars using the indexer
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Char at index {0}: {1}", i, myBuilder[i]);
        }

        // change a character
        myBuilder[0] = 'Z';

        // write out the contents of the StringBuilder object
        Console.WriteLine("Modified: {0}", myBuilder);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
