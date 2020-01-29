using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_and_Exceptions
{
    public class Triangle
    {
        private double Area(double side1, double side2, double side3)
        {
            double half_perimeter = (side1 + side2 + side3) / 2;
            return checked(Math.Sqrt(half_perimeter * (half_perimeter - side1) * (half_perimeter - side2) * (half_perimeter - side3)));  //calculate and return area
        }
        public void Show()
        {
            double side1, side2, side3;
            Console.WriteLine("\nTRIANGLE AREA (HERON'S FORMULA) CALCULATOR");
            Console.Write("Enter a length for the first side: ");

            side1 = double.Parse(Console.ReadLine());  //input first side
            if (side1 <= 0)
            {
                throw new ArithmeticException();
            }
            
            
            Console.Write("Enter a length for the second side: ");
            side2 = double.Parse(Console.ReadLine());  //input second side
            if (side2 <= 0)
            {
                throw new ArithmeticException();
            }
          
            Console.Write("Enter a length for the third side: ");
            side3 = double.Parse(Console.ReadLine());  //input third side
            if (side3 <= 0)
            {
                throw new ArithmeticException();
            }          

            Console.WriteLine($"The area is {Area(side1, side2, side3)}."); //pass sides to Area() and print the area
        }
    }
}
