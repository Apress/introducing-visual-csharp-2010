
class Supplier {
    string supplierName;

    public Supplier(string name) {
        supplierName = name;
    }
}

class Product {
    public int ItemsInStock = 210;
    string productName;
    Supplier productSupplier;

    public Product(string pname, string sname) {
        productName = pname;
        productSupplier = new Supplier(sname);
    }
}

class Listing_06 {

    static void Main(string[] args) {

        // create a new instance of the Product type
        Product prod = new Product("Bananas", "Bob's Banana Shop");

        // read the itemsInStock field value
        int readValue = prod.ItemsInStock;
        System.Console.WriteLine("Stock level: {0}", readValue);
        // modify the stock level
        prod.ItemsInStock = 10;
        // write out the (modified) itemsInStock field value
        System.Console.WriteLine("Stock level: {0}", prod.ItemsInStock);

        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

