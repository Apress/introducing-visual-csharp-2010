using System;

class GenericStack<T> where T : IComparable<T> {
    T[] dataArray = new T[10];
    int currentPos = 0;

    public void Push(T value) {
        dataArray[currentPos++] = value;
    }

    public T Pop() {
        return dataArray[--currentPos];
    }

    public bool Contains(T value) {
        for (int i = 0; i < currentPos; i++) {
            if (value.CompareTo(dataArray[i]) == 0) {
                return true;
            }
        }
        return false;
    }
}

class Listing_12 {

    static void Main(string[] args) {

        // Create a stack object
        GenericStack<string> stack = new GenericStack<string>();

        // push in some data
        stack.Push("Introduction");
        stack.Push("to");
        stack.Push("C#");

        // see if the stack contains a specific value
        Console.WriteLine("Stack contains 'C#'? {0}", stack.Contains("C#"));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
