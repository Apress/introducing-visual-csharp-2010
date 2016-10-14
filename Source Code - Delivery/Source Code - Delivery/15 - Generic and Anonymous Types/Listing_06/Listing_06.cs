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
}

class Listing_06 {

    static void Main(string[] args) {

        GenericStack<int> intStack = new GenericStack<int>();

        GenericStack<string> stringStack = new GenericStack<string>();

        Console.WriteLine("Int type: {0}", intStack.GetType());
        Console.WriteLine("String type: {0}", stringStack.GetType());

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
