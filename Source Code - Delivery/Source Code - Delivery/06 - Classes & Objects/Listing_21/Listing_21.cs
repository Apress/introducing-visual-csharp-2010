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

class VolvoCar : Car {
    public string VolvoSoundSystem;

    public VolvoCar(string owner, string paint, int mpg, string sound)
        : base(owner, paint, mpg) {

        // set the value of the VolvoSoundSystem 
        VolvoSoundSystem = sound;
    }
}

class Listing_21 {

    static void Main(string[] args) {

        // create a VolvoCar object and upcast it to object
        object myObject = new VolvoCar("Adam Freeman", "Black", 30, "Premium");

        // call the PrintCarDetails method and explicitly cast the 
        // object in a single statement
        PrintCarDetails((Car)myObject);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void PrintCarDetails(Car car) {
        Console.WriteLine("--- Car Details ---");
        Console.WriteLine("Owner: {0}", car.CarOwner);
        Console.WriteLine("Color: {0}", car.PaintColor);
        Console.WriteLine("Mileage: {0}", car.MilesPerGallon);
    }
}
