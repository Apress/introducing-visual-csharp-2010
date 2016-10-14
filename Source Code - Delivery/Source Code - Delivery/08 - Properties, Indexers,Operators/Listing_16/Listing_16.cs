using System;

class Product {

    public int this[int arg1, int arg2] {
        get {
            return arg1 * arg2;
        }
    }
}

class Listing_16 {

    static void Main(string[] args) {

        // create a new product
        Product p = new Product();

        // get some values via the indexer
        Console.WriteLine("Indexer value [10, 20]: {0}", p[10, 20]);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

