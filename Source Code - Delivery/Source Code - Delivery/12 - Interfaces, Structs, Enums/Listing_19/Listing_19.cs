using System;

public struct Product {
    public int CasesInStock;
    public int ItemsPerCase;
}

class Listing_19 {

    static void Main(string[] args) {

        // create a new struct value
        Product prod = new Product();

        // print out the value of the fields
        Console.WriteLine("Cases In Stock: {0}", prod.CasesInStock);
        Console.WriteLine("Items Per Case: {0}", prod.ItemsPerCase);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
