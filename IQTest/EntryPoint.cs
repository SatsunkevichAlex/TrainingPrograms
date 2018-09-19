//Bob is preparing to pass IQ test.
//The most frequent task in this test is to find out which one of the given numbers differs from the others. 
//Bob observed that one number usually differs from the others in evenness.
//Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, 
//and return a position of this number.

//! Keep in mind that your task is to help Bob solve a real IQ test, 
//which means indexes of the elements start from 1 (not 0)

//Examples :
//IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even
//IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd

using System;
using System.Linq;

namespace IQTest
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string numbers = "1 2 2";

            Console.WriteLine(IQTestHelper(numbers));
        }

        public static string[] SplitSequence(string sequenceForDeletingSpaces) => sequenceForDeletingSpaces.Split(' ');

        public static bool IsAllNumbersEvenExceptOne(string[] sequenceForCheck)
        {
            var evenNumbers = sequenceForCheck.Where(number => Convert.ToInt16(number) % 2 == 0).ToList();
            var notEvenNumbers = sequenceForCheck.Where(number => Convert.ToInt16(number) % 2 != 0).ToList();

            return evenNumbers.Count > notEvenNumbers.Count ? true : false;
        }

        public static int IQTestHelper(string numbers)
        {
            string[] splitedSequence = SplitSequence(numbers);

            if (IsAllNumbersEvenExceptOne(splitedSequence))
            {
                for (int i = 0; i < splitedSequence.Length; i++)
                {
                    if (Convert.ToInt16(splitedSequence[i]) % 2 != 0)
                        return i + 1;
                }
            }

            if (!IsAllNumbersEvenExceptOne(splitedSequence))
            {
                for (int i = 0; i < splitedSequence.Length; i++)
                {
                    if (Convert.ToInt16(splitedSequence[i]) % 2 == 0)
                        return i + 1;
                }
            }

            return 0;
        }
    }
}
