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
}


class Listing_03 {

    static void Main(string[] args) {

        // create a new IntStack
        GenericStack<int> stack = new GenericStack<int>();

        stack.Push(2);
        //stack.Push("apple");
        stack.Push(8);

        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Pop value: {0}", stack.Pop());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
