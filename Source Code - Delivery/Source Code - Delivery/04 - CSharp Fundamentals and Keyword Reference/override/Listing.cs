using System;

abstract class MyAbstractClass {

    public abstract int CalculateProduct(int x, int y);

    public virtual int CalculateSum(int x, int y) {
        return 0;
    }
}

class MyDerivedClass : MyAbstractClass {

    public override int CalculateProduct(int x, int y) {
        return x * y;
    }

    public override int CalculateSum(int x, int y) {
        return x + y;
    }
}

class OverrideTest {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}