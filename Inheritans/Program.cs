using System;
using static System.Console;

class Car
{
    private string Company;
    private string Model;
    private string Color;
    private int Year;
    

    public Car()
    {
        Company = "Unknown";
        Model = "Unknown";
        Year = 0;
        Color = "Unknown";
    }

    public Car(string Company, string Model, string Color, int Year)
    {
        this.CompanyP = Company;
        this.ModelP = Model;
        this.ColorP = Color;
        this.YearP = Year; // Using property for validation
    }

    public string CompanyP
     {
        get { return Company;}
        set { Company = value;}
     }

    public string ModelP
    { 
        get { return Model;}    
        set { Model = value;}   
    }

    public string ColorP
    { 
        get{ return Color;}
        set { Color = value;}   
    }

    public int YearP    
    { 
        get{ return Year;} 

        set 
        {
            if (value > 2000)
            {
                Year = value;
            }
            else 
            { 
                WriteLine($"The Number is invalid"); 
                Year = 0; 
            }
        } 
    }

    public virtual void DisplayInfo()
    {
        WriteLine($"The Company is : {Company}");
        WriteLine($"The Model  is : {Model}");
        WriteLine($"The Color is : {Color}");
        WriteLine($"The Year is : {Year}");
    }

    public void GetInfoCar()
    {
        Write($"Enter informations of the Company Car : ");
        Company = ReadLine();

        Write($"Model : ");
        Model = ReadLine();

        Write($"Color : ");
        Color = ReadLine();

        Write($"Year : ");

        if (int.TryParse(ReadLine(), out int yearInput))
        {
            YearP = yearInput; // Using property to set with validation
        }
        else
        {
            Write("Invalid year format. Setting to 0.");
            YearP = 0;
        }
    }
}

class Toyota : Car
{
    public Toyota(String Model, String Color, int Year) : base ()
    {
        CompanyP = "Toyota"; // Set company to Toyota
        ModelP = Model;
        ColorP = Color;
        YearP = Year; // Using property for valid ation
    }

    public override void DisplayInfo()
    {
    base.DisplayInfo();
    }

}



class Program
{
    static void Main()
    {
        Car car1 = new Car();
        Car car2 = new Car("Toyota", "Camry", "white", 2020);
        Car car3 = new Car();

        WriteLine("-----Car1 Info-----");
        car1.DisplayInfo();

        WriteLine("\n-----Car2 Info-----");
        car2.DisplayInfo();

        car3.GetInfoCar();
        WriteLine("\n-----Car3 Info-----");
        car3.DisplayInfo();

        Toyota toyota1 = new Toyota("Corolla", "Blue", 2021);
        WriteLine("\n-----Toyota Car-----");
        toyota1.DisplayInfo();

        ReadKey();
    }
    
}