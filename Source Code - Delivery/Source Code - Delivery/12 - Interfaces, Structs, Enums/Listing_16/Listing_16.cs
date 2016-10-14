using System;

public struct Product {
    public int CasesInStock;
    public int ItemsPerCase;

    public Product(int cases, int itemspc) {
        CasesInStock = cases;
        ItemsPerCase = itemspc;
    }
}

class Listing_16 {

    static void Main(string[] args) {

        Product prod = new Product(100, 10);

        // get and print out the value of one of the fields
        Console.WriteLine("Cases in Stock: {0}", prod.CasesInStock);
        // set the value of one of the fields
        prod.CasesInStock = 75;

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
