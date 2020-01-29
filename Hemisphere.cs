using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_and_Exceptions
{
    public class Hemisphere
    {
        private double Volume(double radius)
        {
            return checked(4.0 / 3.0 * Math.PI * Math.Pow(radius, 3) / 2.0); //calculate and return volume
        }
        public void Show()
        {
            double radius;
            Console.WriteLine("\nHEMISPHERE VOLUME CALCULATOR");
            Console.Write("Enter an integer for the radius: ");
            radius = double.Parse(Console.ReadLine());  //prompt input for radius

            if (radius <= 0)  //throw an exception for negative input
            {
                throw new ArithmeticException();
            }
            
            Console.WriteLine($"The volume is {Volume(radius)}."); //pass radius to Volume() and output volume
        }
    }
}