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

class Listing_18 {

    static void Main(string[] args) {

        // create an instance of VolvoCar
        VolvoCar myVolvo = new VolvoCar("Adam Freeman", "Black", 30, "Premium");

        // upcast from VolvoCar to Car
        Car myCar = myVolvo;

        // upcast from Car to object
        object myObject = myCar;

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}


