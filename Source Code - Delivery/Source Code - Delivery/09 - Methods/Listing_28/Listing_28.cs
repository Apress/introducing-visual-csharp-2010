using System;

class Calculator {

    public int CalculateSum(int x, int y) {
        return x + y;
    }

    public int CalculateSum(string x, string y) {
        return CalculateSum(int.Parse(x), int.Parse(y));
    }

    public float CalculateSum(float x, float y) {
        return x + y;
    }
}

class Listing_28 {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}