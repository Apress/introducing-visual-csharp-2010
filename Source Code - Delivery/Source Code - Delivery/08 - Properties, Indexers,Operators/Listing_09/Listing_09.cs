using System;

class Product {
    protected int itemsInStock;

    public virtual int ItemsInStock {
        get {
            Console.WriteLine("Original Get Accessor");
            return itemsInStock; 
        }
        set {
            Console.WriteLine("Original Set Accessor");
            itemsInStock = value; 
        }
    }
}

class DerivedProduct : Product {

     public override int ItemsInStock {
        get {
            Console.WriteLine("Derived Get Accessor");
            return itemsInStock * 2; 
        }
    }
}

class Listing_09 {

    static void Main(string[] args) {

        // create a new instance of the Product class
        DerivedProduct dp = new DerivedProduct();
        Product prod = dp;

        // set the value of the fields
        prod.ItemsInStock = 20;

        Console.WriteLine("Stock DP {0}", dp.ItemsInStock);
        Console.WriteLine("Stock P  {0}", prod.ItemsInStock);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

