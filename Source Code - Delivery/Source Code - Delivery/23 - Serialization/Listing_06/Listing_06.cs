using System;
using System.Collections.Generic;
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

class Listing_06 {

    static void Main(string[] args) {

        // create the collection
        List<Person> listCollection = new List<Person>();

        // create a number of Person objects
        listCollection.Add(new Person("Adam Freeman", "London"));
        listCollection.Add(new Person("Joe Smith", "New York"));
        listCollection.Add(new Person("Angela Peters", "Hong Kong"));

        // create the binary formatter
        IFormatter formatter = new BinaryFormatter();

        // create a stream to hold the serialized data
        Stream fileStream = File.Open("peopleCollection.bin", FileMode.Create);

        // serialize the collection
        formatter.Serialize(fileStream, listCollection);

        // reposition the stream cursor so we can read the data back
        fileStream.Seek(0, SeekOrigin.Begin);

        // deserialize the collection from the stream
        List<Person> deserializedCollection = (List<Person>)formatter.Deserialize(fileStream);

        foreach (Person p in deserializedCollection) {
            Console.WriteLine("--- Deserialized List Person ---");
            Console.WriteLine("Name: {0}", p.Name);
            Console.WriteLine("City: {0}", p.City);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
