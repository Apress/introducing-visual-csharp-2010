using System;

class Product {

    public int ItemsInStock { 
        private get; 
        set; 
    }

    public double PricePerItem { get; set; }

    public double TotalValueOfStock {
        get {
            return ItemsInStock * PricePerItem;
        }
    }
}

class Listing_08 {

    static void Main(string[] args) {

        // create a new instance of the Product class
        Product prod = new Product();

        // set the value of the fields
        prod.ItemsInStock = 20;
        prod.PricePerItem = 5.23;

        // get the total value of the products in stock
        Console.WriteLine("Total stock value: {0}", prod.TotalValueOfStock);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

