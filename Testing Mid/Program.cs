using System;
using static System.Console;

class EnterNum
{
    static void Main()
    {
        int count = 0;
        int Numbers = 0;

        while (count < 5)
        {
            Write($"Please enter a number {count+1}: ");
            int num = Convert.ToInt32(ReadLine());

            if (num > 0)
            {
                Numbers += num;
                ++count;
            }
            else 
            {
                WriteLine("Wronge Number ");
            }  
        }


        WriteLine($"Your Numbers add is = {Numbers}");
        ReadKey();
    }


}