using System;

abstract class Product {

    public abstract int ItemsInStock {
        get;
        set;
    }
}

class DerivedProduct : Product {

    public override int ItemsInStock {
        get; set; 
    }
}

class Listing_10 {

    static void Main(string[] args) {

        // create a new instance of the Product class
        Product prod = new DerivedProduct(); ;

        // set the value of the property
        prod.ItemsInStock = 20;
        // print the value of the property
        Console.WriteLine("Stock {0}", prod.ItemsInStock);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

