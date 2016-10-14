using System;

class Product {

    public static string DefaultProductName {
        get;
        set;
    }
}

class Listing_12 {

    static void Main(string[] args) {

        // set the static property in the class
        Product.DefaultProductName = "Oranges";

        // get the static property value
        Console.WriteLine("Default name: {0}", Product.DefaultProductName);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

