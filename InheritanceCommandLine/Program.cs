using System;

namespace InheritanceCommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.a = 5;
            rectangle.b = 10;

            Square square = new Square();
            square.a = 5;
            square.b = 10;

            rectangle.Obsah();
            square.Obsah();
        }
    }
}
