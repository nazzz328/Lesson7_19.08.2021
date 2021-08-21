using System;

namespace Console7
{

    class Program
    {
        static void Main(string[] args)
        {

        // Task 1

           System.Console.WriteLine("Enter side 1:");
           double.TryParse(Console.ReadLine(), out double side1);
           System.Console.WriteLine("Enter side 2:");
           double.TryParse(Console.ReadLine(), out double side2);
           Rectangle rec = new Rectangle (side1, side2);

           rec.AreaCalculator();
           rec.PerimeterCalculator();

        // Task 2

            System.Console.WriteLine("Enter Title:");
            string title = Console.ReadLine();
            System.Console.WriteLine("Enter Author:");
            string author = Console.ReadLine();
            System.Console.WriteLine("Enter Content:");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);
            book.ShowTitle();
            book.ShowAuthor();
            book.ShowContent();


    
           
        }

    }

    class Rectangle

    {
        private double side1, side2;
        public double Area 
        {
         get
         {return Area;}
        }

        public double Perimeter 
        {
         get
         {return Perimeter;}
        }

        public Rectangle (double side1, double side2)
        {
        this.side1 = side1;
        this.side2 = side2;
        }

        public double AreaCalculator()
        {
        double Area = side1 * side2;
        System.Console.WriteLine($"Area = {Area}");
        return Area;
        }

        public double PerimeterCalculator()
        {
        double Perimeter = 2*(side1 + side2);
        System.Console.WriteLine($"Perimeter = {Perimeter}");
        return Perimeter;
        }

    }


    class Book 
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content(); 

        public Book (string title, string author, string content)
        {
        this.title.title = title;
        this.author.author = author;
        this.content.content = content;
        }

        public void ShowTitle()
        {
        title.Show();
        }

        public void ShowAuthor()
        {
        author.Show();
        }

        public void ShowContent()
        {
        content.Show();
        }
    }

    class Title
    {
        public string title;
        public void Show()
        {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.Write($"{title}, ");
        Console.ResetColor();
        }

    }

    class Author
    {
        public string author;
        public void Show()
        {
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.Write($"{author}, ");
        Console.ResetColor();
        }
    
    }

    class Content

    {
        public string content;
        public void Show()
        {
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.Write($"{content}.");
        Console.ResetColor();
        }

    }
}
