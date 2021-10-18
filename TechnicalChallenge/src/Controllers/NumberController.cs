using System;
using TechnicalChallenge.src.Utils;

namespace TechnicalChallenge.src.Controllers
{
    public class NumberController
    {
        public int Number { get; set; }

        public NumberController(int number)
        {
            Number = number;
        }

        public void VerifyDividers()
        {
            string dividers = "";
            string primeDividers = "";

            for (int i = 1; i <= Number; i++)
            {
                if (NumberUtils.IsDivisible(Number, i))
                {
                    dividers += i + " ";

                    if (NumberUtils.IsPrime(i))
                    {
                        primeDividers += i + " ";
                    }
                }

            }

            Console.WriteLine($"Input number: {Number}");
            Console.WriteLine($"Dividing numbers: {dividers}");
            Console.WriteLine($"Prime dividers: {primeDividers}");
        }

    }
}
