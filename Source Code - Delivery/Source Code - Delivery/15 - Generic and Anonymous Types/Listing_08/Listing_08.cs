using System;

class GenericStack<T> {
    T[] dataArray = new T[10];
    int currentPos = 0;

    public void Push(T value) {
        dataArray[currentPos++] = value;
    }

    public T Pop() {
        return dataArray[--currentPos];
    }

    public T this[int index] {
        get {
            return dataArray[index];
        }
    }

    public int CurrentPosition {
        get {
            return currentPos;
        }
    }
}

class Listing_08 {

    static void Main(string[] args) {

        GenericStack<int> intStack = new GenericStack<int>();

        intStack.Push(2);
        intStack.Push(4);
        intStack.Push(8);

        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Pop value: {0}", intStack.Pop());
        }

        GenericStack<string> stringStack = new GenericStack<string>();
        stringStack.Push("C#");
        stringStack.Push("to");
        stringStack.Push("Introduction");

        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Pop value: {0}", stringStack.Pop());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
