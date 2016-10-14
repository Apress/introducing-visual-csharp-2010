using System;

class MyClass {

    public int CalculateProduct(int num1, int num2) {
        // check that the parameters are valid
        if (num1 > 0 && num1 < 100 && num2 > 0 && num2 < 100) {
            // number is valid - perform calculation
            return num1 * num2;
        } else {
            // throw an exception - the arguments are not valid
            throw new ArgumentOutOfRangeException();
        }
    }

    public int CalculateSum(int num1, int num2) {
        // check that the parameters are valid
        if (num1 > 0 && num1 < 100 && num2 > 0 && num2 < 100) {
            // number is valid - perform calculation
            return num1 + num2;
        } else {
            // throw an exception - the arguments are not valid
            throw new ArgumentOutOfRangeException();
        }
    }

    public double CalculateRatio(int num1, int num2) {
        // check that the parameters are valid
        if (num1 > 0 && num1 < 100 && num2 > 0 && num2 < 100) {
            // number is valid - perform calculation
            return num1 / num2;
        } else {
            // throw an exception - the arguments are not valid
            throw new ArgumentOutOfRangeException();
        }
    }
}

class Listing_05 {

    static void Main(string[] args) {

        // create a new instance of my class
        MyClass mc = new MyClass();

        Console.WriteLine("Product: {0}", mc.CalculateProduct(10, 50));
        Console.WriteLine("Sum: {0}", mc.CalculateSum(10, 50));
        Console.WriteLine("Ration: {0}", mc.CalculateProduct(10, 50));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

