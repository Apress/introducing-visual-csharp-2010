
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

}

class Listing_04 {

    static void Main(string[] args) {

        // create a new instance of the Product type
        Product prod1 = new Product("Bananas", "Bob's Banana Shop");
        Product prod2 = new Product("Apples", "Apples R Us");



        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

