using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Calculator {

    [Obsolete("Don't use this method")]
    public int CalculateProduct(int x, int y) {
        return x + y;
    }

    public int CalculateProduct(params int[] values) {
        int result = 0;
        foreach (int i in values) {
            result += i;
        }
        return result;
    }
}

struct MethodAttributePair<T> {
    public string MethodSignature;
    public T Attribute;
}

class AttributeTester<T> where T : Attribute {

    public bool TestForMethodAttribute(Type classType, string methodName) {
        MethodInfo[] methods = classType.GetMethods();
        foreach (MethodInfo mi in methods) {
            if (mi.Name == methodName && Attribute.IsDefined(mi, typeof(T))) {
                return true;
            }
        }
        return false;
    }

    public string[] GetModifiedMethodNames(Type classType) {
        IList<string> resultList = new List<string>();
        MethodInfo[] methods = classType.GetMethods();
        foreach (MethodInfo mi in methods) {
            if (Attribute.IsDefined(mi, typeof(T))) {
                resultList.Add(mi.ToString());
            }
        }
        return resultList.ToArray();
    }

    public MethodAttributePair<T>[] GetModifiedMethods(Type classType) {
        IList<MethodAttributePair<T>> resultList = new List<MethodAttributePair<T>>();
        MethodInfo[] methods = classType.GetMethods();
        foreach (MethodInfo mi in methods) {
            T attr = Attribute.GetCustomAttribute(mi, typeof(T)) as T;
            if (attr != null) {
                resultList.Add(new MethodAttributePair<T>() { Attribute = attr, 
                    MethodSignature = mi.ToString() });
            }
        }
        return resultList.ToArray();
    }
}

class Listing_06 {

    static void Main(string[] args) {

        // create an Attribute Tester for the attribute we are interested in
        AttributeTester<ObsoleteAttribute> attrTester = new AttributeTester<ObsoleteAttribute>();

        // check to see if the attribute has been applied to a property
        bool methodTest = attrTester.TestForMethodAttribute(typeof(Calculator), "CalculateProduct");
        Console.WriteLine("At least one overloaded method has attribute: {0}", methodTest);

        // get a list of the names of the properties that have been modified
        string[] modifiedMethods = attrTester.GetModifiedMethodNames(typeof(Calculator));
        foreach (string s in modifiedMethods) {
            Console.WriteLine("Modified method: {0}", s);
        }

        // get a series of structs representing modified methods and their attributes
        MethodAttributePair<ObsoleteAttribute>[] mods = attrTester.GetModifiedMethods(typeof(Calculator));
        foreach (MethodAttributePair<ObsoleteAttribute> mp in mods) {
            Console.WriteLine("--- Method with Obsolete Attribute ---");
            Console.WriteLine("Method signature: {0}", mp.MethodSignature);
            Console.WriteLine("Attribute message: {0}", mp.Attribute.Message);
            Console.WriteLine("Attribute error: {0}", mp.Attribute.IsError);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
