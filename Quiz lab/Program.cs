using System;

class Book
{
    private string title;
    private double price;

    public string title_proparety
    {
        get { return title; }

        set { title = value; }
    }

    public double price_proparety
    {
        get { return price; }

        set
        {
            if (value > 0) { price = value; }
            else Console.WriteLine("Error: Price must be greater than 0");
        }
    }

    public void DisplayInfo()
    {

        Console.WriteLine("Book: " + title +", Price: " + price);
        Console.WriteLine("*******************************");
    }

}

/*********************************************/
class Quiz
{
    static void Main()
    {
        Book ob1 = new Book();
        ob1.title_proparety = "The Power of Now";
        ob1.price_proparety = 50;

        Book ob2 = new Book();
        ob2.title_proparety = "Think and Grow Rich";
        ob2.price_proparety = 40.5;


        ob1.DisplayInfo();
        ob2.DisplayInfo();
    }
}

