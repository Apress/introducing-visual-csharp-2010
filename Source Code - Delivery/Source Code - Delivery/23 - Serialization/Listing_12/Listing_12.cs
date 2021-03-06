﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

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

class Listing_12 {

    static void Main(string[] args) {

        // create a new Person object
        Person myPerson = new Person("Adam Freeman", "London");

        // create an output stream to the file
        Stream outputStream = File.OpenWrite("person.soap");

        // create a new binary formatter
        IFormatter serializer = new SoapFormatter();

        // serialize the object
        serializer.Serialize(outputStream, myPerson);

        // close the stream
        outputStream.Close();

        // create a formatter
        IFormatter deserializer = new SoapFormatter();
        // open the stream to the file
        Stream inputStream = File.OpenRead("person.soap");
        // deserialize the object
        Person deserializedPerson = (Person)deserializer.Deserialize(inputStream);

        // print out the value of the fields of the deserialized object
        Console.WriteLine("Deserialized name: {0}", deserializedPerson.Name);
        Console.WriteLine("Deserialized city: {0}", deserializedPerson.City);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
