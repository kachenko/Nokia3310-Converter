using System;
using System.Collections.Generic;
using System.Linq;

namespace Nokia3310Converter
{
    static class Code
    {
        private static Dictionary<string, string> dictionary = new Dictionary<string, string>() {
            { "A", "2" },
            { "B", "22" },
            { "C", "222" },
            { "D", "3" },
            { "E", "33" },
            { "F", "333" },
            { "G", "4" },
            { "H", "44" },
            { "I", "444" },
            { "J", "5" },
            { "K", "55" },
            { "L", "555" },
            { "M", "6" },
            { "N", "66" },
            { "O", "666" },
            { "P", "7" },
            { "Q", "77" },
            { "R", "777" },
            { "S", "7777" },
            { "T", "8" },
            { "U", "88" },
            { "V", "888" },
            { "W", "9" },
            { "X", "99" },
            { "Y", "999" },
            { "Z", "9999" }
        };

        public static string encode(string str)
        {
            string result = "";
            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string letter = str.Substring(i, 1);
                    result += dictionary[letter];
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string word = "KOT";
            
            Console.WriteLine("RESULT: " + Code.encode(word));
        }
    }
}
