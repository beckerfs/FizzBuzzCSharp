using NUnit.Framework;
using System.IO;
using System;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        private FizzBuzz game;

        [SetUp]
        public void Setup()
        {
            game = new FizzBuzz();
        }

        [Test]
        public void IsFizz_ReturnsTrue_IfDivisibleBy3()
        {
            bool result = game.IsFizz(3);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsFizz_ReturnsFalse_IfNotDivisibleBy3()
        {
            bool result = game.IsFizz(5);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsBuzz_ReturnsTrue_IfDivisibleBy5()
        {
            bool result = game.IsBuzz(5);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsBuzz_ReturnsFalse_IfNotDivisibleBy5()
        {
            bool result = game.IsBuzz(2);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsFizzBuzz_ReturnsTrue_IfDivisibleBy15()
        {
            bool result = game.IsFizzBuzz(15);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsFizzBuzz_ReturnsFalse_IfNotDivisibleBy15()
        {
            bool result = game.IsFizzBuzz(14);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void PrintResult_PrintsStringPassed()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            game.PrintResult("Fizz");
            string expected = string.Format($"Fizz{Environment.NewLine}");
            //string expected = "Fizz";

            Assert.AreEqual(expected, sw.ToString());
        }
    }
}