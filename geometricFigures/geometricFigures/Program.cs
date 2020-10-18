using Figures;
using System;

namespace geometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagingFigures a = new ManagingFigures();

            a.CreateFigures();
            a.CalculationArea();
            Console.WriteLine(" ");
            a.CalculationPerimeter();
            Console.WriteLine(" ");
            a.SearchMaxArea();
            Console.WriteLine(" ");
            a.SearchMaxPerimeter();

            Console.ReadKey();
            
        }
    }
}
