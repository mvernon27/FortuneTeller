using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variable Declarations**


            Console.WriteLine("What is your first name?");
            string fName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the numerical value of your birth-month?");
            int bMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? Type 'help' for color list or 'Enter' key to continue.");

            if (Console.ReadLine() == "help")                                                                                           //Needs Loop
            {
                Console.WriteLine("R=Red, O=Orange, Y=Yellow, G=Green, B=Blue, I=Indigo, V=Violet:");
            }

            Console.WriteLine("What is your favorite ROYGBIV color? ");                         
            string color = Console.ReadLine();

            Console.WriteLine("How many sibling do you have?");
            int siblings = Convert.ToInt32(Console.ReadLine());


            //End Variable declarations



            //-----------------------------------------------------------------------------------------------------------------------------------------------------------



            //Fortune write start**


            Console.Write(fName + " " + lName + " ");                     //First & Last name


            if (age % 2 == 0)

            {
                Console.Write("will retire in 100 years with ");           //even age
            }
            else
            {
                Console.Write("will retire next year with ");              //odd age
            }


            if (bMonth >= 1 && bMonth <= 4)                                                                       //Birth Month
            {
                Console.Write("$1.00 in the bank, ");
            }
            if (bMonth >= 5 && bMonth <= 8)
            {
                Console.Write("$1,000,000,000 in the bank, ");
            }
            if (bMonth >= 9 && bMonth <= 12)
            {
                Console.Write("$1,000 in the bank, ");
            }
            if (bMonth < 0)
            {
                Console.Write("$0.00 in the bank,");
            }
            if (bMonth > 12)
            {

                Console.Write("$0.00 in the bank, ");
            }


                if (siblings > 4)                                                                     //Number of siblings
            {
                Console.Write("a vacation home in Cleveland, OH, ");
            }
            else if (siblings == 1)
            {
                    Console.Write("a vacation home in Detroit, MI, ");
            }
            else if (siblings == 2)
            {
                Console.Write("a vacation home in Chicago, IL, ");
            }
            else if (siblings == 3)
            {
                Console.Write("a vacation home in Columbus, OH, ");
            }
            else if (siblings == 4)
            {
                Console.Write("a vacation home in Venice, Italy, ");
            }
            else if (siblings < 0)
            {
                Console.Write("a vacation home in Las Angeles, CA, ");
            }



            if (color.ToUpper().Equals("R"))                                                                      //Favorite color
            {
                Console.Write("and travel by bicycle.");
            }
            if (color.ToUpper().Equals("O"))
            {
                Console.Write("and travel by tricycle.");
            }
            if (color.ToUpper().Equals("Y"))
            {
                Console.Write("and travel by car.");
            }
            if (color.ToUpper().Equals("G"))
            {
                Console.Write("and travel by truck.");
            }
            if (color.ToUpper().Equals("B"))
            {
                Console.Write("and travel by rocket.");
            }
            if (color.ToUpper().Equals("I"))
            {
                Console.Write("and travel by walking.");
            }
            if (color.ToUpper().Equals("V"))
            {
                Console.Write("and travel by running.");
            }


            
            }



        }

    }



