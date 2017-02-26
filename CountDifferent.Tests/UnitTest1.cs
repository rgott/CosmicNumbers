using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace CountDifferent.Tests
{
    [TestClass]
    public class CosmicGeneratorTest
    {
        [TestMethod]
        public void ConvertToNumber100()
        {
            Assert.AreEqual(new BigInteger(100),CosmicGenerator.convertToNumber("One-Hundred"));
        }

        [TestMethod]
        public void ConvertToNumber1_240()
        {
            Assert.AreEqual(new BigInteger(240), CosmicGenerator.convertToNumber("Two-Hundred-Fourty"));
        }

        [TestMethod]
        public void ConvertToNumber14_006()
        {
            Assert.AreEqual(new BigInteger(14006), CosmicGenerator.convertToNumber("Fourteen-Thousand-Six"));
        }

        [TestMethod]
        public void ConvertToNumber100_000_000()
        {
            Assert.AreEqual(new BigInteger(100000000), CosmicGenerator.convertToNumber("One-Hundred-Million"));
        }

        [TestMethod]
        public void ConvertToNumber96()
        {
            Assert.AreEqual(new BigInteger(96), CosmicGenerator.convertToNumber("Ninety-Six"));
        }

        [TestMethod]
        public void ConvertToNumber16()
        {
            Assert.AreEqual(new BigInteger(16), CosmicGenerator.convertToNumber("Sixteen"));
        }
        [TestMethod]
        public void ConvertToNumber3()
        {
            Assert.AreEqual(new BigInteger(3), CosmicGenerator.convertToNumber("Three"));
        }

        
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
        


        [TestMethod]
        public void convertToWord10()
        {
            Assert.AreEqual("Ten", CosmicGenerator.convertToWord(new BigInteger(10)));
        }

        [TestMethod]
        public void convertToWord317()
        {
            Assert.AreEqual("Three-Hundred-Seventeen", CosmicGenerator.convertToWord(new BigInteger(317)));
        }
        [TestMethod]
        public void convertToWord96()
        {
            Assert.AreEqual("Ninety-Six", CosmicGenerator.convertToWord(new BigInteger(96)));
        }
        [TestMethod]
        public void convertToWord16()
        {
            Assert.AreEqual("Sixteen", CosmicGenerator.convertToWord(new BigInteger(16)));
        }
        [TestMethod]
        public void convertToWord100_000_000()
        {
            Assert.AreEqual("One-Hundred-Million", CosmicGenerator.convertToWord(new BigInteger(100000000)));
        }
        [TestMethod]
        public void convertToWord501()
        {
            Assert.AreEqual("Five-Hundred-One", CosmicGenerator.convertToWord(new BigInteger(501)));
        }


    }
}
