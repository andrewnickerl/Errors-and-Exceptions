using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_and_Exceptions
{
    class Quadratic
    {
        private double SolutionOne(double a, double b, double c)
        {
            return ((-1.0 * b) + Math.Sqrt(Math.Pow(b, 2) - 4.0 * a * c)) / 2.0 * a;
        }
        private double SolutionTwo(double a, double b, double c)
        {
            return ((-1.0 * b) - Math.Sqrt(Math.Pow(b, 2) - 4.0 * a * c)) / 2.0 * a;
        }
        public void Show()
        {
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine()); //input a
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());  //input b
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());  //input c

            Console.WriteLine($"\nThe first solution is {SolutionOne(a,b,c)}.");  //output solution 1 for x
            Console.WriteLine($"The second solution is {SolutionTwo(a,b,c)}.");  //output solution 2 for x
        }
    }
}
