using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {

        ////Get user input
        Start:
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine("There are 10 movies in this list.");
            Console.WriteLine("Please choose a category.");
            Console.WriteLine("(1) SciFi");
            Console.WriteLine("(2) Animated");
            Console.WriteLine("(3) Drama");
            Console.WriteLine("(4) Horror");
            Console.Write("What category are you interested in? ");
            string userInput = (Console.ReadLine());


            

            //Calls from here
            

            //Output
            
            Console.WriteLine("Continue? (y/n): ");
            string keepGoing = Console.ReadLine();
            if (keepGoing != "y")
            {
                Console.WriteLine("Goodbye!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                goto Start;
            }
        }
    }
}
