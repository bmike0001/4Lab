using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;
            while (answer)
            { Console.WriteLine("Welcome to the Factorial calculator! \n");
                Console.WriteLine("Enter an Integer that is greater then 0 but les than 10");
                string input = Console.ReadLine();
                int number = int.Parse(input);


                long factorialAnswer = factorial(number);
                    Console.WriteLine("The factorial of " + number + " is " + factorialAnswer);
                Console.WriteLine("Do you want to continue? (y/n?)");
                    String con = Console.ReadLine();

                if (con == "y")
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                    Console.WriteLine("END");
                    return;
                }

                }
        }

        static long factorial(int number) {

            long factorial = 1;

            for (int count = 1; count <= number; count++)
            {
                factorial = factorial * count;
            }return factorial;

        }
    }
}
