using System;

class BaseClass {

    public virtual int CalculateSum(int x, int y) {
        return x + y;
    }
}

class DerivedClass : BaseClass {

    public DerivedClass() : base() {
        // constructor statements go here
    }

    public override int CalculateSum(int x, int y) {
        return base.CalculateSum(x, y);
    }
}

class BaseTest {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
