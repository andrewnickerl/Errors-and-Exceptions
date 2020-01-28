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
            return ((-1.0 * b) + Math.Sqrt(Math.Pow(b, 2) - 4.0 * a * c)) / (2.0 * a);
        }
        private double SolutionTwo(double a, double b, double c)
        {  //calculates the second solution for a quadratic
            if ((Math.Pow(b, 2) - 4.0 * a * c) < 0)
            {
                throw new Exception();
            }
            return ((-1.0 * b) - Math.Sqrt(Math.Pow(b, 2) - 4.0 * a * c)) / (2.0 * a);
        }
        public void Show()
        {
            double a = 0, b = 0, c = 0;
            Console.WriteLine("Part 4, solving a quadratic equation.");
            Console.Write("Enter a: ");
            try //input a
            {
                a = double.Parse(Console.ReadLine()); 
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Show();
                return;
            }
            Console.Write("Enter b: ");
            try //input b
            {
                b = double.Parse(Console.ReadLine());  
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Show();
                return;
            }           
            Console.Write("Enter c: ");
            try //input c
            {
                c = double.Parse(Console.ReadLine());  
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Show();
                return;
            }

            try //output solution 1 for x
            {
                Console.WriteLine($"The first solution is {SolutionOne(a, b, c)}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot calculate square root of a negative number.");
                Show();
                return;
            }
            try //output solution 2 for x
            {
                Console.WriteLine($"The second solution is {SolutionTwo(a, b, c)}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot calculate square root of a negative number.");
                Show();
                return;
            }
        }
    }
}
