using System;
using System.Linq;

namespace YourOrderPlease
{
    class Program
    {
        static void Main()
        {
            string str = "Te4st 3a Thi1s is2 5made b7y Ant5on";
            Console.WriteLine(Order(str));
        }

        public static string Order(string str)
        {
            int[] numr = str.Split(' ').Select(t => (int)(t.First(x => Char.IsNumber(x))) - 49).ToArray();
            string[] arr = new string[numr.Length];
            int i = 0;
            foreach (string str1 in str.Split(' '))
            {
                arr[numr[i]] = str1 + " ";
                i++;
            }
            arr.Take(arr.Length - 1);
            str = string.Empty;
            foreach (string str1 in arr)
            {
                str += str1;
            }
            return str;
        }
    }
}