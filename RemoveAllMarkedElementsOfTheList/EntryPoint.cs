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