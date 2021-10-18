using System;

namespace TechnicalChallenge.src.Utils
{
    public static class NumberUtils
    {
        public static bool IsDivisible(int number, int divider)
        {
            return (number % divider) == 0;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) 
                return false;
            if (number == 2) 
                return true;
            if (number % 2 == 0) 
                return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
