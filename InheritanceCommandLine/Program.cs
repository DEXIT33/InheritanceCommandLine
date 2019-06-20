using System;

namespace InheritanceCommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);

            Square square = new Square(5);

            rectangle.Obsah();
            square.Obsah();

            Console.WriteLine(rectangle);
            Console.WriteLine(square);

            Console.ReadKey(true);
        }
    }
}
