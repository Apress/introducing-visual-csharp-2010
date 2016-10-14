using System;

class Person {

    public Person(string name) {
        Name = name;
    }

    public string Name { get; set; }
}

class MyClass {

    public void MyMethod(Person employee, int count) {
        // print out the values of the parameters
        Console.WriteLine("MyMethod - parameter values: {0}, {1}", employee.Name, count);

        // modify the parameters
        employee.Name = "Joe Smith";
        count = 20;

        // print out the values again
        Console.WriteLine("MyMethod - modified parameter values: {0}, {1}", employee.Name, count);
    }
}

class Listing_11 {

    static void Main(string[] args) {

        // define local variables to use as parameters
        Person myperson = new Person("John Doe");
        int mycount = 10;

        // print out the values of the variables
        Console.WriteLine("Main Method - variable values before: {0}, {1}", myperson.Name, mycount);

        // create a new instance of MyClass and call the method
        MyClass mc = new MyClass();
        mc.MyMethod(myperson, mycount);

        // print out the value of the variables again
        Console.WriteLine("Main Method - variable values after: {0}, {1}", myperson.Name, mycount);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}