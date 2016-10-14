using System;

class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    private static int instanceCount;
    private static int instanceLimit;

    static Person() {
        instanceCount = 0;
        instanceLimit = 3;
    }

    private Person(string name, int age, string city) {
        Name = name; Age = age; City = city;
    }

    public static Person CreatePerson(string name, int age, string city) {
        // check to see if we have reached the limit
        if (instanceCount >= instanceLimit) {
            throw new InvalidOperationException("Instance limit reached");
        } else {
            // create a new instance of the class
            Person p = new Person(name, age, city);
            // increment the counter
            instanceCount++;
            // return the newly created instance
            return p;
        }
    }
}

class Listing_54 {

    static void Main(string[] args) {

        for (int i = 1; i < 5; i++) {
            try {
                Person p = Person.CreatePerson("Adam Freeman", 38, "London");
                Console.WriteLine("Successfully Created Instance Number: {0}", i);
            } catch (InvalidOperationException) {
                Console.WriteLine("Exception thrown while creating instance {0}", i);
                break;
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}