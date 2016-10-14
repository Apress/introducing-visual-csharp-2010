using System;

[AttributeUsage(AttributeTargets.Class, Inherited=true ) ]
public class DetailLevelAttribute : Attribute {
    private bool useDetailed;

    public DetailLevelAttribute(bool useDetailedParam) {
        useDetailed = useDetailedParam;
    }

    public bool UseDetailed {
        get { return useDetailed; }
    }
}

class Car {
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

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

[DetailLevel(true)]
class VolvoCar : Car {

    public VolvoCar(string model, string color)
        : base("Volvo", model, color) {
        // do nothing
    }
}

class VolvoC30 : VolvoCar {

    public VolvoC30(string color)
        : base("C30", color) {
        // do nothing
    }
}



class CustomAttributeTest {

    static void Main(string[] args) {

        VolvoC30 myCar = new VolvoC30("Black");

        Console.WriteLine("Car: {0}", myCar);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}