using System;
using static System.Console;

namespace StudentPortalApp
{
    class Program
    {
        static void Main()
{
    WriteLine("Enter your name:");
    string name = ReadLine();

    WriteLine("Enter your major:");
    string major = ReadLine();

    WriteLine("Enter your student ID:");
    string studentID = ReadLine();


    WriteLine("Enter your first GPA:");
    double gpa1 = Convert.ToDouble(ReadLine());

    WriteLine("Enter your second GPA:");
    double gpa2 = Convert.ToDouble(ReadLine());
  
    double averageGPA = (gpa1 + gpa2) / 2;
    

    WriteLine("\n Student Information: ");
    WriteLine($"Name: {name}");
    WriteLine($"Major: {major}");
    WriteLine($"Student ID: {studentID}");
    WriteLine($"Average GPA: {averageGPA}");
    
}
    }
}