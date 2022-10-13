﻿using System;

namespace FibonacciAvarege
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            AvaregeCalculator calculate = new AvaregeCalculator();
            int[] arr = new int[number];
            arr = calculate.FibonacciMember(number);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Ortalama : {0} ", Math.Floor(arr.Average()));
        }
    }
}