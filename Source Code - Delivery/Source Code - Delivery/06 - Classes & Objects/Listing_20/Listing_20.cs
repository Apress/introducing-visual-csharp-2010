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

class Listing_20 {

    static void Main(string[] args) {

        // create a VolvoCar object and upcast it to object
        object myObject = new VolvoCar("Adam Freeman", "Black", 30, "Premium");

        // perform an explicit cast of myObject to Car
        Car myCar = (Car)myObject;

        // read a field from the Car object
        Console.WriteLine("Owner: {0}", myCar.CarOwner);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
