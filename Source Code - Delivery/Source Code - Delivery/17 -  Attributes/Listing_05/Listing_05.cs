using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Calculator {

    [Obsolete("Don't use this property")]
    public int MyProperty {
        get;
        set;
    }
    
    public int CalculateProduct(int x, int y) {
        return x + y;
    }
}

class AttributeTester<T> where T : Attribute {

    public bool TestForPropertyAttribute(Type classType, string propertyName) {
        PropertyInfo propInfo = classType.GetProperty(propertyName);
        return Attribute.IsDefined(propInfo, typeof(T));
    }

    public T GetPropertyAttribute(Type classType, string propertyName) {
        PropertyInfo propInfo = classType.GetProperty(propertyName);
        return Attribute.GetCustomAttribute(propInfo, typeof(T)) as T;
    }

    public string[] GetModifiedProperties(Type classType) {
        IList<string> resultList = new List<string>();
        PropertyInfo[] props = classType.GetProperties();
        foreach (PropertyInfo pi in props) {
            if (Attribute.IsDefined(pi, typeof(T))) {
                resultList.Add(pi.Name);
            }
        }
        return resultList.ToArray();
    }
}

class Listing_05 {

    static void Main(string[] args) {

        // create an Attribute Tester for the attribute we are interested in
        AttributeTester<ObsoleteAttribute> attrTester = new AttributeTester<ObsoleteAttribute>();

        // check to see if the attribute has been applied to a property
        bool propTest = attrTester.TestForPropertyAttribute(typeof(Calculator), "MyProperty");
        if (propTest) {
            // the attribute is defined - get the instance of the attribute
            ObsoleteAttribute attr = attrTester.GetPropertyAttribute(typeof(Calculator), "MyProperty");
            // write out the properties of the attribute
            Console.WriteLine("Attribute: message: {0}, error: {1}", attr.Message, attr.IsError);
        }

        // get a list of the names of the properties that have been modified
        string[] modifiedFieldNames = attrTester.GetModifiedProperties(typeof(Calculator));
        foreach (string s in modifiedFieldNames) {
            Console.WriteLine("Modified property: {0}", s);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
