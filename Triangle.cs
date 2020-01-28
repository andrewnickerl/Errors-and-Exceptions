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
            return Math.Sqrt(half_perimeter * (half_perimeter - side1) * (half_perimeter - side2) * (half_perimeter - side3));  //calculate and return area
        }
        public void Show()
        {
            double side1 = 0, side2 = 0, side3 = 0;
            Console.WriteLine("Part 3, area of a triangle (Heron's formula).");
            Console.Write("Enter a length for the first side: ");
            try
            {
                side1 = double.Parse(Console.ReadLine());  //input first side
                if (side1 <= 0)
                {
                    throw new Exception();
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Show();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input.  Please enter a positive number.");
                Show();
                return;
            }
            
            Console.Write("Enter a length for the second side: ");
            try
            {
                side2 = double.Parse(Console.ReadLine());  //input second side
                if (side2 <= 0)
                {
                    throw new Exception();
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Show();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input.  Please enter a positive number.");
                Show();
                return;
            }
          
            Console.Write("Enter a length for the third side: ");
            try
            {
                side3 = double.Parse(Console.ReadLine());  //input third side
                if (side3 <= 0)
                {
                    throw new Exception();
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Show();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input.  Please enter a positive number.");
                Show();
                return;
            }
          

            Console.WriteLine($"The area is {Area(side1, side2, side3)}."); 
        }
    }
}
