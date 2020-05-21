using System;
using System.Reflection.Metadata;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task:
            //Calculate the factorial of a number.   

            //What will the application do?  
            //● The application prompts the user to enter an integer from 1 to 10. 
            //● The application displays the factorial of the number entered by the user.  
            //● The application prompts the user to continue.  

            //Build Speciﬁcations  
            //1. Use a for loop to calculate the factorial.
            //2. Assume that the user will enter valid data. 
            //3. Use the long type to store the factorial.  
            //4. The application should continue only if the user agrees to.

            //Extended Challenges:   
            //● Test the application and ﬁnd the integer for the highest factorial that can be accurately calculated by this application, 
            //then modify the prompt so that it prompts the user for a number “from 1 to {the highest integer that returns accurate factorial calculation}”.   
            //● Use Recursion to implement the factorial.  

            Console.WriteLine("Welcome to the Factorial Calulator!\n");

            string more = "y";
            long fact = 1;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter a number from 1 to 20");
                long input = long.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 1; i <= input; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine($"The factorial of {input} is {fact}\n");
                Console.WriteLine("Would you like to to continue? (y/n)");
                more = Console.ReadLine();
            } while (more == "y");
            Console.WriteLine();
            Console.WriteLine("Goodbye");
        }

        public string YesOrNoValidation(string input)
        {
            input = input.ToLower();
            string go = "y";

            do
            {
                if (input == "y" || input == "n")
                {
                    go = "n";
                }
                else
                {
                    Console.WriteLine("Please enter valid input (y/n)");
                    input = Console.ReadLine();
                }
            } while (go == "y");

            return input;
        }
    }
}
