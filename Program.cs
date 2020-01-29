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
            Run();
            Console.ReadKey();
        }

        //includes try/catch/finally embedded in a do while loop in order to validate user input
        //allows itself to be called recursively through Continue()
        static void Run()
        {
            bool again;
            int selection = MainMenu();

            do
            {
                again = false;

                try
                {
                    ExecuteSelection(selection);
                    Continue();
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message + "\n");
                    again = true;
                }
                catch (ArithmeticException aEx)
                {
                    Console.WriteLine("Please input a positive number.\n");
                    again = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Cannot take the square root of a negative number.\n");
                    again = true;
                }
                finally
                {
                    /*  I don't want to output text here because it will execute whether an exception
                    is thrown or not, and I would prefer distinct messages to be displayed for each case  */
                }
            } while (!!again);
        }
        
        //returns the user's selection of which calculator to use
        static int MainMenu()
        {
            int selection;
            bool choice;
            Console.WriteLine("Which calculation would you like to execute? " +
                "\n\n1. Circumference and area of a circle" +
                "\n2. Volume of a hemisphere" +
                "\n3. Area of a triangle" +
                "\n4. Quadratic formula" +
                "\n\nOr enter another key to exit.\n");
            choice = Int32.TryParse(Console.ReadLine(), out selection);
            if(!choice)
            {
                selection = 0;
            }
            return selection;
        }

        //uses a switch to determine which calculator class function will be called
        //should be passed the selection from MainMenu() as parameter
        static void ExecuteSelection(int selection)
        {
            Circle cir = new Circle();
            Hemisphere hemi = new Hemisphere();
            Triangle tri = new Triangle();
            Quadratic quad = new Quadratic();

            switch (selection)
            {
                case 1:
                    cir.Show();
                    break;
                case 2:
                    hemi.Show();
                    break;
                case 3:
                    tri.Show();
                    break;
                case 4:
                    quad.Show();
                    break;
            }
        }

        //allows the user to press 1 to use the calculator tools again upon finishing one use
        static void Continue()
        {
            int selection;
            bool choice;

            Console.WriteLine("\nIf you would like to execute another calculation, please enter 1." +
                "  Enter anything else to exit.\n");
            choice = Int32.TryParse(Console.ReadLine(), out selection);

            if (selection == 1)
            {
                Run();
            }
            else
            {
                Console.WriteLine("Terminating program...");
            }
        }
    }
}
