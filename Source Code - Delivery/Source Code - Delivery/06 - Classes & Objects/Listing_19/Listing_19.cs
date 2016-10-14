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

class Listing_19 {

    static void Main(string[] args) {

        // create a VolvoCar object
        VolvoCar myVolvo = new VolvoCar("Adam Freeman", "Black", 30, "Premium");

        // perform an implicit cast by upcasting
        Car myCar = myVolvo;

        // perform an implicit cast by calling a method
        // that takes a base type as a parameter
        PrintCarDetails(myVolvo);

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
