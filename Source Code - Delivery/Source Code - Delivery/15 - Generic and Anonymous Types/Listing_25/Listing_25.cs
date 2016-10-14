using System;

class Car {
    // no members defined in this class
}

class VolvoC30 : Car {
    // no members defined in this class
}

class FordFiesta : Car {
    // no members defined in this class
}

interface IPop<out T> {

    T Pop();
}

class GenericStack<T> : IPop<T> {
    T[] dataArray = new T[10];
    int currentPos = 0;

    public void Push(T value) {
        dataArray[currentPos++] = value;
    }

    public T Pop() {
        return dataArray[--currentPos];
    }
}

class CarPrinter {

    public static void PrintFirstCarDetails(IPop<Car> carStack) {
        Car myCar = carStack.Pop();
        Console.WriteLine("Car value popped: {0}", myCar);
    }
}


class Listing_25 {

    static void Main(string[] args) {

        // create a GenericStack<T> using the derived type
        GenericStack<VolvoC30> volvoStack = new GenericStack<VolvoC30>();

        // push a data item into the stack
        volvoStack.Push(new VolvoC30());

        // print the details of the first item in the stack
        CarPrinter.PrintFirstCarDetails(volvoStack);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
