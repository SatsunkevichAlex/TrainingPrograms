using System;

namespace Palindrome
{
    /// <summary>
    /// Is a string palindrome checker.
    /// </summary>
    class PalindromeChecker
    {
        /// <summary>
        /// Check is a char sequence palindrome.
        /// </summary>
        /// <param name="word"></param>
        /// <returns>true or false</returns>
        public bool Check(string word)
        {
            int count = 0;
            int j = word.Length - 1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word[j])
                {
                    count++;
                }
                j--;
            }
            if (count == word.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
