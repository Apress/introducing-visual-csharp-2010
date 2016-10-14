using System;

[Obsolete("Don't use this class")]
class Calculator {

    public int CalculateProduct(int x, int y) {
        return x + y;
    }
}

class AttributeTester<T> where T : Attribute {

    public bool TestForClassAttribute(Type classType) {
        return Attribute.IsDefined(classType, typeof(T));
    }

    public T GetClassAttribute(Type classType) {
        return Attribute.GetCustomAttribute(classType, typeof(T)) as T;
    }

    public bool TestForClassAttribute(object obj) {
        return TestForClassAttribute(obj.GetType());
    }

    public T GetClassAttribute(object obj) {
        return GetClassAttribute(obj.GetType());
    }    
}

class Listing_03 {

    static void Main(string[] args) {

        // create an Attribute Tester for the attribute we are interested in
        AttributeTester<ObsoleteAttribute> attrTester = new AttributeTester<ObsoleteAttribute>();

        // check to see if the attribute has been defined using the class name
        bool classTest = attrTester.TestForClassAttribute(typeof(Calculator));
        if (classTest) {
            // the attribute is defined - get the instance of the attribute
            ObsoleteAttribute attr = attrTester.GetClassAttribute(typeof(Calculator));
            // write out the properties of the attribute
            Console.WriteLine("Attribute: message: {0}, error: {1}", attr.Message, attr.IsError);
        }

        // perform the same test, this time using a calc object

        // create an instance of the Calculator class
        Calculator calc = new Calculator();

        // check to see if the attribute has been defined using the class name
        bool classTest2 = attrTester.TestForClassAttribute(calc);
        if (classTest2) {
            // the attribute is defined - get the instance of the attribute
            ObsoleteAttribute attr = attrTester.GetClassAttribute(calc);
            // write out the properties of the attribute
            Console.WriteLine("Attribute: message: {0}, error: {1}", attr.Message, attr.IsError);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }


}
