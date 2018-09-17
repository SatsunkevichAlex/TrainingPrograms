//Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 integers. No floats or empty arrays will be passed.
//For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
//[10, 343445353, 3453445, 3453545353453] should return 3453455.

using System;
using System.Linq;

namespace SumOfTwoLowestPositiveIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 2, 3, 5 };
        }

        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            if (numbers.Length < 4
            || numbers == null)
            {
                throw new Exception("Invalid input");
            }

            return 0;
        }
    }
}
