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

    public virtual void PrintCarDetails() {
        System.Console.WriteLine("--- Car Details ---");
        System.Console.WriteLine("Car Owner: {0}", CarOwner);
        System.Console.WriteLine("Car Color: {0}", PaintColor);
        System.Console.WriteLine("Gas Mileage: {0} mpg", MilesPerGallon);
    }
}

class VolvoCar : Car {
    public string VolvoSoundSystem;

    public VolvoCar(string owner, string paint, int mpg, string sound)
        : base(owner, paint, mpg) {

        // set the value of the VolvoSoundSystem 
        VolvoSoundSystem = sound;
    }

    public override void PrintCarDetails() {
        base.PrintCarDetails();
        System.Console.WriteLine("VolvoSoundSystem: {0}", VolvoSoundSystem);
    }
}

class FordCar : Car {
    public string FordWheelsOption;

    public FordCar(string owner, string paint, int mpg, string wheels)
        : base(owner, paint, mpg) {

        // set the value for the wheels
        FordWheelsOption = wheels;
    }
}

class VolvoC30 : VolvoCar {

    public VolvoC30(string owner, string paint, int mpg, string sound)
        : base(owner, paint, mpg, sound) {

    }
}

class FordFiesta : FordCar {

    public FordFiesta(string owner, string paint, int mpg, string wheels)
        : base(owner, paint, mpg, wheels) {

    }
}

class CarTest {

    static void Main(string[] args) {

        // create a new instance of Car
        //Car myCar = new Car("Adam Freeman", "Black", 30);
        //myCar.PrintCarDetails();

        // create an instance of VolvoCar
        //VolvoCar myVolvo = new VolvoCar("Adam Freeman", "Black", 30, "High Performance");
        //myVolvo.PrintCarDetails();

        //int fuelRequired = myVolvo.CalculateFuelForTrip(1000);
        //Console.WriteLine("Fuel Required: {0} gallons", fuelRequired);

        VolvoC30 myC30 = new VolvoC30("Adam Freeman", "Black", 30, "High Performance");
        myC30.PrintCarDetails();
        FordFiesta myFiesta = new FordFiesta("Joe Smith", "Yellow", 35, "18 inch sports");
        myFiesta.PrintCarDetails();
        




        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
