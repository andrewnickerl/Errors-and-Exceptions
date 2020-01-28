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
            double radius = 0;
            Console.WriteLine("Part 2, volume of a hemisphere.");
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

            Console.WriteLine($"The volume is {Volume(radius)}."); //pass radius to Volume() and output volume
        }
    }
}