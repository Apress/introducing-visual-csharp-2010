using System;

public class VolvoC30 {
    public string CarOwner;
    public string PaintColor;
    public int MilesPerGallon = 30;
    public static int EngineCapacity = 2000;


    public VolvoC30(string newOwner, string paintColor) {
        CarOwner = newOwner;
        PaintColor = paintColor;
    }

    public int CalculateFuelForTrip(int tripDistance) {
        return tripDistance / MilesPerGallon;
    }

    public void PrintCarDetails() {
        System.Console.WriteLine("--- Car Details ---");
        System.Console.WriteLine("Car Owner: {0}", CarOwner);
        System.Console.WriteLine("Car Color: {0}", PaintColor);
        System.Console.WriteLine("Gas Mileage: {0} mpg", MilesPerGallon);
        System.Console.WriteLine("Engine Capacity: {0} cc", EngineCapacity);
    }
}

public class Volvo_Test {

    public static void Main() {

        // print out the value of the static field
        int value = VolvoC30.EngineCapacity;
        Console.WriteLine("Static field value: {0}",  value);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
