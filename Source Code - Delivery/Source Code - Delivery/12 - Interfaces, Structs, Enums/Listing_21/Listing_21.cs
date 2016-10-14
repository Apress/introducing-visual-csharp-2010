using System;
using System.Text;

public struct Product {
    public int CasesInStock;
    public int ItemsPerCase;
    public StringBuilder SupplierName;

    public Product(int cases, int items, StringBuilder name) {
        CasesInStock = cases;
        ItemsPerCase = items;
        SupplierName = name;
    }
}

class Listing_21_Test {

    static void Main(string[] args) {

        // create a StringBuilder object
        StringBuilder sb = new StringBuilder("BigCo Supplies");
        // create a struct value
        Product prod = new Product(20, 20, sb);

        // create a copy of the struct value
        Product prod2 = prod;

        // make a change to a value-type field in the original struct value
        prod.ItemsPerCase = 30;
        // write out both copies of the same field
        Console.WriteLine("Original Value ItemsPerCase: {0}", prod.ItemsPerCase);
        Console.WriteLine("Copy Value ItemsPerCase: {0}", prod2.ItemsPerCase);

        // make a change to the reference-type field in the original struct value
        prod.SupplierName.Append(" Inc");
        // print out both values for the reference-type field
        Console.WriteLine("Original Value Supplier: {0}", prod.SupplierName);
        Console.WriteLine("Copy Value Supplier: {0}", prod2.SupplierName);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
