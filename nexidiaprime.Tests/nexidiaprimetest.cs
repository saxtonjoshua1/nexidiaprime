using NUnit.Framework;

namespace nexidiaprime.Tests
{
    [TestFixture]
    public class nexidiaprimetest
    {
        [Test]
        public void smallNumbersareprime()
        {
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            for (var i = 0; i < numbers.Length; i++)
            {
                Assert.IsTrue(Prime.IsPrime(numbers[i]));
            }
        }

        [Test]
        public void negativenumbersAreNotPrime()
        {
            int[] numbers = { -2, -3, -5, -7, -11, -13, -17, -19, -23, -29 };

            for (var i = 0; i < numbers.Length; i++)
            {
                Assert.IsFalse(Prime.IsPrime(numbers[i]));
            }
        }
    }
}
