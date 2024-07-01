using FunctionLib;

namespace TestProject1
{
    public class MathTests
    {
        [Fact]
        public void PrimeTest()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            List<int> primeFunction = MathFunctions.PrimeFinder().GetRange(0,4);

            Assert.Equal(primeNumbers, primeFunction);
        }
        [Fact]
        public void FactorTest ()
        {
            Assert.Equal("2 x 5 x 5", MathFunctions.Factorize(50));
            Assert.Equal("2 x 2 x 2 x 5", MathFunctions.Factorize(40));
            Assert.Equal("2 x 3 x 5", MathFunctions.Factorize(30));
            Assert.Equal("7", MathFunctions.Factorize(7));
            Assert.Equal("2 x 2", MathFunctions.Factorize(4));

            int x = 1004;
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => MathFunctions.Factorize(x));
            Assert.Equal($"The number {x} is too large to factorize. (Parameter 'x')", exception.Message);
        }
    }
}