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

class EncapsulationTest {

    static void Main(string[] args) {

        // create a new instance of Car 
        Car myCar = new Car("Adam Freeman", "Black", 30);

        // invoke the CalculateFuelForTrip method
        int fuelRequired = myCar.CalculateFuelForTrip(1000);

        // print out the result
        Console.WriteLine("Fuel required: {0} gallons", fuelRequired);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}