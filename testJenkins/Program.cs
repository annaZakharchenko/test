﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = int.Parse(Console.ReadLine());

        int sum = number1 - number2;

        Console.WriteLine($"The sum is: {sum}");
    }
}