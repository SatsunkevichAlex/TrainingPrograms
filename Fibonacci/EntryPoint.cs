using System;

namespace Fibonacci
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int n = 30;
            OutputFibonacciSequence(n);
        }
        /// <summary>
        /// Calculation of n Fibonacci sequence number.
        /// </summary>
        /// <param name="number of sequence"></param>
        /// <returns>value of n Fibonacci sequence</returns>
        public static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        /// <summary>
        /// Output Fibonacci sequence.
        /// </summary>
        /// <param name="length of seqence"></param>
        public static void OutputFibonacciSequence(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine();
        }
    }
}
