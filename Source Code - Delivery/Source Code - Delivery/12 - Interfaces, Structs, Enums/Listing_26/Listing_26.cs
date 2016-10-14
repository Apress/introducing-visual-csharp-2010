using System;

[Flags]
public enum CarOptions {
    AlloyWheels = 1,
    CDPlayer = 2,
    SatNav = 4,
    Bluetooth = 8
}

class Listing_27 {

    static void Main(string[] args) {

        // combine two of the values together
        CarOptions ops = CarOptions.AlloyWheels | CarOptions.SatNav;

        // test to see if the combined value contains SatNav
        bool hasSatNav = (ops & CarOptions.SatNav) == CarOptions.SatNav;

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
