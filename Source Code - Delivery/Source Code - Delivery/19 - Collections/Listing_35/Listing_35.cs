using System;
using System.Collections.Generic;

namespace Listing_35 {
    class Listing_35 {

        static void Main(string[] args) {

            // create a regular dictionary
            Dictionary<string, string> dict = new Dictionary<string, string>() {
                {"apple", "green"}, {"orange", "orange"}, {"cherry", "red"}};

            // create the read-only wrapper
            ReadOnlyDictionary<string, string> readOnlyDict = new ReadOnlyDictionary<string,string>(dict);

            // enumerate the keys
            foreach (string s in readOnlyDict.Keys) {
                Console.WriteLine("Key: {0}", s);
            }

            // try to add an item to the read-only collection
            try {
                readOnlyDict.Add("pear", "green");
            } catch (Exception ex) {
                Console.WriteLine("Exception: {0}", ex.GetType());
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }

    class ReadOnlyDictionary<TKey, TVal> : IDictionary<TKey, TVal> {
        IDictionary<TKey, TVal> readwriteDict;


        public ReadOnlyDictionary(IDictionary<TKey, TVal> rwdict) {
            readwriteDict = rwdict;
        }
        
        public void Add(TKey key, TVal value) {
            throw new NotSupportedException();
        }

        public bool ContainsKey(TKey key) {
            return readwriteDict.ContainsKey(key);
        }

        public ICollection<TKey> Keys {
            get { return readwriteDict.Keys; }
        }

        public bool Remove(TKey key) {
            throw new NotSupportedException();
        }

        public bool TryGetValue(TKey key, out TVal value) {
            return readwriteDict.TryGetValue(key, out value);
        }

        public ICollection<TVal> Values {
            get { return readwriteDict.Values; }
        }

        public TVal this[TKey key] {
            get {
                return readwriteDict[key];
            }
            set {
                throw new NotSupportedException();
            }
        }

        public void Add(KeyValuePair<TKey, TVal> item) {
            throw new NotSupportedException();
        }

        public void Clear() {
            throw new NotSupportedException();
        }

        public bool Contains(KeyValuePair<TKey, TVal> item) {
            return readwriteDict.Contains(item);
        }

        public void CopyTo(KeyValuePair<TKey, TVal>[] array, int arrayIndex) {
            throw new NotSupportedException();
        }

        public int Count {
            get { return readwriteDict.Count; }
        }

        public bool IsReadOnly {
            get { return true; }
        }

        public bool Remove(KeyValuePair<TKey, TVal> item) {
            throw new NotSupportedException();
        }

        public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator() {
            return readwriteDict.GetEnumerator() ;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return readwriteDict.GetEnumerator();
        }
    }
}
