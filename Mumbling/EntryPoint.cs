using System;
using System.Text;

namespace Mumbling
{
    class EntyPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accum(""));
        }

        public static string Accum(string sequance)
        {
            StringBuilder resultSequance = new StringBuilder("");

            for (int i = 0; i < sequance.Length; i++)
            {
                resultSequance.Append(sequance[i].ToString().ToUpper());

                for (int j = 1; j <= i; j++)
                {
                    resultSequance.Append(sequance[i]);
                }

                resultSequance.Append("-");
            }

            return RemoveLastCharacterInString(resultSequance.ToString());
        }

        public static string RemoveLastCharacterInString(string word) => word.ToString().Remove(word.Length - 1);
    }
}
