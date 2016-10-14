using System;

class Car {
    public string CarOwner;
    public string PaintColor;
    public int MilesPerGallon;

    public Car(string newOwner, string paintColor, int mpg) {
        CarOwner = newOwner;
        PaintColor = paintColor;
        MilesPerGallon = mpg;
    }
}

class Listing_26 {

    static void Main(string[] args) {

        // create a Car object
        Car myCar = new Car("Adam Freeman", "Black", 30);

        // upcast the Car to an object
        object myObject = myCar;

        // make a change to the Car via the original reference
        myCar.MilesPerGallon = 40;

        // downcast the object back to a Car
        Car downcast = (Car)myObject;

        // print out the values of the fields
        Console.WriteLine("Mileage: {0}", downcast.MilesPerGallon);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
