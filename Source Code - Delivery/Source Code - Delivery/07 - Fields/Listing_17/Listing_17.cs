
using System;
class BaseProduct {
    public string myField = "Base Value";
}

class DerivedProduct : BaseProduct {
    public new string myField = "Derived Value";
}

class Listing_17 {

    static void Main(string[] args) {

        // create an object from the derived class
        DerivedProduct derivedObject = new DerivedProduct();

        // upcast the objet to the base type
        BaseProduct upcastObject = derivedObject;

        // print out the field values
        Console.WriteLine("Derived Field: {0}", derivedObject.myField);
        Console.WriteLine("Base Field: {0}", upcastObject.myField);

        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

