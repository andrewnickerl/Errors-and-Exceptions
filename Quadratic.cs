using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_and_Exceptions
{
    public class Quadratic
    {
        private double SolutionOne(double a, double b, double c)
        {  //calculates the first solution for a quadratic
            if((Math.Pow(b, 2) - 4.0 * a * c) < 0)
            {
                throw new Exception();
            }
            return checked(((-1.0 * b) + Math.Sqrt(Math.Pow(b, 2) - 4.0 * a * c)) / (2.0 * a));
        }
        private double SolutionTwo(double a, double b, double c)
        {  //calculates the second solution for a quadratic
            if ((Math.Pow(b, 2) - 4.0 * a * c) < 0)
            {
                throw new Exception();
            }
            return checked(((-1.0 * b) - Math.Sqrt(Math.Pow(b, 2) - 4.0 * a * c)) / (2.0 * a));
        }
        public void Show()
        {
            double a, b, c;
            Console.WriteLine("\nQUADRATIC CALCULATOR");
            Console.Write("Enter a: ");
            a = double.Parse(Console.ReadLine()); //input a
            Console.Write("Enter b: ");
            b = double.Parse(Console.ReadLine()); //input b             
            Console.Write("Enter c: ");
            c = double.Parse(Console.ReadLine()); //input c

            Console.WriteLine($"The first solution is {SolutionOne(a, b, c)}."); //output solution 1 for x
            Console.WriteLine($"The second solution is {SolutionTwo(a, b, c)}."); //output solution 2 for x
        }
    }
}
