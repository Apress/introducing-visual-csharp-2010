using System;
using System.IO;

class Listing_03 {

    static void Main(string[] args) {

        string[] filteredNames = Directory.GetFiles(@"C:\Program Files", "*.exe", SearchOption.AllDirectories);

        foreach (string name in filteredNames) {
            Console.WriteLine("Name: {0}", name);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
