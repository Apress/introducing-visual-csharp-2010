﻿
class Supplier {
    string supplierName;

    public Supplier(string name) {
        supplierName = name;
    }

    public string SupplierName {
        get { return supplierName; }
        set { supplierName = value; }
    }
}

class Product {
    string productName;
    Supplier productSupplier;

    public Product(string pname, Supplier supplier) {
        productName = pname;
        productSupplier = supplier;
    }

    public Supplier Supplier {
        get { return productSupplier; }
    }
}

class Listing_09 {

    static void Main(string[] args) {

        // create a new supplier
        Supplier supp = new Supplier("Bob's Banana Shop");

        // create a new instance of the Product type
        Product bananaProduct = new Product("Bananas",  supp);

        // update the supplier name
        supp.SupplierName = "Apples R Us";
        //supp = new Supplier("Apples R Us");

        // create a new instance of the Product type
        Product appleProduct = new Product("Apples", supp);

        // get the supplier names from the products
        System.Console.WriteLine("Banana Name: {0}", bananaProduct.Supplier.SupplierName);
        System.Console.WriteLine("Apple Name: {0}", appleProduct.Supplier.SupplierName);

        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

