using System;
using System.Collections.Generic;

namespace DictionaryHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionaries = new MyDictionary<int, string>();
            dictionaries.Add(16, "Tolga");
            dictionaries.Add(16, "Eda");
            dictionaries.Add(67, "Cengiz");
            dictionaries.Add(06, "Alpay");

            dictionaries.Print();
            

        }
    }
}
