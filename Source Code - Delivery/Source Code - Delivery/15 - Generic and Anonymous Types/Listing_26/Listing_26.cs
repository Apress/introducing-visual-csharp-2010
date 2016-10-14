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

//interface IPop<out T> {

//    T Pop();
//}

interface IPush<in T> {

    void Push(T value);
}

class GenericStack<T> : IPush<T> {
    T[] dataArray = new T[10];
    int currentPos = 0;

    public void Push(T value) {
        dataArray[currentPos++] = value;
    }

    public T Pop() {
        return dataArray[--currentPos];
    }
}

class Listing_26 {

    static void Main(string[] args) {

        // create a GenericStack<T> using the base type
        GenericStack<Car> carStack = new GenericStack<Car>();

        // convert to the contravariant interface
        IPush<VolvoC30> volvoPush = carStack;
        // push in a value via the contravariant inteface
        volvoPush.Push(new VolvoC30());

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
