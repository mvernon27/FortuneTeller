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

            if (Console.ReadLine() == "help")
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


            Console.WriteLine("Your name is " + fName + " " + lName);                     //First & Last name


            if (age % 2 == 0)         

                    {
                        Console.WriteLine("You will retire in 100 years.");           //even age
                    }
                    else
                    {
                        Console.WriteLine("You will retire next year.");              //odd age
                    }



                if (siblings > 4)                                                                     //Number of siblings
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
                    else if (siblings == 4)
                    {
                        Console.WriteLine("Your vacation home will be Venice, Italy");
                    }
                    else if (siblings < 0)
                    {
                        Console.WriteLine("Your vacation home will be Las Angeles, CA");
                    }
                
             

                if (color == "R")                                                                      //Favorite color
            {
                Console.WriteLine("Your mode of transportation will be bicycle.");
            }
                if (color == "O")
            {
                Console.WriteLine("Your mode of transportation will be tricycle.");
            }
                if (color == "Y")
            {
                Console.WriteLine("Your mode of transportation will be car.");
            }
                if (color == "G")
            {
                Console.WriteLine("Your mode of transportation will be truck.");
            }
                if (color == "B")
            {
                Console.WriteLine("Your mode of transportation will be rocket.");
            }
                if (color == "I")
            {
                Console.WriteLine("Your mode of transportation will be walking.");
            }
                if (color == "V")
            {
                Console.WriteLine("Your mode of transportation will be running.");
            }


            if (bMonth >= 1 && bMonth <= 4)                                                                       //Birth Month
            {
                Console.WriteLine("Your bank balance will be $1.00");
            }
                if (bMonth >= 5 && bMonth <= 8)
            {
                Console.WriteLine("Your bank balance will be $1,000,000,000");
            }
                if (bMonth >= 9 && bMonth <= 12)
            {
                Console.WriteLine("Your bank balance will be $1,000");
            }
                if (bMonth < 0)
            {
                Console.WriteLine("Your bank balance will be $0.00");
            }
                if (bMonth > 12)
                {

                    Console.WriteLine("Your bank balance will be $0.00");
                }
            


            }

        }
    }

    


