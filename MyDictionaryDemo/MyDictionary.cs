using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary <KeyT, ValueT>
    {
        KeyT[] keys;
        ValueT[] values;
        public MyDictionary()
        {
            keys = new KeyT[0];
            values = new ValueT[0];
        }
        public void Add(KeyT key, ValueT value)
        {
            // Temps
            KeyT[] tempKeys = keys;
            ValueT[] tempValues = values;
            // New Arrays
            keys = new KeyT[keys.Length+1];
            values = new ValueT[values.Length + 1];
            // Updated Arrays
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Length
        {
            get { return keys.Length; }
        }
        public KeyT[] Keys
        {
            get { return keys; }
        }
        public ValueT[] Values
        {
            get { return values; }
        }
    }
}
