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

    public U PopAndConvert<U>() where U : T {
        // create the result that we will return
        U result = default(U);

        // pop the value
        T popped = Pop();
        if (popped is U) {
            result = (U)popped;
        }

        // return the result 
        return result;
    }
}

class Listing_28 {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
