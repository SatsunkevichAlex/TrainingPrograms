using System;
using System.Text;

namespace Mumbling
{
    class EntyPoint
    {
        static void Main(string[] args)
        {
            //char y = 'b';
            //int x = (int)y;
            //Console.WriteLine(x);

            Console.WriteLine(Accum("123"));
        }

        public static string Accum(string sequance)
        {
            StringBuilder resultSequance = new StringBuilder("");

            for (int i = 0; i < sequance.Length; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    resultSequance.Append(sequance[i]);
                }

                resultSequance.Append("-");
            }

            return resultSequance.R.ToString();
        }
    }
}
