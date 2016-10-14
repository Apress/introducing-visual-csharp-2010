using System;

class KeyStack<TKey, TVal> {
    TKey[] keysArray = new TKey[5];
    TVal[] valsArray = new TVal[5];
    int currentPos = 0;

    public void Push(TKey newKey, TVal newVal) {
        keysArray[currentPos] = newKey;
        valsArray[currentPos] = newVal;
        currentPos++;
    }

    public Tuple<TKey, TVal> Pop() {
        currentPos -= 1;
        return new Tuple<TKey, TVal>(keysArray[currentPos], valsArray[currentPos]);
    }
}

class Listing_10 {

    static void Main(string[] args) {

        // create a new stack
KeyStack<string, int> stack = new KeyStack<string, int>();

// push in some data
stack.Push("One", 1);
stack.Push("Two", 2);
stack.Push("Three", 3);

// pop data from the stack
for (int i = 0; i < 3; i++) {
    Tuple<string, int> item = stack.Pop();
    Console.WriteLine("Key: {0}, Value: {1}", item.Item1, item.Item2);
}

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
