using System;

public class VolvoC30 {
    public string CarOwner;
    public string PaintColor;
    public int MilesPerGallon = 30;


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

public class Listing_03 {

    public static void Main() {

        // create a new object of the MyClass type
        VolvoC30 myCar = new VolvoC30();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
