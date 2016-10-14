
class Product {
    protected int myField;
}

class DerivedProduct : Product {
    private new string myField;

    public int MyIntProperty {
        get { return base.myField; }
        set { base.myField = value; }
    }

    public string MyStringProperty {
        get { return this.myField; }
        set { this.myField = value; }
    }
}

class Listing_16 {

    static void Main(string[] args) {


        DerivedProduct dp = new DerivedProduct();

        dp.MyIntProperty = 20;
        dp.MyStringProperty = "20";

        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

