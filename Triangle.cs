using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_and_Exceptions
{
    class Triangle
    {
        private double Area(double side1, double side2, double side3)
        {
            double half_perimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(half_perimeter * (half_perimeter - side1) * (half_perimeter - side2) * (half_perimeter - side3));  //calculate and return area
        }
        public void Show()
        {
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.Write("Enter a length for the first side: "); 
            double side1 = double.Parse(Console.ReadLine());  //input first side
            Console.Write("Enter a length for the second side: ");
            double side2 = double.Parse(Console.ReadLine());  //input second side
            Console.Write("Enter a length for the third side: ");
            double side3 = double.Parse(Console.ReadLine());  //input third side

            Console.WriteLine($"The area is {Area(side1, side2, side3)}."); 
        }
    }
}
