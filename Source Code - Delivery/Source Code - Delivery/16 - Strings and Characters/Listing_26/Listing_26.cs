using System;

class Car {
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
}

class Listing_26 {

    static void Main(string[] args) {

        // create two Car objects
        Car myVolvo = new Car() { Manufacturer = "Volvo", Model = "C30", Color = "Black" };
        Car myFord = new Car() { Manufacturer = "Ford", Model = "Fiesta", Color = "Green" };

        // write out the string representations of the Car objects
        Console.WriteLine("Volvo Object: {0}", myVolvo);
        Console.WriteLine("Ford Object: {0}", myFord);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
