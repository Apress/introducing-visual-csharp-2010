using System;

public class VolvoC30 {
    public string CarOwner;
    public string PaintColor;
    public int MilesPerGallon = 30;

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
    }
}

public class Volvo_Test {

    public static void Main() {

        // create a new VolvoC30 object
        VolvoC30 myCar = new VolvoC30("Adam Freeman", "Black");

        // call the CalculateFuelForTrip for a 1000 mile trip
        int fuelRequired = myCar.CalculateFuelForTrip(1000);
        Console.WriteLine("Fuel Required: {0} gallons", fuelRequired);

        // call the PrintCarDetails method
        myCar.PrintCarDetails();
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
