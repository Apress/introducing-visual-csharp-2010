using System;

class BaseClass {

    public void PrintMessage() {
        Console.WriteLine("Base class message");
    }
}

class DerivedClass : BaseClass {

    public new void PrintMessage() {
        base.PrintMessage();
        Console.WriteLine("Derived class message");
    }
}

class Listing_32 {

    static void Main(string[] args) {

        // create a new instance of the derived class
        DerivedClass dClass = new DerivedClass();
        // print out the message
        dClass.PrintMessage();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
