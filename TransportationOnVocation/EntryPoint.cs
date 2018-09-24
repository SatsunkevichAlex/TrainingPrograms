//After a hard quarter in the office you decide to get some rest on a vacation.So you will book a flight for you and your girlfriend and try to leave all the mess behind you.
//You will need a rental car in order for you to get around in your vacation.The manager of the car rental makes you some good offers.
//Every day you rent the car costs $40. If you rent the car for 7 or more days, you get $50 off your total.Alternatively, if you rent the car for 3 or more days, you get $20 off your total.
//Write a code that gives out the total amount for different days(d).

using System;

namespace TransportationOnVocation
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RentalCarCost(1));
            Console.WriteLine(RentalCarCost(2));
            Console.WriteLine(RentalCarCost(3));
            Console.WriteLine(RentalCarCost(4));
            Console.WriteLine(RentalCarCost(5));
            Console.WriteLine(RentalCarCost(6));
            Console.WriteLine(RentalCarCost(7));
        }

        public static int RentalCarCost(int d)
        {
            int result = d * 40;

            if (d >= 3 && d < 7)
                return result - 20;
            if (d >= 3 && d >= 7)
                return result - 50;

            return result;
        }
    }
}
