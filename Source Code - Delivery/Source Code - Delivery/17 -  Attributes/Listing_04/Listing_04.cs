using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


class Calculator {
    [Obsolete("Don't use this field")]
    public const int MultiplierField = 20;
    public int OtherField;

    public int CalculateProduct(int x, int y) {
        return x + y;
    }
}

class AttributeTester<T> where T : Attribute {

    public bool TestForFieldAttribute(Type classType, string fieldName) {
        FieldInfo fieldInfo = classType.GetField(fieldName);
        return Attribute.IsDefined(fieldInfo, typeof(T));
    }

    public T GetFieldAttribute(Type classType, string fieldName) {
        FieldInfo fieldInfo = classType.GetField(fieldName);
        return Attribute.GetCustomAttribute(fieldInfo, typeof(T)) as T;
    }

    public string[] GetModifiedFields(Type classType) {
        IList<string> resultList = new List<string>();
        FieldInfo[] fields = classType.GetFields();
        foreach (FieldInfo fi in fields) {
            if (Attribute.IsDefined(fi, typeof(T))) {
                resultList.Add(fi.Name);
            }
        }
        return resultList.ToArray();
    }

    public bool TestForFieldAttribute(object obj, string fieldName) {
        return TestForFieldAttribute(obj.GetType(), fieldName);
    }

    public T GetFieldAttribute(object obj, string fieldName) {
        return GetFieldAttribute(obj.GetType(), fieldName);
    }

    public string[] GetModifiedFields(object obj) {
        return GetModifiedFields(obj.GetType());
    }
}

class Listing_04 {

    static void Main(string[] args) {

        // create an Attribute Tester for the attribute we are interested in
        AttributeTester<ObsoleteAttribute> attrTester = new AttributeTester<ObsoleteAttribute>();

        // check to see if the attribute has been applied to a field
        bool fieldTest = attrTester.TestForFieldAttribute(typeof(Calculator), "MultiplierField");
        if (fieldTest) {
            // the attribute is defined - get the instance of the attribute
            ObsoleteAttribute attr = attrTester.GetFieldAttribute(typeof(Calculator), "MultiplierField");
            // write out the properties of the attribute
            Console.WriteLine("Attribute: message: {0}, error: {1}", attr.Message, attr.IsError);
        }

        // get a list of the names of the fields that have been modified
        string[] modifiedFieldNames = attrTester.GetModifiedFields(typeof(Calculator));
        foreach (string s in modifiedFieldNames) {
            Console.WriteLine("Modified field: {0}", s);
        }



        // perform the same test, this time using a calc object

        // create an instance of the Calculator class
        Calculator calc = new Calculator();

        // check to see if the attribute has been applied to a field
        bool fieldTest2 = attrTester.TestForFieldAttribute(typeof(Calculator), "MultiplierField");
        if (fieldTest) {
            // the attribute is defined - get the instance of the attribute
            ObsoleteAttribute attr = attrTester.GetFieldAttribute(typeof(Calculator), "MultiplierField");
            // write out the properties of the attribute
            Console.WriteLine("Attribute: message: {0}, error: {1}", attr.Message, attr.IsError);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }


}
