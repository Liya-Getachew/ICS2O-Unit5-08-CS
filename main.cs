// Created by: liya getachew
// Created on: Dec 7 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the quotient using subtraction
        int num1;
        int num2;
        int counter = 0;

        Console.WriteLine("Insert the dividend and divisor here:");
        Console.WriteLine();

        Console.WriteLine("dividend: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("divisor: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int remainder = num1;

        if (num1 > 0 && num2 > 0)
        {
            while (remainder + 1 > num2) 
            {
                remainder = remainder - num2;
                counter++;
            }
            Console.WriteLine(num1 + " ÷ " + num2 + " = " + counter + " R " + remainder);
        }
        else
        {
          Console.WriteLine("Please enter POSITIVE numbers, thank you!");
        }
       
        Console.WriteLine("\nDone.");
    }
}