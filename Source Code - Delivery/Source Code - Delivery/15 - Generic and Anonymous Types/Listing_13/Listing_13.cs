using System;

class GenericStack<T> where T : struct, IComparable<T> {
    T[] dataArray = new T[10];
    int currentPos = 0;

    public void Push(T value) {
        dataArray[currentPos++] = value;
    }

    public T Pop() {
        return dataArray[--currentPos];
    }
}

class Listing_13 {

    static void Main(string[] args) {

        // Create a stack object
        GenericStack<int> stack = new GenericStack<int>();

        // push in some data
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
