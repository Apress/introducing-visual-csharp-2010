using System;

abstract class BaseClass {

    public abstract int CalculateProduct(int x, int y);
}

class DerivedClass : BaseClass {

    public sealed override int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class SealedTest {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
