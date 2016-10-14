using System;

class Supplier {
  
}

class Product {
    int itemsInStock = 210;
    string productName = "Banana";
    Supplier productSupplier = new Supplier();
}


class Listing_03 {

    static void Main(string[] args) {

        // create a new instance of the Product type
        Product product1 = new Product();
        Product product2 = new Product();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

