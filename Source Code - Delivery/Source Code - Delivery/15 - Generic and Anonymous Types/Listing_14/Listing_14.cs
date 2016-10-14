using System;

class KeyStack<TKey, TVal> where TKey : class, IComparable<TKey> where TVal :struct {
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

class Listing_14 {

    static void Main(string[] args) {




        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
