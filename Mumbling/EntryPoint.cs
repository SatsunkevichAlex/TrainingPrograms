using System;
using System.Text;
using System.Linq;

namespace Mumbling
{
    class EntyPoint
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine(Accum(""));
=======
            Console.WriteLine(Accum("abCdefG"));
>>>>>>> e5b0f42c6e64f6851522876b2a7f4332eec0b785
        }

        public static string Accum(string sequance)
        {
            sequance = sequance.ToLower();

            try
            {
                if (!IsAllCharactersInSequanceLatters(sequance))
                    throw new Exception("Invalid input");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + " !");
            }

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

        //Need this method becouse result string ends with '-' but should not.
        public static string RemoveLastCharacterInString(string word) => word.ToString().Remove(word.Length - 1);

        public static bool IsAllCharactersInSequanceLatters(string sequance)
        {
            const string Alpabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

            return sequance.ToCharArray().All(c => Alpabet.Contains(c));
        }
    }
}
