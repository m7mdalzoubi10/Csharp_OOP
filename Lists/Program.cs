using System;
using static System.Console;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {

        static void Main()
        {

            List<string> Food = new List<string>();  //List<Type> Name = new List<Type>(); Makes a new List Free size not like Array Limited size

            Food.Add("Pizza");
            Food.Add("Burger");
            Food.Add("Fries");
            Food.Add("Brosted");
            Food.Add("Shawarma");
            Food.Add("Zengar");

            Food.Remove("Zengar");  // Removes the item from the List

            //Food.sort();    //It's the same as Reverse
            //Food.Reverse();  // Reverse Up Down
            //Food.Clear();   //Delet the List
            //WriteLine(Food.LastIndexOf(Pizza));  //the number of Last Pizza on the list
            //string[] FoodArray = Food.ToArray(); //if you use it Don't Forget to change the Food name to Food.Array in Foreach loop
            //            using System.Collections.Generic;
            //    the DisAdvantege of the List Method that it takes more Memory then Array

            Food.Insert(0, "Italy");
            WriteLine($"The List is {Food.Count} :");


            foreach (string item in Food)
            {
                Write(Food.IndexOf(item) +1);
                Write("- ");
                Write(item);
                Write("  ");
                WriteLine($" In the menu? {Food.Contains(item)} ");
            }

            ReadKey();
        }
    
    }
}