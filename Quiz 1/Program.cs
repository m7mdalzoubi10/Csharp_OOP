using System;
using static System.Console;

class Mobile
{
    public string Brand;
    public string Model;
    public double Price;

    public Mobile(string Brand, string Model, double Price)
    {
        this.Brand = Brand;
        this.Model = Model;
        this.Price = Price;
    }

    public virtual void DisplayInfo()
    {
        WriteLine($"Brand :{Brand}");
        WriteLine($"Model :{Model}");
        WriteLine($"Price : {Price}");
        WriteLine(" ----------\n");
    }

    public double UpdatePrice()
    {
        Price = Price - 15;

        return Price;
    }

}

class Project
{
    static void Main()
    {
        Mobile M1 = new Mobile("Samsung", "Galaxy S20", 300);
        Mobile M2 = new Mobile("Apple", "iPhone 12", 450);

        M1.UpdatePrice();
        M2.UpdatePrice();

        M1.DisplayInfo();
        M2.DisplayInfo();

        ReadKey();
    }
}