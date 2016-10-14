using System;

class Listing_02 {

    static void Main(string[] args) {

        char myEscapedQuote = '\'';
        char myUnicodeQuote = '\u0027';
        char myHexQuote = '\x0027';

        Console.WriteLine("Character: {0}", myEscapedQuote);
        Console.WriteLine("Character: {0}", myUnicodeQuote);
        Console.WriteLine("Character: {0}", myHexQuote);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
