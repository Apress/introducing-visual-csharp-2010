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

class GenericStack<T> {
    T[] dataArray = new T[10];
    int currentPos = 0;

    public void Push(T value) {
        dataArray[currentPos++] = value;
    }

    public T Pop() {
        return dataArray[--currentPos];
    }
}

class Listing_23 {

    static void Main(string[] args) {

        // create a GenericStack<T> using the derived type
        GenericStack<VolvoC30> volvoStack = new GenericStack<VolvoC30>();

        //// upcast the paramterized type
        //GenericStack<Car> carStack = volvoStack;    // this won't compile

        //// push in a data item via the upcast instance
        //carStack.Push(new FordFiesta());

        // pop the contents via the original instance
        // CAUTION - this would cause an exception because
        // although we are expecting a VolvoC30 object, we
        // are actually going to get a FordFiesta instead
        VolvoC30 dataItem = volvoStack.Pop();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
