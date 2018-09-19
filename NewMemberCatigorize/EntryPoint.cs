//The Western Suburbs Croquet Club has two categories of membership, Senior and Open.They would like your help with an application form that will tell prospective members which category they will be placed.
//To be a senior, a member must be at least 55 years old and have a handicap greater than 7. In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
//Input
//Input will consist of a list of lists containing two items each. Each list contains information for a single potential member. Information consists of an integer for the person's age and an integer for the person's handicap.

using System;
using System.Collections.Generic;

namespace NewMemberCatigorize
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            foreach (string memberCatigory in OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }))
            {
                Console.WriteLine(memberCatigory);
            }
            
        }

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> memberships = new List<string>();

            foreach (int[] guestData in data)
            {
                if (guestData[0] >= 55 && guestData[1] > 7)
                    memberships.Add("Senior");
                else
                    memberships.Add("Open");
            }

            return memberships; 
        }
    }
}
