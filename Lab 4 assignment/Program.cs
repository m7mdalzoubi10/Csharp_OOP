using System;
using static System.Console;

    class Student
    {
        private string name;
        private double id;
        private double gpa;

        public string name_proparety
        {
            get { return name; }
            set { name = value; }
        }

        public double id_proparety
        {
            get { return id; }
            set { id = value; }
        }

        public double gpa_proparety
        {
            get { return gpa; }
            set
            {
                if (value >= 0 && value <= 4)
                {
                    gpa = value;
                }
                else
                {
                    gpa = 0;
                }
            }
        }

 
        public void DisplayRecord()
        {
            WriteLine($"Name: {name_proparety}, ID: {id_proparety}, GPA: {gpa_proparety}");
        }
    }

    class Program
    {
        static void Main()
        {

              Student student1 = new Student();
        student1.name_proparety = "Alice Johnson";
        student1.id_proparety = 2020;
        student1.gpa_proparety = 3;
            WriteLine("Valid Student:");
            student1.DisplayRecord();


            Student student2 = new Student();
        student2.name_proparety = "Bob Smith";
        student2.id_proparety = 2025;
        student2.gpa_proparety = 6;
            WriteLine("\n Invalid Student:");
            student2.DisplayRecord();

            ReadLine();
        }
    }