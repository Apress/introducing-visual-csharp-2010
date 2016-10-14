using System;

class BaseClass {

    public virtual void PrintMessage() {
        Console.WriteLine("Base class message");
    }
}

class DerivedClass : BaseClass {

    public override void PrintMessage() {
        Console.WriteLine("Derived class message");
    }
}

class FurtherDerivedClass : DerivedClass {

    public override void PrintMessage() {
        Console.WriteLine("Further derived class message");
    }
}

class Listing_34 {

    static void Main(string[] args) {

        // create a new instance of the derived class
        DerivedClass dClass = new FurtherDerivedClass();
        // print out the message
        dClass.PrintMessage();

        // create a new instance of DerivedClass but 
        // assign it to a BaseClass local variable 
        BaseClass bClass = dClass;
        // print the message
        bClass.PrintMessage();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
