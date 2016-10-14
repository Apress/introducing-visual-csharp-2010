using System;

class Product {
    public string Name { get; set; }
    public int ItemsInStock { get; set; }
    public double PricePerItem { get; set; }


    public static Product operator +(Product p1, int number) {
        return new Product() {
            Name = p1.Name,
            ItemsInStock = p1.ItemsInStock + number,
            PricePerItem = p1.PricePerItem
        };
    }
}

class Listing_19_Test {

    static void Main(string[] args) {

        // create a new product
        Product p1 = new Product() {
            Name = "oranges",
            ItemsInStock = 10,
            PricePerItem = 20
        };
  
        // use the postfix increment operator
        Product sum = p1 + 20;

        // print out the number of items in stock
        Console.WriteLine("Items in stock: {0}", sum.ItemsInStock);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

