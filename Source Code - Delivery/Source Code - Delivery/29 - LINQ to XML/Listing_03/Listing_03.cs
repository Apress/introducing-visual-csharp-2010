using System;
using System.Xml.Linq;

enum FruitSize {
    Small, Medium, Large
}

class Fruit {

    public Fruit(string nameParam, int stockParam) {
        Name = nameParam;
        ItemsInStock = stockParam;
    }

    public string Name { get; set; }
    public int ItemsInStock { get; set; }

    public override string ToString() {
        return Name;
    }
}

class Listing_03 {

    static void Main(string[] args) {

        // create a Fruit object
        Fruit myFruitObject = new Fruit("Orange", 200);

        // create XElements using the Fruit object
        XElement myNameElement = new XElement("Name", myFruitObject);
        XElement mySizeElement = new XElement("Size", FruitSize.Large);

        // create a hierarchy of XElements
        XElement myFruitElement = new XElement("Fruit", myNameElement, mySizeElement);

        // print out the XElement object
        Console.WriteLine(myFruitElement);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}