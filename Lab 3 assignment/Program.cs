using System;
using static System.Console;

namespace CarInventory
{
    class Car
    {
        
        public string Brand;
        public string Model;
        public int Year;
        public double Price;

       
        public Car(string brand, string model, int year, double price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price; 
        }

       
        public void DisplayCarInfo()
        {
            WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Price: {Price}");
        }
    }

    class Program
    {
        static void Main()
        {
           Car car1 = new Car("Toyota", "Camry", 2020, 25000);
            Car car2 = new Car("Honda", "Civic", 2019, 22000);

            WriteLine("Car Inventory :   ");
            car1.DisplayCarInfo();
            car2.DisplayCarInfo();

        }
    }
}
