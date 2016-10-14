using System;

class GenericStack<T> {
    protected T[] dataArray = new T[10];
    protected int currentPos = 0;

    public void Push(T value) {
        dataArray[currentPos++] = value;
    }

    public T Pop() {
        return dataArray[--currentPos];
    }
}

class IntStack : GenericStack<int> {

    public bool Contains(int value) {
        for (int i = 0; i < currentPos; i++) {
            if (value == dataArray[i]) {
                return true;
            }
        }
        return false;
    }
}

class Listing_20_Test {

    static void Main(string[] args) {

        // create an instance from the derived type
        IntStack intStack = new IntStack();

        // upcast to the base type
        GenericStack<int> gStack = intStack;

        // push some data into the stack
        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);

        // pop the data back out of the stack
        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Popped Value: {0}", intStack.Pop());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
