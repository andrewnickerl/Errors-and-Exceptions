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
            return checked(2 * Math.PI * radius); //calculate and return circumference
        }
        private double Area(double radius)
        {
            return checked(Math.PI * Math.Pow(radius, 2)); //calculate and return area
        }
        public void Show()
        {
            double radius;
            Console.WriteLine("\nCIRCLE CALCULATOR");
            Console.Write("Enter an integer for the radius: ");
            radius = double.Parse(Console.ReadLine());  //prompt input for radius

            if (radius <= 0) //throw an exception if the number input is less than or equal to zero
            {
                throw new ArithmeticException();
            }
                   
            Console.WriteLine($"The circumference is {Circumference(radius)}."); //pass radius to Circumference() and output circumference
            Console.WriteLine($"The area is {Area(radius)}."); //pass radius to Area() and output area
        }
    }
}
