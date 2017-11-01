using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    //[TestFixture]
    class Program
    {
        // [Test]
        static void Main(string[] args)
        {
            do
            {
                //Declare varibales for use throughout program
                //Some are for input, int c is for my counter
                int input = 0;
                int c = 0;
                int i;
                int j;

                //Declare my List and instatiate a new instance of it
                List<int> primes = new List<int>();
                
                //Declare a bool to test for integer
                bool success = false;
                while (!success)
                {
                    Console.Write("Which prime number would you like to look up:  ");

                    success = int.TryParse(Console.ReadLine(), out input);
                    if (!success)
                    {
                        Console.WriteLine("Please try again");
                    }
                    else if (input < 1)
                    {
                        Console.WriteLine("Please enter number again. ");
                        success = false;
                    }
                }



                //Prime number calculator, which uses 2 for loops and
                //After using modulus operator, asks if the remainder
                //Equals 0, then breaks the loop and asks if that number
                //Equals it's self. I then add that numbre to my List
                //And add 1 to my counter. I then use an if statement
                //To determine when the counter Equals the users input
                for (i = 2; i < 1000000; i++)
                {
                    for (j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            break;
                        }

                    }
                    if (i == j)
                    {
                        primes.Add(i);
                        c++;
                        if (c == input)
                        {
                            Console.WriteLine(primes[input - 1]);
                            break;
                        }
                    }
                }
                Console.WriteLine(Continue());
            } while (true);
        }
        public static string Continue()
        {
            while (true)
            {
                Console.Write("Do you want to look up another prime number? Yes or No: ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return ("Sounds Good. ");
                }
                else if (test == "n" || test == "no")
                {
                    Console.WriteLine("Bye");
                    Console.ReadLine();
                    Environment.Exit(1);
                }

            }
        }
    }
}
