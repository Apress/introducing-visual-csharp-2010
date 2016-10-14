class Product {
    string productName;
    static string productCategory;

    public Product(string prodName, string prodCat) {
        productName = prodName;
        productCategory = prodCat;
    }

    public string ProductCategory {
        get { return productCategory; }
        set { productCategory = value; }
    }
}

class Listing_10 {

    static void Main(string[] args) {

        // create a new instance of the Product type
        Product bananaProduct = new Product("Bananas", "Fruit");
        // create another new instance of the Product type
        Product appleProduct = new Product("Apples", "Fruit");

        // change the banana category
        bananaProduct.ProductCategory = "Fresh Fruit";

        // print out the category values
        System.Console.WriteLine("Banana Category: {0}", bananaProduct.ProductCategory);
        System.Console.WriteLine("Apple Category: {0}", appleProduct.ProductCategory);

        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

