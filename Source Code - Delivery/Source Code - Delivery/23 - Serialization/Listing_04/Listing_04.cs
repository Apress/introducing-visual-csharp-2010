using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Person {
    private string name;
    private string city;
    private Company employer;

    public Person(String nameParam, String cityParam, Company companyParam) {
        name = nameParam;
        city = cityParam;
        employer = companyParam;
    }

    public String Name {
        get { return name; }
        set { name = value; }
    }

    public String City {
        get { return city; }
        set { city = value; }
    }

    public Company Employer {
        get { return employer; }
        set { employer = value; }
    }
}

[Serializable]
class Company {
    private string name;
    private string city;

    public Company(string nameParam, string cityParam) {
        name = nameParam;
        city = cityParam;
    }

    public string Name {
        get { return name; }
    }

    public string City {
        get { return city; }
    }
}

class SerializeTest {

    static void Main(string[] args) {

        // create a new company
        Company myCompany = new Company("BigCorp", "Paris");

        // create a new Person object
        Person myPerson = new Person("Adam Freeman", "London", myCompany);

        // create an output stream to the file
        Stream outputStream = File.OpenWrite("person.bin");

        // create a new binary formatter
        IFormatter serializer = new BinaryFormatter();

        // serialize the object
        serializer.Serialize(outputStream, myPerson);

        // close the stream
        outputStream.Close();

        // create a formatter
        IFormatter deserializer = new BinaryFormatter();
        // open the stream to the file
        Stream inputStream = File.OpenRead("person.bin");
        // deserialize the object
        Person deserializedPerson = (Person)deserializer.Deserialize(inputStream);

        // print out the value of the fields of the deserialized object
        Console.WriteLine("Deserialized name: {0}", deserializedPerson.Name);
        Console.WriteLine("Deserialized city: {0}", deserializedPerson.City);
        Console.WriteLine("Deserialized company name: {0}", deserializedPerson.Employer.Name);
        Console.WriteLine("Deserialized company city: {0}", deserializedPerson.Employer.City);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}