//Mr.Scrooge has a sum of money 'P' that wants to invest, and he wants to know how many years 'Y' this sum has to be kept in the bank in order for this sum of money to amount to 'D'.
//The sum is kept for 'Y' years in the bank where interest 'I' is paid yearly, and the new sum is re-invested yearly after paying tax 'T'
//Note that the principal is not taxed but only the year's accrued interest

using System;

namespace MoneyMoneyMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateYears(1000.00, 0.05, 0.18, 1100.00));
        }

        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;
            double resultSum = 0;
            double income;
            double incomeWithTax;

            while (desiredPrincipal > principal)
            {
                resultSum = principal + principal * interest;
                income = resultSum - principal;
                incomeWithTax = income - income * tax;
                principal += incomeWithTax;
                resultSum = principal;
                years++;
            }

            return years;
        }
    }
}
