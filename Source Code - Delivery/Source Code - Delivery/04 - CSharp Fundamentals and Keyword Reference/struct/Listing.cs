using System;

class @struct {

    public struct Person {
        public string Name;
        public int Age;
        public string City;

        public Person(string name, int age, string city) {
            Name = name;
            Age = age;
            City = city;
        }
    }

    static void Main(string[] args) {

        Person myPerson = new Person("Adam Freeman", 38, "London");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
