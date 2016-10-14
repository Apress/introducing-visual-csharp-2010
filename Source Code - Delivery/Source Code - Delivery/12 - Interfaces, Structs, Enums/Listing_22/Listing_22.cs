using System;

public enum PaintColor {
    Black,
    Red,
    Green,
    Silver,
}

public class VolvoC30 {
    public string CarOwner;
    public PaintColor Color;

    public VolvoC30(string newOwner, PaintColor paintColor) {
        CarOwner = newOwner;
        Color = paintColor;
    }
}

class Listing_22_23 {

    static void Main(string[] args) {

        VolvoC30 myCar = new VolvoC30("Adam Freeman", PaintColor.Black);

        PaintColor color = PaintColor.Green;

        switch (color) {
            case PaintColor.Black:
                Console.WriteLine("Paint Color is black");
                break;

            case PaintColor.Green:
                Console.WriteLine("Paint Color is green");
                break;

            case PaintColor.Red:
            case PaintColor.Silver:
                Console.WriteLine("Paint Color is red or silver");
                break;
        }

        if (color == PaintColor.Black) {
            Console.WriteLine("Paint color is black");
        }
             

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
