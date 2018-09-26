//Given a string str, reverse it omitting all non-alphabetic characters.

using System;
using System.Linq;

namespace ReverseSequenceWithTrim
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseLetter("qwert123"));
        }

        public static string ReverseLetter(string str)
        {
            const string Alphabet = "QqWwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm";
            var sortedStr = str.Where(c => Alphabet.Contains(c));
            string result = "";
            
            foreach(char c in sortedStr.Reverse())
            {
                result += c;
            }

            return result;
        }
    }
}
