using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace CountDifferent.Tests
{
    [TestClass]
    public class CosmicGeneratorTest
    {
        [TestMethod]
        public void findLowestNumberWord3()
        {
            Assert.AreEqual(new BigInteger(6), CosmicGenerator.NumberToFindNumberWithLetters(new BigInteger(3)));
        }

        [TestMethod]
        public void findLowestNumberWord11()
        {
            Assert.AreEqual(new BigInteger(53), CosmicGenerator.NumberToFindNumberWithLetters(new BigInteger(11)));
        }
    }
}
