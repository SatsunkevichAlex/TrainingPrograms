using System;

namespace ReverseSequence
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string word = "sasha";
            OutputSequence(word.ToCharArray());
            OutputSequence(ReverseSequence(word));
        }
        /// <summary>
        /// Reverse sequance.
        /// </summary>
        /// <param name="sequance"></param>
        /// <returns>Reversed sequance.</returns>
        public static char[] ReverseSequence(string sequance)
        {
            int indexLastChar = sequance.Length - 1;
            char[] reversedWord = new char[sequance.Length];
            for (int i = 0; i < sequance.Length; i++)
            {
                reversedWord[i] = sequance.ToCharArray()[indexLastChar];
                indexLastChar--;
            }
            return reversedWord;
        }
        /// <summary>
        /// Output sequance.
        /// </summary>
        /// <param name="reversedWord"></param>
        public static void OutputSequence(char[] reversedWord)
        {
            for (int i = 0; i < reversedWord.Length; i++)
            {
                Console.Write(reversedWord[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
