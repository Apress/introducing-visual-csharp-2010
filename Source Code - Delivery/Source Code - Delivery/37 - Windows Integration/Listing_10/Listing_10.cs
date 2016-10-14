using System;
using Microsoft.Win32;

class Listing_10 {

    static void Main(string[] args) {

        // define the key name
        string keyName = @"HKEY_CURRENT_USER\Software\Apress\Introduction to C#";

        // set a value for the key
        Registry.SetValue(keyName, 
            "Windows Integration Example", 
            "Test Value");

        // read the value back
        string value = (string)Registry.GetValue(keyName, 
            "Windows Integration Example", 
            "Default Value");

        // print out the value 
        Console.WriteLine("Value: {0}", value);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
