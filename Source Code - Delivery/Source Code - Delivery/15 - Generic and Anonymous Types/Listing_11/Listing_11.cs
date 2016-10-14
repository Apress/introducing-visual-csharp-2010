using System;

class GenericStack<T> {
    T[] dataArray = new T[10];
    int currentPos = 0;

    public void Push(T value) {
        string str = value as string;
        if (str != null) {
            Console.WriteLine("Value is a string: {0}", value);
        }
        dataArray[currentPos++] = value;
    }

    public T Pop() {
        return dataArray[--currentPos];
    }
}


class Listing_11 {

    static void Main(string[] args) {

        GenericStack<string> stringStack = new GenericStack<string>();

        // push in an item of data
        stringStack.Push("Introduction to C#");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
