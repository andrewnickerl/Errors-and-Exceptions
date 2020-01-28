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
            Circle cir = new Circle();
            cir.Show();
            // Part 2
            Hemisphere hemi = new Hemisphere();
            hemi.Show();
            // Part 3
            Triangle tri = new Triangle();
            tri.Show();
            // Part 4
            Quadratic quad = new Quadratic();
            quad.Show();

            Console.ReadKey();
        }


    }
}
