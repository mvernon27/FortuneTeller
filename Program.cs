using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What is your first name?");
            string fName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the numerical value of your birth-month?");
            int bMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your favorite ROYGBIV color? Type 'help' for color list");

            if (Console.ReadLine() == "help")
            {
                Console.WriteLine("R=Red, O=Orange, Y=Yellow, G=Green, B=Blue, I=Indigo, V=Violet: Select one to continue.");
            }

            string color = Console.ReadLine();
            Console.WriteLine("How many sibling do you have?");
            int siblings = Convert.ToInt32(Console.ReadLine());

            {
                if (age % 2 == 0)           //even

                {
                    Console.WriteLine("You will retire in 100 years: Press a key to continue.");
                }
                else
                {
                    Console.WriteLine("You will retire next year.");              //odd
                }

                if (siblings == 0)
                {
                    Console.WriteLine("Your vacation home will be Cleveland, OH.");
                }
                else if (siblings == 1)
                {
                    Console.WriteLine("Your vacation home will be Detroit, MI");
                }
                else if (siblings == 2)
                {
                    Console.WriteLine("Your vacation home will be Chicago, IL");
                }
                else if (siblings == 3)
                {
                    Console.WriteLine("Your vacation home will be Columbus, OH");
                }
                else if (siblings > 3)
                {
                    Console.WriteLine("Your vacation home will be Venice, Italy");
                }
                else if (siblings < 0)
                {
                    Console.WriteLine("Your vacation home will be Las Angeles, CA");
                }
            }
            if (color == "R") {Console.WriteLine("Your mode of transportation will be."); }
            if (color == "O)  {Console.WriteLine("Your mode of transportation will be."); }
            if (color == "Y") { Console.WriteLine("Your mode of transportation will be."); }
            if (color == "G") { Console.WriteLine("Your mode of transportation will be."); }
            if (color == "B") { Console.WriteLine("Your mode of transportation will be."); }
            if (color == "I") { Console.WriteLine("Your mode of transportation will be."); }
            if (color == "V") { Console.WriteLine("Your mode of transportation will be."); }








        }
           
        }
    }


