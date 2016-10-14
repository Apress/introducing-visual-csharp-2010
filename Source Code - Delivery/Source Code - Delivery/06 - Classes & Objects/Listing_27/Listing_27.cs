using System;

class Car {
    public string CarOwner;
    public string PaintColor;
    public int MilesPerGallon;
    public Engine EngineSpec;

    public Car(string newOwner, string paintColor, int mpg, Engine enginespec) {
        CarOwner = newOwner;
        PaintColor = paintColor;
        MilesPerGallon = mpg;
        EngineSpec = enginespec;
    }

    public class Engine {
        public int Capacity;
        public string FuelType;
        public string Transmission;

        public Engine(int capacity, string type, string transmission) {
            Capacity = capacity;
            FuelType = type;
            Transmission = transmission;
        }
    }
}

class NestedClass_Test {

    static void Main(string[] args) {

        // create a Car.Engine object
        Car.Engine engine = new Car.Engine(2000, "Diesel", "6-speed Automatic");

        // create a new instance of Car, including a new 
        // instance of the nested class
        Car myCar = new Car("Adam Freeman", "Black", 30, engine);
            
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
