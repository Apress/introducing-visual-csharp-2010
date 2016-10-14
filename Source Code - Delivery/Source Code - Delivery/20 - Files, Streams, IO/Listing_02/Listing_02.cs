using System;
using System.IO;

class Listing_02 {

    static void Main(string[] args) {

        string[] filteredNames = Directory.GetFiles(@"C:\", "page*");
        
        foreach (string name in filteredNames) {
            Console.WriteLine("Name: {0}", name);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
