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
            Console.WriteLine("Part 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            double radius = double.Parse(Console.ReadLine());  //prompt input for radius
            
            Console.WriteLine($"The circumference is {Circumference(radius)}."); //pass radius to Circumference() and output circumference
            Console.WriteLine($"The area is {Area(radius)}."); //pass radius to Area() and output area
        }
    }
}
