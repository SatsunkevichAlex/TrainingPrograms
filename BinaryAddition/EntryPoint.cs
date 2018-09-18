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
            //string aInString = Convert.ToString(a, 2);
            //string bInString = Convert.ToString(b, 2);

            //a = Convert.ToInt16(aInString);
            //b = Convert.ToInt16(bInString);

            //int[] array = { a, b };
            //string result = "";
            //for (int i = 0; i < array.Length; i++)
            //{
            //    result += array[i].ToString();
            //}

            return Convert.ToString(a + b, 2);
        }
    }
}
