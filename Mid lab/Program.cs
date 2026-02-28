using System;
using static System.Console;

class Employee
{
    // Fields
    private string name;
    private double salary;

    // Properties
    public string NameProperty
    {
        get { return name; }
        set { name = value; }
    }

    public double SalaryProperty
    {
        get { return salary; }
        set
        {
            if (value > 0)  { salary = value; }
            else { WriteLine("Error: salary must be greater than 0."); }
        }
    }

    // Constructors
    public Employee()
    {
        name = "Unknown";
        salary = 0;
    }

    public Employee(string name, double salary)
    {
        NameProperty = name;
        SalaryProperty = salary;
    }

    // Method to enter employee data
    public void EmployeeEnter()
    {
        Write("Enter Name: ");
        name = ReadLine();

        Write("Enter Salary: ");
        salary = Convert.ToDouble(ReadLine());
    }

    // Display method
    public virtual void DisplayInfo()
    {
        WriteLine($"Name: {name}");
        WriteLine($"Salary: {salary}");
    }
}

class Manager : Employee
{
    private string department;

    public string DepartmentProperty
    {
        get { return department; }
        set { department = value; }
    }

    // Constructors
    public Manager() : base()
    {
        department = "CS";
    }

    public Manager(string name, double salary, string department) : base(name, salary)
    {
        DepartmentProperty = department;
    }

    // Method to enter manager data
    public void ManagerEnter()
    {
        EmployeeEnter();  // Get employee data first

        Write("Enter Department: ");
        department = ReadLine();
    }

    // Override display method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        WriteLine($"Department: {department}");
    }
}

//----------------------------------------------------------------------//
class Program
{
    static void Main()
    {
        // Create manager objects
        Manager M1 = new Manager();
        Manager M2 = new Manager("Ahmad", 1200, "SE");
        // Create M3 and get input
        Manager M3 = new Manager();

        M3.ManagerEnter();

        WriteLine("------Manager 1------");
        M1.DisplayInfo();

        WriteLine("\n------Manager 2------");
        M2.DisplayInfo();

        WriteLine("\n------Manager 3------");
        M3.DisplayInfo();

        ReadKey();
    }
}