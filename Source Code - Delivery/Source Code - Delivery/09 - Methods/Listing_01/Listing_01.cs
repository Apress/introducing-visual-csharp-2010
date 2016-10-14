using System;

class MyClass {
    
    public int CalculateProduct(int num1, int num2) { 
        // compute the product
        return num1 * num2;
    }

}

class Listing_01 {

    static void Main(string[] args) {

        // create a new instance of my class
        MyClass mc = new MyClass();

        // calculate the product
        int result = mc.CalculateProduct(10, 6);

        // print out the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

