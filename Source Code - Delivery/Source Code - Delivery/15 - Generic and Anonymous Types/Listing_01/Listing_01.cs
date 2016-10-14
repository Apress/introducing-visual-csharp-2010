using System;

class IntStack{
    int[] dataArray = new int[10];
    int currentPos = 0;

    public void Push(int value) {
        dataArray[currentPos++] = value;
    }

    public int Pop() {
        return dataArray[--currentPos];
    }
}


class Listing_01 {

    static void Main(string[] args) {

        // create a new IntStack
        IntStack stack = new IntStack();

        stack.Push(2);
        stack.Push(4);
        stack.Push(8);

        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Pop value: {0}", stack.Pop());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
