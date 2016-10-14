using System;

class Product {
    private string name;

    public Product(string namearg) {
        name = namearg;
    }

    public string Name {
        get { return name; }
    }
}

class Listing_07 {

    static void Main(string[] args) {

        // create and initialize a new array
        Product[] prods = {
                              new Product("oranges"),
                              new Product("apples"),
                              new Product("guava")
                          };

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

