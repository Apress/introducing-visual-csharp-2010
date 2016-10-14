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

public class FordFiesta {
    public string CarOwner;
    public string PaintColor;
    public int MilesPerGallon = 30;

    public FordFiesta(string newOwner, string paintColor) {
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


class CarTest {

    static void Main(string[] args) {

        // create a VolvoC30 object
        VolvoC30 myVolvo = new VolvoC30("Adam Freeman", "Black");

        // create a FordFiesta object
        FordFiesta myFord = new FordFiesta("Joe Smith", "Green");

        // call the PrintCarDetails method on both car objects
        myVolvo.PrintCarDetails();
        myFord.PrintCarDetails();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}