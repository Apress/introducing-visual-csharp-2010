using System;

class Listing_04 {

    static void Main(string[] args) {

        char myChar = 'x';

        Console.WriteLine("Numeric Value: {0}", Char.GetNumericValue(myChar));
        Console.WriteLine("Is Digit? {0}", Char.IsDigit(myChar));
        Console.WriteLine("Is Letter? {0}", Char.IsLetter(myChar));
        Console.WriteLine("Is Letter Or Digit? {0}", Char.IsLetterOrDigit(myChar));
        Console.WriteLine("IsLower? {0}", Char.IsLower(myChar));
        Console.WriteLine("IsUpper? {0}", Char.IsUpper(myChar));
        Console.WriteLine("Is Punctuation? {0}", Char.IsPunctuation(myChar));
        Console.WriteLine("Is Separator? {0}", Char.IsSeparator(myChar));
        Console.WriteLine("Is Symbol ? {0}", Char.IsSymbol(myChar));
        Console.WriteLine("Is White space? {0}", Char.IsWhiteSpace(myChar));
        Console.WriteLine("Convert to Upper: {0}", Char.ToUpper(myChar));
        Console.WriteLine("Convert to Lower: {0}", Char.ToLower(myChar));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
