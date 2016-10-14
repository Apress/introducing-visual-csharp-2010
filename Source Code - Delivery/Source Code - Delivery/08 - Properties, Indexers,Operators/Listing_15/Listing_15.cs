using System;

class Product {
    private string[] productNames
        = new string[] { "orange", "apple", "pear", 
            "banana", "cherry" };

    public string this[int index] {
        get {
            if (index >= 0 && index < productNames.Length) {
                return productNames[index];
            } else {
                return "no name";
            }
        }
    }
}

class Listing_15 {

    static void Main(string[] args) {

        // create a new product
        Product p = new Product();

        // get some values via the indexer
        Console.WriteLine("Indexer value -1: {0}", p[-1]);
        Console.WriteLine("Indexer value 0: {0}", p[0]);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

