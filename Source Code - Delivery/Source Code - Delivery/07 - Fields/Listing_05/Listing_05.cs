
class Supplier {
    string supplierName;

    public Supplier(string name) {
        supplierName = name;
    }

}

class Product {
    int itemsInStock = 210;
    string productName;
    Supplier productSupplier;

    public Product(string pname, string sname) {
        productName = pname;
        productSupplier = new Supplier(sname);
    }

    public void ReadAndModifyFields() {
        // read the itemsInStock field value
        int readValue = itemsInStock;
        System.Console.WriteLine("Stock level: {0}", readValue);
        // modify the stock level
        itemsInStock = 10;
        // write out the (modified) itemsInStock field value
        System.Console.WriteLine("Stock level: {0}", itemsInStock);
    }  
}

class Listing_05 {

    static void Main(string[] args) {

        // create a new instance of the Product type
        Product prod = new Product("Bananas", "Bob's Banana Shop");

        prod.ReadAndModifyFields();

        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

