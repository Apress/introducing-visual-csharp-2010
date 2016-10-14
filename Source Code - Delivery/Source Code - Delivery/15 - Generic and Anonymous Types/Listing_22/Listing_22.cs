using System;

struct GenericStack<T> where T: struct {
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

class Listing_22 {

    static void Main(string[] args) {

        // create a stack
        GenericStack<int> stack = new GenericStack<int>(10);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Popped Value: {0}", stack.Pop());
        }


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
