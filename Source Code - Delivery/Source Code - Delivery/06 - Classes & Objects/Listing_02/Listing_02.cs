using System;

public class VolvoC30 {
    public string CarOwner;
    public string PaintColor;
    public int MilesPerGallon = 30;

}

public class Listing_02 {

    public static void Main() {

        // create a new object of the MyClass type
        VolvoC30 myCar = new VolvoC30();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
