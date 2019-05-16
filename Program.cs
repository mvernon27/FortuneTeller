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

            Console.WriteLine("What is your favorite ROYGBIV color? Type in the first letter of the color you choose. Type 'help' for color list or 'Enter' key to continue.");

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


<<<<<<< HEAD
            if (bMonth >= 1 && bMonth <= 4)                                                                       //Birth Month
=======
                if (color.ToUpper().Equals ("R"))                                                                   //Favorite color
>>>>>>> d1ae5250d5b70b762defad997ebe596e45f5f831
            {
                Console.Write("$1.00 in the bank, ");
            }
<<<<<<< HEAD
            if (bMonth >= 5 && bMonth <= 8)
=======
                if (color.ToUpper().Equals ("O"))
>>>>>>> d1ae5250d5b70b762defad997ebe596e45f5f831
            {
                Console.Write("$1,000,000,000 in the bank, ");
            }
<<<<<<< HEAD
            if (bMonth >= 9 && bMonth <= 12)
=======
                if (color.ToUpper().Equals("Y"))
>>>>>>> d1ae5250d5b70b762defad997ebe596e45f5f831
            {
                Console.Write("$1,000 in the bank, ");
            }
<<<<<<< HEAD
            if (bMonth < 0)
            {
                Console.Write("$0.00 in the bank,");
            }
            if (bMonth > 12)
            {

                Console.Write("$0.00 in the bank, ");
            }


                if (siblings > 4)                                                                     //Number of siblings
=======
                if (color.ToUpper().Equals("G"))
>>>>>>> d1ae5250d5b70b762defad997ebe596e45f5f831
            {
                Console.Write("a vacation home in Cleveland, OH, ");
            }
<<<<<<< HEAD
            else if (siblings == 1)
=======
                if (color.ToUpper().Equals("B"))
>>>>>>> d1ae5250d5b70b762defad997ebe596e45f5f831
            {
                    Console.Write("a vacation home in Detroit, MI, ");
            }
<<<<<<< HEAD
            else if (siblings == 2)
=======
                if (color.ToUpper().Equals("I"))
>>>>>>> d1ae5250d5b70b762defad997ebe596e45f5f831
            {
                Console.Write("a vacation home in Chicago, IL, ");
            }
<<<<<<< HEAD
            else if (siblings == 3)
=======
                if (color.ToUpper().Equals("V"))
>>>>>>> d1ae5250d5b70b762defad997ebe596e45f5f831
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



