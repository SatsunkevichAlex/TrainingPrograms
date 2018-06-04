using System;
using System.Collections.Generic;

namespace UnionMututalCharacters
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int[] mas1 = { 4, 5, 6, 7 };
            int[] mas2 = { 7 };
            foreach(int number in MutualNumbers(mas1, mas2))
            {
                Console.Write(number + " ");
            }
        }
        /// <summary>
        /// Find mutual numbers of two int arrays.
        /// </summary>
        /// <param name="mas1"></param>
        /// <param name="mas2"></param>
        /// <returns>Mutual numbers.</returns>
        public static List<int> MutualNumbers(int[] mas1, int[] mas2)
        {
            List<int> mutualNumbers = new List<int>();
            for (int i = 0; i < LongestMassive(mas1, mas2).Length; i++)
            {
                for (int j = 0; j < ShortestMassive(mas1, mas2).Length; j++)
                {
                    if (LongestMassive(mas1, mas2)[i] == ShortestMassive(mas1, mas2)[j])
                    {
                        mutualNumbers.Add(ShortestMassive(mas1, mas2)[j]);
                        break;
                    }
                }
            }
            return mutualNumbers;
        }
        /// <summary>
        /// Find longest massive of two massives.
        /// </summary>
        /// <param name="mas1"></param>
        /// <param name="mas2"></param>
        /// <returns>Longest massive.</returns>
        public static int[] LongestMassive(int[] mas1, int[] mas2)
        {
            return mas1.Length > mas2.Length ? mas1 : mas2;
        }
        /// <summary>
        /// Find shortest massive of two massives.
        /// </summary>
        /// <param name="mas1"></param>
        /// <param name="mas2"></param>
        /// <returns>Shortest massive.</returns>
        public static int[] ShortestMassive(int[] mas1, int[] mas2)
        {
            return mas1.Length < mas2.Length ? mas1 : mas2;
        }
    }
}
