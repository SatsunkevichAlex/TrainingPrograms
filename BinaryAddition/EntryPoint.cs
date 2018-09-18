//Implement a function that adds two numbers together and returns their sum in binary.The conversion can be done before, or after the addition.
//The binary number returned should be a string.

using System;

namespace BinaryAddition
{
    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine(BinaryAddition(1, 2));
        }

        private static string BinaryAddition(int a, int b)
        {
            return Convert.ToString(a + b);
        }
    }
}
