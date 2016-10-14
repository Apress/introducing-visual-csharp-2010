using System;

class ProductResult {
    public int FirstParam { get; set; }
    public int SecondParam { get; set; }
    public int Result { get; set; }
}

class MyClass {

    public ProductResult CalculateProduct(int num1, int num2) {
        // check the length of the string
        return new ProductResult() {
            FirstParam = num1,
            SecondParam = num2,
            Result = num1 * num2
        };
    }
}

class Listing_02 {

    static void Main(string[] args) {

        // create a new instance of my class
        MyClass mc = new MyClass();

        // calculate the product
        ProductResult result = mc.CalculateProduct(10, 6);

        // print out the result
        Console.WriteLine("Result: {0}", result.Result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

