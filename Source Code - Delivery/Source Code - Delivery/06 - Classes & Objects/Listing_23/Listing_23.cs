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

class Listing_23 {

    static void Main(string[] args) {

        // create an instance of Bicycle and upcast it to object
        object myObject = new Bicycle("Adam Freeman", 24, "Comfort");

        // use the is keyword to check the type
        bool isCar = myObject is Car;
        bool isBike = myObject is Bicycle;
        bool isObject = myObject is object;

        Console.WriteLine("Is Car? {0}", isCar);
        Console.WriteLine("Is Bike? {0}", isBike);
        Console.WriteLine("Is Object? {0}", isObject);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
