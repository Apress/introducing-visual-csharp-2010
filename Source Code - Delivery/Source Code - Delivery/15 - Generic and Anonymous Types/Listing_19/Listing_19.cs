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

class EventStack<T> : GenericStack<T> {

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
    
}

class Listing_19_Test {

    static void Main(string[] args) {

        // create an instance from the derived type
        EventStack<int> eStack = new EventStack<int>();

        // push some data into the stack
        eStack.Push(1);
        eStack.Push(2);
        eStack.Push(3);

        // pop the data back out of the stack
        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Popped Value: {0}", eStack.Pop());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
