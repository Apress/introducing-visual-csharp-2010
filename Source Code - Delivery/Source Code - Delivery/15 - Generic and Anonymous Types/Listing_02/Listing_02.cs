using System;

class ObjectStack {
    object[] dataArray = new object[10];
    int currentPos = 0;

    public void Push(object value) {
        dataArray[currentPos++] = value;
    }

    public object Pop() {
        return dataArray[--currentPos];
    }
}


class Listing_02 {

    static void Main(string[] args) {

        // create a new IntStack
        ObjectStack stack = new ObjectStack();

        stack.Push(2);
        stack.Push("apple");
        stack.Push(8);

        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Pop value: {0}", stack.Pop());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
