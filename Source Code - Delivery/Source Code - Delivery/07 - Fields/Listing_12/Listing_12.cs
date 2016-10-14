
class Product {
    const int unitsPerCrate = 10;
    int cratesInStock = 21;
    string productName;

    public Product(string pname, int crates) {
        productName = pname;
        cratesInStock = crates;
    }

    public int ItemsInStock {
        get { return cratesInStock * unitsPerCrate; }
        set { cratesInStock = value / unitsPerCrate; }
    }
}

class Listing_12 {

    static void Main(string[] args) {

        // create a new instance of the Product type
        Product bananaProduct = new Product("Bananas", 21);

        // write out the number of items in stock
        System.Console.WriteLine("Units in Stock: {0}", bananaProduct.ItemsInStock);
       
        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

