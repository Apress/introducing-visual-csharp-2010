using System;
using System.IO;
using System.Runtime.Serialization;

[DataContract]
public class Person {
    private string name;
    private string city;

    public Person(string nameParam, string cityParam) {
        name = nameParam;
        city = cityParam;
    }

    [DataMember]
    public string Name {
        get { return name; }
        set { name = value; }
    }

    [DataMember]
    public string City {
        get { return city; }
        set { city = value; }
    }
}

class Listing_18 {

    static void Main(string[] args) {

        // create a new Person object
        Person myPerson = new Person("Adam Freeman", "London");

        // open the stream to the file we want to store the data in
        Stream myStream = new MemoryStream();

        // create the serialize
        DataContractSerializer serializer = new DataContractSerializer(typeof(Person));
        // serialize the Person object
        serializer.WriteObject(myStream, myPerson);

        // reset the cursor on the stream and read the serialized data
        myStream.Seek(0, SeekOrigin.Begin);
        StreamReader myReader = new StreamReader(myStream);
        Console.WriteLine(myReader.ReadToEnd());

        // reset the cursor and deserialize the object
        myStream.Seek(0, SeekOrigin.Begin);
        Person myDeserializedPerson = (Person)serializer.ReadObject(myStream);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
