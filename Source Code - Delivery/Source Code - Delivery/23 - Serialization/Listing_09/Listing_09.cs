using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Person {
    private string name;
    private string city;
    [OptionalField(VersionAdded=2)]
    private int age;

    public Person(String nameParam, String cityParam, int ageParam) {
        name = nameParam;
        city = cityParam;
        age = ageParam;
    }

    public String Name {
        get { return name; }
        set { name = value; }
    }

    public String City {
        get { return city; }
        set { city = value; }
    }

    public int Age {
        get { return age; }
        set { age = value; }
    }
}

class Listing_09 {

    static void Main(string[] args) {

        if (false) {

            //// create a new Person object
            //Person myPerson = new Person("Adam Freeman", "London");

            //// create an output stream to the file
            //Stream outputStream = File.OpenWrite("person.bin");

            //// create a new binary formatter
            //IFormatter serializer = new BinaryFormatter();

            //// serialize the object
            //serializer.Serialize(outputStream, myPerson);

            //// close the stream
            //outputStream.Close();

        } else {

            // create a formatter
            IFormatter deserializer = new BinaryFormatter() { AssemblyFormat = FormatterAssemblyStyle.Full };

            // open the stream to the file
            Stream inputStream = File.OpenRead("person.bin");
            // deserialize the object
            Person deserializedPerson = (Person)deserializer.Deserialize(inputStream);

            // print out the value of the fields of the deserialized object
            Console.WriteLine("Deserialized name: {0}", deserializedPerson.Name);
            Console.WriteLine("Deserialized city: {0}", deserializedPerson.City);
            Console.WriteLine("Deserialized age: {0}", deserializedPerson.Age);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}