using System;

class Listing_14 {

    static void Main(string[] args) {

        // define some strings
        string firstString = "Introduction";
        string secondString = "to";
        string thirdString = "C#";

        // concat the strings
        string concatString = String.Concat(firstString, secondString, thirdString);
        // write out the concatenated value
        Console.WriteLine("Concat: {0}", concatString);

        // insert some spaces into the string
        string insertString = concatString.Insert(12, " ");
        insertString = insertString.Insert(15, " ");
        // write out the modified string
        Console.WriteLine("Insert: {0}", insertString);

        // define an array of strings
        string[] strArray = {"Introduction", "to", "C#"};
        // join the strings together using space as a separator
        string joinString = String.Join(" ", strArray);
        // write out the modified string
        Console.WriteLine("Join: {0}", joinString);

        // pad the string
        string padString = joinString.PadLeft(25);
        // write out the modified string
        Console.WriteLine("Pad: -{0}-", padString);

        // remove some characters
        string removeString = joinString.Remove(12);
        // write out the modified string
        Console.WriteLine("Remove: {0}", removeString);

        // replace some characters
        string replaceString = removeString.Replace('o', '0');
        // write out the modified string
        Console.WriteLine("Replace: {0}", replaceString);

        // split a string an enumerate the contents
        string splitString = "Introduction to C#";
        string[] strElements = splitString.Split(' ');
        foreach (string s in strElements) {
            Console.WriteLine("Element: {0}", s);
        }

        // force a string into uppoer and lowe case
        string upperString = splitString.ToUpper();
        string lowerString = splitString.ToLower();
        // write out the modified strings
        Console.WriteLine("Upper: {0}", upperString);
        Console.WriteLine("Lower: {0}", lowerString);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
