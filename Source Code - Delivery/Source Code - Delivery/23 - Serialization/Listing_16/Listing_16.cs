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

    [XmlElement("FullName")]
    public String Name {
        get { return name; }
        set { name = value; }
    }

    [XmlAttribute("PlaceOfResidence")]
    public String City {
        get { return city; }
        set { city = value; }
    }
}

class Listing_16 {

    static void Main(string[] args) {

        // create a new Person object
        Person myPerson = new Person("Adam Freeman", "London");

        // open the stream to the file we want to store the data in
        Stream myStream = new MemoryStream();

        // create the XMLSerializer
        XmlSerializer xmlserializer = new XmlSerializer(myPerson.GetType());
        // serialize the object
        xmlserializer.Serialize(myStream, myPerson);

        // reset the cursor 
        myStream.Seek(0, SeekOrigin.Begin);

        // create a tetx reader on the sream
        StreamReader reader = new StreamReader(myStream);
        // read the contents of the stream and print them out
        string serialData = reader.ReadToEnd();
        Console.WriteLine(serialData);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
