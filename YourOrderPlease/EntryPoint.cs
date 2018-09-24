//Your task is to sort a given string. Each word in the String will contain a single number.This number is the position the word should have in the result.
//Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).
//If the input String is empty, return an empty String.The words in the input String will only contain valid consecutive numbers.
//For an input: "is2 Thi1s T4est 3a" the function should return "Thi1s is2 3a T4est"

using System;
using System.Linq;

namespace YourOrderPlease
{
    class Program
    {
        static void Main()
        {
            string words = "Thi1s is2 3a T4est 5lst";
            Console.WriteLine("actual : " + Order(words).Length);
            Console.WriteLine("expected : " + words.Length);
            Console.WriteLine(Order(words));
            words.ToCharArray();
        }

        public static string Order(string words)
        {
            int[] numersOfWords = words.Split(' ').Select(t => t.First(x => Char.IsNumber(x)) - 49).ToArray();
            string[] arrayOfWords = new string[numersOfWords.Length];
            int i = 0;
            foreach (string word in words.Split(' '))
            {
                arrayOfWords[numersOfWords[i]] = word + " ";
                i++;
            }
            words = string.Empty;
            foreach (string str1 in arrayOfWords)
            {
                words += str1;
            }
            return words.Remove(words.Length - 1, 1);
        }
    }
}