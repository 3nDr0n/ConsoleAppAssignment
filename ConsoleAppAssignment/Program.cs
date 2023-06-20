using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your 1st number");
            string firstNumber = Console.ReadLine(); //Created variable with value based on user input
            int firstResult = Convert.ToInt32(firstNumber) * 50; //Casted value to use in math operation
            Console.WriteLine("Your number multiplied by 50 is " + firstResult); //Displays result

            Console.WriteLine("Please enter your 2nd number");
            string secondNumber = Console.ReadLine(); //Created variable with value based on user input
            int secondResult = Convert.ToInt32(secondNumber) + 25;  //Casted value to use in math operation
            Console.WriteLine("Your number plus 25 is " + secondResult); //Displays result

            Console.WriteLine("Please enter your 3rd number");
            string thirdNumber = Console.ReadLine(); //Created variable with value based on user input
            double thirdResult = Convert.ToInt32(thirdNumber) / 12.5;  //Casted value to use in math operation
            Console.WriteLine("Your number divided by 12.5 is " +  thirdResult); //Displays result

            Console.WriteLine("Please enter your 4rd number");
            string fourthNumber = Console.ReadLine(); //Created variable with value based on user input
            bool fourthResult = Convert.ToInt32(fourthNumber) > 50;  //Casted value to use in logic operation
            Console.WriteLine("Your number is greater than 50: " + fourthResult); //Displays result

            Console.WriteLine("Please enter your 5th number");
            string fifthNumber = Console.ReadLine(); //Created variable with value based on user input
            int fifthResult = Convert.ToInt32(fifthNumber) %7;  //Casted value to use in math operation
            Console.WriteLine("When your number is divided by 7, the remainder is: " + fifthResult);  //Displays result
            Console.ReadLine();
        }
    }
}

