using System;

namespace Palindrome
{
    class EntyPoint
    {
        static void Main(string[] args)
        {
            string charSequence = "4042"; 
            PalindromeChecker palindromeChecker = new PalindromeChecker();
            palindromeChecker.Check(charSequence);
            Console.WriteLine("Char sequence palindrome? " + palindromeChecker.Check(charSequence));
        }
    }
}
