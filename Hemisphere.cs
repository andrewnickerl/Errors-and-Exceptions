using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_and_Exceptions
{
    class Hemisphere
    {
        private double Volume(double radius)
        {
            return (4.0 / 3.0 * Math.PI * Math.Pow(radius, 3) / 2.0); //calculate and return volume
        }
        public void Show()
        {
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius: ");
            double radius = double.Parse(Console.ReadLine());  //prompt input for radius

            Console.WriteLine($"The volume is {Volume(radius)}."); //pass radius to Volume() and output volume
        }
    }
}