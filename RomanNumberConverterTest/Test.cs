using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumberConverterTest {
    [TestClass]
    public class Test {
        [TestMethod]
        public void TestConvertToRoman() {

            // osnovne
            Assert.AreEqual("I", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("1"));
            Assert.AreEqual("V", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("5"));
            Assert.AreEqual("X", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("10"));
            Assert.AreEqual("L", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("50"));
            Assert.AreEqual("C", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("100"));
            Assert.AreEqual("D", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("500"));
            Assert.AreEqual("M", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("1000"));

            // posebnosti
            Assert.AreEqual("IV", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("4"));
            Assert.AreEqual("XL", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("40"));
            Assert.AreEqual("CD", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("400"));

            Assert.AreEqual("IX", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("9"));
            Assert.AreEqual("XC", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("90"));
            Assert.AreEqual("CM", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("900"));

            // random
            Assert.AreEqual("MCMXLV", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("1945"));
            Assert.AreEqual("MM", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("2000"));
            Assert.AreEqual("MCM", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("1900"));
            Assert.AreEqual("MCMXIX", RomanNumberConverter.RomanNumberConverter.ConvertToRoman("1919"));

        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException), "Number: is not valid number.Valid numbers are only positive integers.")]
        public void TestConvertToRomanException() {
            RomanNumberConverter.RomanNumberConverter.ConvertToRoman("-1");
            RomanNumberConverter.RomanNumberConverter.ConvertToRoman("a");
            RomanNumberConverter.RomanNumberConverter.ConvertToRoman("");
            RomanNumberConverter.RomanNumberConverter.ConvertToRoman("22.3");
        }
    }
}
