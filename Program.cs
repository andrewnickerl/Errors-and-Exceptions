using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_and_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            Circle circle = new Circle();
            circle.Show();
            // Part 2
            VolumeHemi();
            // Part 3
            TriangleArea();
            // Part 4
            Quadratic();
        }

        static void VolumeHemi()
        {
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius: ");
            string temp = Console.ReadLine();  //input radius
            int radius = int.Parse(temp);
            double volume = (4.0 / 3.0 * Math.PI * Math.Pow(radius, 3) / 2.0); //calculate volume

            Console.WriteLine($"The volume is {volume}");  //output volume 
        }
        static void TriangleArea()
        {
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.Write("Enter an integer for the first side: ");
            string temp = Console.ReadLine();  //input first side
            double side1 = double.Parse(temp);
            Console.Write("Enter an integer for the second side: ");
            temp = Console.ReadLine();  //input second side
            double side2 = double.Parse(temp);
            Console.Write("Enter an integer for the third side: ");
            temp = Console.ReadLine();  //input third side
            double side3 = double.Parse(temp);

            double half_perimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(half_perimeter * (half_perimeter - side1) * (half_perimeter - side2) * (half_perimeter - side3));  //calculate area

            Console.WriteLine($"The area is {area}");  //output area
        }
        static void Quadratic()
        {
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.Write("Enter a: ");
            string temp = Console.ReadLine();  //input a
            double a = double.Parse(temp);
            Console.Write("Enter b: ");
            temp = Console.ReadLine();  //input b
            double b = double.Parse(temp);
            Console.Write("Enter c: ");  //input c
            temp = Console.ReadLine();
            double c = double.Parse(temp);

            double positive_num = ((-1.0 * b) + Math.Sqrt(Math.Pow(b, 2) - 4.0 * a * c)) / 2.0 * a;
            double negative_num = ((-1.0 * b) - Math.Sqrt(Math.Pow(b, 2) - 4.0 * a * c)) / 2.0 * a;

            Console.WriteLine($"\nThe positive solution is {positive_num}");  //output 2 solutions for x
            Console.WriteLine($"The negative solution is {negative_num}");
            Console.ReadKey();
        }
    }
}
