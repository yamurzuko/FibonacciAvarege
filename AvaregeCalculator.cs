using System;

namespace FibonacciAvarege
{
    public class AvaregeCalculator
    {
        public int[] FibonacciMember(int value)
        {
            int[] fibonacciArray = new int[value];
            fibonacciArray[0] = 1;
            fibonacciArray[1] = 1;

            for (int i = 2; i < value; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
            }
            return fibonacciArray;
        }
    }
}