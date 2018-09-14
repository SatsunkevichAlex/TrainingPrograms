//Welcome.In this kata, you are asked to square every digit of a number.
//For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
//Note: The function accepts an integer and returns an integer

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(SquareDigits(292));
    }

    public static int SquareDigits(int n)
    {
        int result = 0;
        for (int i = 1; n != 0; i *= 10)
        {
            int x = n % 10;
            result += x * x * i;
            if (x * x >= 10)
                i *= 10;
            n /= 10;
        }
        return result; 
    }
}