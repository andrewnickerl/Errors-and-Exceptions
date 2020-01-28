using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_and_Exceptions
{
    class Circle
    {
        private double Circumference(double radius)
        {
            return 2 * Math.PI * radius; //calculate and return circumference
        }
        private double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2); //calculate and return area
        }
        public void Show()
        {
            double radius = 0;
            Console.WriteLine("Part 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            try
            {
                radius = double.Parse(Console.ReadLine());  //prompt input for radius
                if (radius <= 0)
                {
                    throw new Exception();
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input.  Please enter a positive number.");
                Show();
            }
            
            Console.WriteLine($"The circumference is {Circumference(radius)}."); //pass radius to Circumference() and output circumference
            Console.WriteLine($"The area is {Area(radius)}."); //pass radius to Area() and output area
        }
    }
}
