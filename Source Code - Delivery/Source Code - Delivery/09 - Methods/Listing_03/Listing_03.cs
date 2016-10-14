using System;

class MyClass {

    public void CalculateProduct(int num1, int num2) {
        // compute the product and print the result
        Console.WriteLine("Product: {0}", num1 * num2);
    }
}

class Listing_03 {

    static void Main(string[] args) {

        // create a new instance of my class
        MyClass mc = new MyClass();

        // calculate the product
        mc.CalculateProduct(10, 6);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

