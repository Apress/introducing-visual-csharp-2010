using System;

class Product {
    private string[] productNames
        = new string[] { "orange", "apple", "pear", 
            "banana", "cherry" };

    public string this[int index] {
        get { return productNames[index]; }
        set { productNames[index] = value; }
    }

}

class Listing_13 {

    static void Main(string[] args) {

        // create a new product
        Product p = new Product();

        // get some values via the indexer
        Console.WriteLine("Indexer value 0: {0}", p[0]);
        Console.WriteLine("Indexer value 1: {0}", p[1]);

        // set a value via the indexer
        p[2] = "guava";

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

