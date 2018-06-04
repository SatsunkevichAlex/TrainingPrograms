using System;
using System.Collections.Generic;

namespace UpperRegisterCountries
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string countries = "USA, Belarus, RUSIA, Austria, AUSTRALIA";
            Console.WriteLine("Countries : " + countries);
            Console.Write("Contries in upper register : ");
            foreach (string country in UpperRegisterCountries(countries))
            {
                Console.Write(country + " ");
            }
        }
        /// <summary>
        /// Find countries of upper register in a string of countries.
        /// </summary>
        /// <param name="countries"></param>
        /// <returns>List of countries of upper register.</returns>
        public static List<string> UpperRegisterCountries(string countries)
        {
            List<string> upperRegisterCountries = new List<string>();
            string[] splitedCountries = countries.Split(',', ' ');
            foreach (string country in splitedCountries)
            {
                if (AllCharsUpperRegisterChecker(country))
                {
                    upperRegisterCountries.Add(country);
                }
            }
            return upperRegisterCountries;
        }
        /// <summary>
        /// Check are all chars in country upper register.
        /// </summary>
        /// <param name="country"></param>
        /// <returns>true if it is, and false if it is not.</returns>
        public static bool AllCharsUpperRegisterChecker(string country)
        {
            int count = 0;
            char[] UpperRegisterAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < country.Length; i++)
            {
                for (int j = 0; j < UpperRegisterAlphabet.Length; j++)
                {
                    if (country[i] == UpperRegisterAlphabet[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count == country.Length ? true : false;
        }
    }
}
