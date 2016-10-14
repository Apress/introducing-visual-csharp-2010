using System;

class BaseClass {

    public void PrintMessage() {
        Console.WriteLine("Base class message");
    }
}

class DerivedClass : BaseClass {

    public void PrintMessage() {
        Console.WriteLine("Derived class message");
    }
}

class Listing_30 {

    static void Main(string[] args) {

        // create a new instance of the base class
        BaseClass bClass = new BaseClass();
        // print out the message
        bClass.PrintMessage();

        // create a new instance of the derived class
        DerivedClass dClass = new DerivedClass();
        // print out the message
        dClass.PrintMessage();

        // create a new instance of DerivedClass but 
        // assign it to a BaseClass local variable 
        bClass = dClass;
        // print the message
        bClass.PrintMessage();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
