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

    public GenericStack<U> FilterStack<U>() where U : T {
        // create a stack using the more derived type
        GenericStack<U> resultStack = new GenericStack<U>();
        // run through the contents of this stack and
        // add those items which are of the derived type
        for (int i = 0; i < currentPos; i++) {
            if (dataArray[i] is U) {
                resultStack.Push((U)dataArray[i]);
            }
        }
        // return the result stack
        return resultStack;
    }

    public int Count {
        get {
            return currentPos;
        }
    }
}

class Listing_16 {

    static void Main(string[] args) {

        // create a stack that will hold any value type
        GenericStack<ValueType> valueStack = new GenericStack<ValueType>();

        // push some values into the stack
        valueStack.Push(10L);
        valueStack.Push(23.34f);
        valueStack.Push(-100);
        valueStack.Push(512);

        // filter the stack so that we only get int values
        GenericStack<int> intStack = valueStack.FilterStack<int>();

        // print out the contents of the filtered stack
        do {
            Console.WriteLine("Filtered value: {0}", intStack.Pop());
        } while (intStack.Count > 0);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
