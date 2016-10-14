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

class Bicycle {
    public string BikeOwner;
    public int NumberOfGears;
    public string SaddleType;

    public Bicycle(string owner, int gears, string saddle) {
        BikeOwner = owner;
        NumberOfGears = gears;
        SaddleType = saddle;
    }
}

class Listing_24 {

    static void Main(string[] args) {

        // create an instance of Bicycle and upcast it to object
        object myObject = new Bicycle("Adam Freeman", 24, "Comfort");

        // use the as operator to convert the type
        Bicycle myBike = myObject as Bicycle;

        // try to convert the object to a Car
        Car myCar = myObject as Car;

        // print out the result of the as operations
        Console.WriteLine("myBike is null? {0}", myBike == null);
        Console.WriteLine("myCar is null? {0}", myCar == null);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
