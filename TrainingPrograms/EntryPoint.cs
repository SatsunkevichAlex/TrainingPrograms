using System;
using System.Linq;
using System.Collections.Generic;

namespace TrainingPrograms
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string countries = "Belarus, USA, Russia, Canada, Poland, Ukraine, Australia, Spain, Germany";
            Console.WriteLine("Country with longest name is: " + LongestCountryNameFinder(countries));
        }
        /// <summary>
        /// Longest country name finder.
        /// </summary>
        /// <param name="countries"></param>
        /// <returns>Longest country name.</returns>
        static public string LongestCountryNameFinder(string countries)
        {
            string[] countriesArray = countries.Split(new Char[] {' ', ','});
            string longestNameCountry = null;
            List<int> countriesLengths = new List<int>();
            foreach (string country in countriesArray)
            {
                countriesLengths.Add(country.Length);
            }
            foreach (string country in countriesArray)
            {
                if (country.Length == countriesLengths.Max())
                {
                    longestNameCountry = country;
                }
            }
            return longestNameCountry;
        }
    }
}
