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

    public int CalculateFuelForTrip(int tripDistance) {
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
}

class TripPrinter {

    public  void PrintTripDetails(Car myCar) {
        int[] distances = { 50, 100, 250, 500 };

        Console.WriteLine("--- Trip details ---");
        foreach (int dist in distances) {

            Console.WriteLine("{0} miles requires: {1} gallons",
                dist,
                myCar.CalculateFuelForTrip(dist));
        }
    }
}

class PolymorphismTest {

    static void Main(string[] args) {

        //// create an instance of Car
        //Car myCar = new Car("Adam Freeman", "Black", 30);

        //// call the TripPrinter.PrintTripDetails method
        //TripPrinter printer = new TripPrinter();
        //printer.PrintTripDetails(myCar);

        //// create an instance of VolvoCar
        //VolvoCar myVolvo = new VolvoCar("Adam Freeman", "Black", 30, "High Performance");

        //// call the TripPrinter.PrintTripDetails method
        //TripPrinter printer = new TripPrinter();
        //printer.PrintTripDetails(myVolvo);

        Car myCar = new VolvoCar("Adam Freeman", "Black", 30, "High Performance");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}