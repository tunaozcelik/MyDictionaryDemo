using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("Hello World", "Merhaba Dünya");

            Console.WriteLine(dictionary.GetKey());
            Console.WriteLine(dictionary.GetValue());
            Console.ReadKey();
        }
    }
    public class MyDictionary<Key, Value>
    {
        Key _key;
        Value _value;
        public void Add(Key key,Value value)
        {
            _key = key;
            _value = value;
        }
        public Key GetKey()
        {
            return _key;
        }
        public Value GetValue()
        {
            return _value;
        }
    }
}
