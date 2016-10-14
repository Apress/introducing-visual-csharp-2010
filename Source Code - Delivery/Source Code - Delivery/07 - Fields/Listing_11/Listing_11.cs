class Product {
    string productName;
    public static string ProductCategory;

    public Product(string prodName) {
        productName = prodName;
    }
}

class Listing_11 {

    static void Main(string[] args) {

        // create a new instance of the Product type
        Product bananaProduct = new Product("Bananas");
        // create another new instance of the Product type
        Product appleProduct = new Product("Apples");

        // change the banana category
        Product.ProductCategory = "Fresh Fruit";

        // print out the category values
        System.Console.WriteLine("Product Category: {0}", Product.ProductCategory);

        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

