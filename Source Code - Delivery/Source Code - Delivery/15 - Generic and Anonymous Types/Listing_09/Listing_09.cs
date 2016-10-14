using System;

class GenericStack<T> {
    T[] dataArray;
    int currentPos;

    public GenericStack(int capacity) {
        dataArray = new T[capacity];
        currentPos = 0;
    }

    public void Push(T value) {
        dataArray[currentPos++] = value;
    }

    public T Pop() {
        return dataArray[--currentPos];
    }
}

class Listing_09 {

    static void Main(string[] args) {

        // create a struct value
        GenericStack<int> structStack = new GenericStack<int>(10);

        // push some values in to the stack
        structStack.Push(2);
        structStack.Push(4);
        structStack.Push(8);

        // pop and write out the values
        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Popped Value: {0}", structStack.Pop());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
