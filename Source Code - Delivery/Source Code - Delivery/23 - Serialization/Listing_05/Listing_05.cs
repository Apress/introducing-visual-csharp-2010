using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Person {
    private string name;
    private string city;

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

class Listing_05 {

    static void Main(string[] args) {

        // create a number of Person objects
        Person person1 = new Person("Adam Freeman", "London");
        Person person2 = new Person("Joe Smith", "New York");
        Person person3 = new Person("Angela Peters", "Hong Kong");

        // create the binary formatter
        IFormatter formatter = new BinaryFormatter();

        // create a stream to hold the serialized data
        Stream fileStream = File.Open("people.bin", FileMode.Create);

        // serialize the Person objects
        foreach (Person p in new Person[] {person1, person2, person3}) {
            formatter.Serialize(fileStream, p);
        }

        // reposition the stream cursor so we can read the data back
        fileStream.Seek(0, SeekOrigin.Begin);

        // deserialize the Person objects from the Stream
        for (int i = 0; i < 3; i++) {
            Person p = (Person)formatter.Deserialize(fileStream);
            Console.WriteLine("--- Deserialized Person ---");
            Console.WriteLine("Name: {0}", p.Name);
            Console.WriteLine("City: {0}", p.City);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
