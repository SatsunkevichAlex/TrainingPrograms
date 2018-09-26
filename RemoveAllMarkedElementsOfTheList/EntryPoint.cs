//Define a method/function that removes from a given array of integers all the values contained in a second array.

using System.Linq;

namespace RemoveAllMarkedElementsOfTheList
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
        }

        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            return integerList.Where(v => !valuesList.Contains(v)).ToArray();
        }
    }
}