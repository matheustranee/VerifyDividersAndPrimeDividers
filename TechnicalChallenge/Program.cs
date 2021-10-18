using System;
using TechnicalChallenge.src.Controllers;

namespace TechnicalChallenge
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int inputValue;

            try
            {
                inputValue = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Invalid Input. Your input must be an integer.");
                throw;
            }

            NumberController number = new NumberController(inputValue);
            number.VerifyDividers();
        }
    }
}
