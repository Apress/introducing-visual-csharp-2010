using System;
using Microsoft.Win32;
using System.Security;

class Listing_09 {

    static void Main(string[] args) {

        // get one of the root registry
        RegistryKey rootKey = Registry.CurrentUser;

        // process the key
        processSubKeys(rootKey, rootKey.GetSubKeyNames(), "Environment");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    private static void processSubKeys(RegistryKey key, string[] subKeyNames, string targetString) {
        // if there are values for this key, then process them
        processValues(key, key.GetValueNames(), targetString);
        // process each of the subkeys
        foreach (string subKeyName in subKeyNames) {
            try {
                // open the subkey
                RegistryKey subKey = key.OpenSubKey(subKeyName);
                // recurse and process this key
                processSubKeys(subKey, subKey.GetSubKeyNames(), targetString);
            } catch (SecurityException) {
                // this is just part of the registry we are not entitled to read
                Console.WriteLine("Cannot open subkey {0} for key {1}",
                    subKeyName, key.Name);
            }
        }
    }

    private static void processValues(RegistryKey key, string[] valueNames, string targetString) {
        foreach (string valName in valueNames) {
            if (valName.Contains(targetString)) {
                // we have a match - print out the value
                Console.WriteLine("Key: {0}, Value Name: {1}, Value: {2}",
                    key.Name, valName, key.GetValue(valName));
            }
        }
    }
}