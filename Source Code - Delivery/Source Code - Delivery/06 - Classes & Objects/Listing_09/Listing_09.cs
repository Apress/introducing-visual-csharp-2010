using System;

public class VolvoC30 {
    public string CarOwner;
    public string PaintColor;
    public int MilesPerGallon = 30;
    public int ServiceInterval;

    public VolvoC30(string newOwner, string paintColor, int serviceInt) {
        CarOwner = newOwner;
        PaintColor = paintColor;
        ServiceInterval = serviceInt;
    }

    public int CalculateFuelForTrip(int tripDistance) {
        return tripDistance / MilesPerGallon;
    }

    public void PrintCarDetails() {
        System.Console.WriteLine("--- Car Details ---");
        System.Console.WriteLine("Car Owner: {0}", CarOwner);
        System.Console.WriteLine("Car Color: {0}", PaintColor);
        System.Console.WriteLine("Gas Mileage: {0} mpg", MilesPerGallon);
        System.Console.WriteLine("Service Interval: {0} miles", ServiceInterval);
    }
}

public class Volvo_Test {

    public static void Main() {

        // define a common service interval variable
        int serviceInterval = 40000;

        // create a new object of the VolvoC30 type
        VolvoC30 myCar = new VolvoC30("Adam Freeman", "Black", serviceInterval);

        // create a second VolvoC30 object
        VolvoC30 joesCar = new VolvoC30("Joe Smith", "Silver", serviceInterval);

        // modify the value of service interval in myCar
        myCar.ServiceInterval = 50000;

        // read and print out the ServiceInterval field for both objects
        Console.WriteLine("myCar field value: {0}", myCar.ServiceInterval);
        Console.WriteLine("joesCar field value: {0}", joesCar.ServiceInterval);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
