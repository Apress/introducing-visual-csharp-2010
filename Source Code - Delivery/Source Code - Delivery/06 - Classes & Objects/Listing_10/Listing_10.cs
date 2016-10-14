using System;

public class EngineSpec {
    public int EngineCapacity;
    public string FuelType;

    public EngineSpec(int capacity, string type) {
        EngineCapacity = capacity;
        FuelType = type;
    }
}

public class VolvoC30 {
    public string CarOwner;
    public string PaintColor;
    public int MilesPerGallon = 30;
    public EngineSpec Engine;


    public VolvoC30(string newOwner, string paintColor, EngineSpec engineSpec) {
        CarOwner = newOwner;
        PaintColor = paintColor;
        Engine = engineSpec;
    }

    public int CalculateFuelForTrip(int tripDistance) {
        return tripDistance / MilesPerGallon;
    }

    public void PrintCarDetails() {
        System.Console.WriteLine("--- Car Details ---");
        System.Console.WriteLine("Car Owner: {0}", CarOwner);
        System.Console.WriteLine("Car Color: {0}", PaintColor);
        System.Console.WriteLine("Gas Mileage: {0} mpg", MilesPerGallon);
        System.Console.WriteLine("Engine Capacity: {0} cc", Engine.EngineCapacity);
        System.Console.WriteLine("Fuel Type: {0}", Engine.FuelType);
    }
}

public class Volvo_Test {

    public static void Main() {

        // create an EngineSpec object
        EngineSpec spec = new EngineSpec(2000, "Diesel");

        // create a new object of the VolvoC30 type
        VolvoC30 myCar = new VolvoC30("Adam Freeman", "Black", spec);

        // create a second VolvoC30 object
        VolvoC30 joesCar = new VolvoC30("Joe Smith", "Silver", spec);

        // read and print out the Engine.EngineCapacity field of both objects
        // and the local variable
        Console.WriteLine("--- Values Before Change ---");
        Console.WriteLine("Local EngineSpec Variable: {0}", spec.EngineCapacity);
        Console.WriteLine("myCar field value: {0}", myCar.Engine.EngineCapacity);
        Console.WriteLine("joesCar field value: {0}", joesCar.Engine.EngineCapacity);

        // modify the capacity of the local variable
        spec.EngineCapacity = 2500;

        // read and print out the Engine.EngineCapacity field of both objects
        // and the local variable
        Console.WriteLine("--- Values After Change ---");
        Console.WriteLine("Local EngineSpec Variable: {0}", spec.EngineCapacity);
        Console.WriteLine("myCar field value: {0}", myCar.Engine.EngineCapacity);
        Console.WriteLine("joesCar field value: {0}", joesCar.Engine.EngineCapacity);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
