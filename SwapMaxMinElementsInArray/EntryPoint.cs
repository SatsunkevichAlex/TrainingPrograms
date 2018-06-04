using System;
using System.Linq;

namespace SwapMaxMinElementsInArray
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 40, 5, 6 };
            OutputMassive(mas);
            SwapMaxMinElements(mas);
            OutputMassive(mas);
        }
        /// <summary>
        /// Swap max and min elements in array.
        /// </summary>
        /// <param name="mas"></param>
        /// <returns>Array with swaped max and min value.</returns>
        public static int[] SwapMaxMinElements(int[] mas)
        {
            int indexMin = 0;
            int indexMax = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == mas.Max())
                {
                    indexMax = i;
                }
                if (mas[i] == mas.Min())
                {
                    indexMin = i;
                }
            }

            int tmp = mas[indexMax];
            mas[indexMax] = mas[indexMin];
            mas[indexMin] = tmp;

            return mas;
        }
        /// <summary>
        /// Output massive.
        /// </summary>
        /// <param name="mas"></param>
        public static void OutputMassive(int[] mas)
        {
            for(int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
