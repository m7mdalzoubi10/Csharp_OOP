using System;
using static System.Console;

    class Staff
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public double BaseSalary { get; set; }

        public Staff(string name, string department, double baseSalary)
        {
            Name = name;
            Department = department;
            BaseSalary = baseSalary;
        }

        public virtual double CalculateSalary() => BaseSalary;
        public void DisplayInfo() => WriteLine($"Name: {Name}, Department: {Department}, Total Salary: ${CalculateSalary()}");
    }

    class Lecturer : Staff
    {
        public Lecturer(string name, string department, double baseSalary) : base(name, department, baseSalary) { }
        public double CalculateSalary() => BaseSalary + (BaseSalary * 0.2);
    }

    class Administrator : Staff
    {
        public Administrator(string name, string department, double baseSalary) : base(name, department, baseSalary) { }
        public double CalculateSalary() => BaseSalary + 300;
    }

    class Program
    {
        static void Main()
        {
            Lecturer l1 = new Lecturer("Dr. Alice", "CS", 50000);
            Lecturer l2 = new Lecturer("Prof. Bob", "Math", 55000);
            Administrator a1 = new Administrator("John", "Admin", 40000);
            Administrator a2 = new Administrator("Jane", "HR", 42000);

            WriteLine("Academic Staff :  ");
            l1.DisplayInfo();
            l2.DisplayInfo();
            a1.DisplayInfo();
            a2.DisplayInfo();
            ReadLine();
        }
    }