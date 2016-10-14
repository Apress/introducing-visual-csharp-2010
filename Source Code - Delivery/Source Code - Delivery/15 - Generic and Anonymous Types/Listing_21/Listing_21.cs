using System;

interface IStack<T> {

    void Push(T value);

    T Pop();
}

class GenericStack<T> : IStack<T> {
    T[] dataArray = new T[10];
    int currentPos = 0;

    public void Push(T value) {
        dataArray[currentPos++] = value;
    }

    public T Pop() {
        return dataArray[--currentPos];
    }
}

class IntStack : IStack<int> {
    int[] dataArray = new int[10];
    int currentPos = 0;

    public void Push(int value) {
        dataArray[currentPos++] = value;
    }

    public int Pop() {
        return dataArray[--currentPos];
    }
}

class Listing_21 {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
