using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] _keys;
        TValue[] _values;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempkeys = _keys;
            TValue[] tempValues = _values;

            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i <tempkeys.Length; i++)
            {
                _keys[i] = tempkeys[i];
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                _values[i] = tempValues[i];
            }
            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }
        public TKey[] Keys
        {
            get { return _keys; }
        }

        public TValue[] Values
        {
            get { return _values; }
        }

        public void List()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine(_keys[i] + ":" + _values[i]);
            }
        }
    }
}
