using System;

public struct Product {
    public int CasesInStock;
    public int ItemsPerCase;

    public Product(int cases, int items) {
        CasesInStock = cases;
        ItemsPerCase = items;
    }
}

class Listing_20 {

    static void Main(string[] args) {

        // create a new struct value
        Product prod = new Product(20, 20);

        // print out the value of the fields
        Console.WriteLine("Cases In Stock: {0}", prod.CasesInStock);
        Console.WriteLine("Items Per Case: {0}", prod.ItemsPerCase);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
