using System;
using System.Text;

class Car {
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public override string ToString() {
        // use the composite formatting feature to create
        // a meaningful string representation of this object
        return string.Format("Manufacturer: {0}, Model: {1}, Color: {2}",
            Manufacturer, Model, Color);
    }
}

class CarFormatProvider : IFormatProvider {

    public object GetFormat(Type formatType) {
        if (formatType == typeof(System.ICustomFormatter)) {
            return new CarFormatter();
        } else {
            return null;
        }
    }
}

class CarFormatter : ICustomFormatter {
    
    public string Format(string format, object arg, IFormatProvider formatProvider) {
        // cast the object to a car
        Car myCar = (Car) arg;
        // create a string builder so we can compose the string
        StringBuilder myBuilder = new StringBuilder();
        // switch on each character in the format component
        foreach (char c in format.ToUpper()) {
            switch (c) {
                case 'M':
                    myBuilder.AppendFormat(" Manufacturer: {0}", myCar.Manufacturer);
                    break;
                case 'O':
                    myBuilder.AppendFormat(" Model: {0}", myCar.Model);
                    break;
                case 'C':
                    myBuilder.AppendFormat(" Color: {0}", myCar.Color);
                    break;
            }
        }
        // return the contents of the StringBuilder as a string
        return myBuilder.ToString().Trim();
    }
}

class CustomFormatTest {

    static void Main(string[] args) {

        // create two Car objects
        Car myVolvo = new Car() { Manufacturer = "Volvo", Model = "C30", Color = "Black" };

        // create some custom formatters
        CarFormatProvider formatProvider = new CarFormatProvider();

        // use the custom formatter to format the object
        string outputString = string.Format(formatProvider, "Car Details: {0:CMO}", myVolvo);

        // write out the formatted string
        Console.WriteLine(outputString);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
