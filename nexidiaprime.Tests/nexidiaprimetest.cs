using NUnit.Framework;
using System.Collections.Generic;

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

        [Test]
        public void seventytwofactorsintothislist()
        {
            List<long> rightlist = new List<long>(){ 2, 2, 2, 3, 3 };
            Assert.AreEqual(rightlist, Prime.Findprimes(72));
        }
    }
}
