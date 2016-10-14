using System;

class GenericStack<T> {
    T[] dataArray = new T[10];
    int currentPos = 0;

    public void Push(T value) {
        dataArray[currentPos++] = value;
    }

    public virtual T Pop() {
        return dataArray[--currentPos];
    }
}

class EventStack<T> : GenericStack<T> where T : struct {
    public event EventHandler<EventArgs> PoppedEvent;

    public override T Pop() {
        // invoke the event
        PoppedEvent(this, EventArgs.Empty);
        // call the base implementation of the method
        return base.Pop();
    }
}

class Listing_18_Test {

    static void Main(string[] args) {

        // create an instance from the derived type
        EventStack<int> eStack = new EventStack<int>();

        // use a lambda expression to register with the event
        eStack.PoppedEvent += (sender, eventArg) => {
            Console.WriteLine("Popped Event Invoked");
        };

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
