using System;
using System.Xml.Serialization;
using System.IO;

public class Person {
    private string name;
    private string city;

    public Person() {
        // do nothing
    }

    public Person(String nameParam, String cityParam) {
        name = nameParam;
        city = cityParam;
    }

    public String Name {
        get { return name; }
        set { name = value; }
    }

    public String City {
        get { return city; }
        set { city = value; }
    }
}

class Listing_13 {

    static void Main(string[] args) {

        // create a new Person object
        Person myPerson = new Person("Adam Freeman", "London");

        // open the stream to the file we want to store the data in
        Stream outputStream = File.OpenWrite("person.xml");

        // create the XMLSerializer
        XmlSerializer serializer = new XmlSerializer(myPerson.GetType());
        // serialize the object
        serializer.Serialize(outputStream, myPerson);
        // close the stream to the file
        outputStream.Close();

        // open a stream so we can read the file
        Stream inputStream = File.OpenRead("person.xml");
        // create an XmlSerializer object
        XmlSerializer deserializer = new XmlSerializer(typeof(Person));
        // deserialize the object from the stream
        Person myDeserializedPerson = (Person)deserializer.Deserialize(inputStream);

        // print out details from the deserialized person object
        Console.WriteLine("Name: {0}", myDeserializedPerson.Name);
        Console.WriteLine("City: {0}", myDeserializedPerson.City);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
