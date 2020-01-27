using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_and_Exceptions
{
    class Circle
    {
        double radius;

        private double CircleCircumference()
        {
            Console.WriteLine("Part 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            radius = double.Parse(Console.ReadLine());

            double circumference = 2 * Math.PI * radius; //calculate circumference

            Console.WriteLine($"The circumference is {circumference}");  //output circumference
        }
        private double CircleArea()
        {
            Console.WriteLine("Part 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            radius = double.Parse(Console.ReadLine());

            return Math.PI * Math.Pow(radius, 2); //calculate and return area

            Console.WriteLine($"The area is {area}");  //output circumference
        }
        public string ShowCalculations()
        {
            return $""
        }


    }
}
