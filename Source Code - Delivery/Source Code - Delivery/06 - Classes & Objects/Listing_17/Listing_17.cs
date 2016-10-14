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

    public virtual int CalculateFuelForTrip(int tripDistance) {
        return tripDistance / MilesPerGallon;
    }
}

class VolvoCar : Car {
    public string VolvoSoundSystem;

    public VolvoCar(string owner, string paint, int mpg, string sound)
        : base(owner, paint, mpg) {

        // set the value of the VolvoSoundSystem 
        VolvoSoundSystem = sound;
    }

    public override int CalculateFuelForTrip(int tripDistance) {
        System.Console.WriteLine("Derived Method Called");
        return base.CalculateFuelForTrip(tripDistance);
    }
}

class Listing_17 {

    static void Main(string[] args) {

        // create a new instance fof VolvoCar and upcast it to Car
        Car myCar = new VolvoCar("Adam Freeman", "Black", 30, "Premium");

        // call the CalculateFuelForTrip method and print out the result
        int result = myCar.CalculateFuelForTrip(1000);
        Console.WriteLine("Result: {0} gallons", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}


