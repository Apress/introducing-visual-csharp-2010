using System;
using System.Text;

class Listing_17 {

    static void Main(string[] args) {

        // create a StringBuilder object
        StringBuilder myBuilder = new StringBuilder("Introduction to C#");

        // report the capacity of the StringBuilder
        Console.WriteLine("Capacity: {0}", myBuilder.Capacity);

        // remove some characters
        myBuilder.Remove(12, 6);
        Console.WriteLine("Remove: {0}", myBuilder);

        // replace some characters
        myBuilder.Replace('o', '0');
        Console.WriteLine("Replace: {0}", myBuilder);

        // convert to and assign to a string
        string myString = myBuilder.ToString();
        Console.WriteLine("ToString: {0}", myString);

        // clear the contents of the StringBuilder
        myBuilder.Clear();
        Console.WriteLine("Cleared: {0}", myBuilder);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
