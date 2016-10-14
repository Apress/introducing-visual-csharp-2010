using System;

public class DetailLevelAttribute : Attribute {

    public DetailLevelAttribute(bool useDetailed) {
        UseDetailed = useDetailed;
    }

    public bool UseDetailed {
        get;
        private set;
    }
}

class Car {
    public string Manufacturer {get; set;}
    public string Model {get; set;}
    public string Color {get; set;}

    public Car(string manufacturer, string model, string color) {
        Manufacturer = manufacturer;
        Model = model;
        Color = color;
    }       

    public sealed override string ToString() {
        // see if the attribute has been applied to this class
        DetailLevelAttribute attr = Attribute.GetCustomAttribute(
            this.GetType(), typeof(DetailLevelAttribute)) as DetailLevelAttribute;

        if (attr != null && attr.UseDetailed) {
            // we need to provide a detailed string representation
            return string.Format("Manufacturer: {0}, Model: {1}, Color: {2}",
                Manufacturer, Model, Color);
        } 
        // we don't have an attribute, or we do have an attribute, but the 
        // UseDetailed property is set to false - call the base implementation
        // of this method
        return base.ToString();
    }
}

//[DetailLevel(true)]
class VolvoCar : Car {

    public VolvoCar(string model, string color) : base("Volvo", model, color) {
        // do nothing
    }
}



class CustomAttributeTest {

    static void Main(string[] args) {

        VolvoCar myCar = new VolvoCar("C30", "Black");

        Console.WriteLine("Car: {0}", myCar);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}