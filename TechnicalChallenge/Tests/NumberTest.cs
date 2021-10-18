using TechnicalChallenge.src.Utils;
using Xunit;

namespace TechnicalChallenge.Tests
{
    public class NumberTest
    {
        private int PrimeNumber;
        private int NotPrimeNumber;

        public NumberTest()
        {
            PrimeNumber = 2;
            NotPrimeNumber = 4;
        }

        [Fact]
        public void Valid_IsDivisibleNumber_ReturnTrue()
        {            
            bool result = NumberUtils.IsDivisible(45, 3);

            Assert.True(result);
        }
        
        [Fact]
        public void Valid_IsNotDivisibleNumber_ReturnFalse()
        {            
            bool result = NumberUtils.IsDivisible(45, 2);

            Assert.False(result);
        }

        [Fact]
        public void Valid_IsPrimeNumber_ReturnTrue()
        {
            bool result = NumberUtils.IsPrime(PrimeNumber);

            Assert.True(result);
        }

        [Fact]
        public void Valid_IsNotPrimeNumber_ReturnFalse()
        {
            bool result = NumberUtils.IsPrime(NotPrimeNumber);

            Assert.False(result);
        }
    }
}
