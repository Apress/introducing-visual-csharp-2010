using System;

class MyClass {

    public int CalculateProduct(int num1, int num2) {
        // check that the parameters are valid
        CheckRange(num1, num2);
        // perform calculation
        return num1 * num2;
    }

    public int CalculateSum(int num1, int num2) {
        // check that the parameters are valid
        CheckRange(num1, num2);
        // perform calculation
        return num1 + num2;
    }

    public double CalculateRatio(int num1, int num2) {
        // check that the parameters are valid
        CheckRange(num1, num2);
        // perform calculation
        return num1 / num2;
    }

    private void CheckRange(int num1, int num2) {
        if (!(num1 > 0 && num1 < 100 && num2 > 0 && num2 < 100)) {
            throw new ArgumentOutOfRangeException();
        }
    }
}

class Listing_08 {

    static void Main(string[] args) {

        // create a new instance of my class
        MyClass mc = new MyClass();

        // call the methods in the MyClass instance
        int result1 = mc.CalculateProduct(10, 50);
        int result2 = mc.CalculateSum(10, 50);
        int result3 = mc.CalculateProduct(10, 50);

        // print out the results
        Console.WriteLine("Product: {0}", result1);
        Console.WriteLine("Sum: {0}", result2);
        Console.WriteLine("Ratio: {0}", result3);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

