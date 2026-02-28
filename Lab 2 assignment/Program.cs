using System;
using static System.Console;  

namespace ArithmeticSummary
{
    class Program
    {
        static void Main()
        {
           
            WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(ReadLine());

            WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(ReadLine());

           WriteLine("\n Arithmetic Operations: ");
            WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
            WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
            WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");

        }
    }
}
