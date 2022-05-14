using NUnit.Framework;
using System;

namespace Summator.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test_SumTwoPositiveNumbers()
        {
            int actual = Summator.Sum(new int[] { 5, 7 });

            int expected = 12;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_SumOnePositiveNumbers()
        {
            int actual = Summator.Sum(new int[] { 7 });

            int expected = 7;
            Assert.That(expected == actual);
        }

        [Test]
        public void Test_SumEmptyArray()
        {
            int actual = Summator.Sum(new int[] { });

            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_SumTwoNegativeNumbers()
        {
            int actual = Summator.Sum(new int[] { -5, -7 });

            int expected = -12;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_SumBigValues()
        {
            Assert.Throws<OverflowException>( () =>
                {
                    int actual = Summator.Sum(new int[] { int.MaxValue, int.MaxValue });
       
                });
        }

        [Test]
        public void Test_AverageTwoPositiveNumbers()
        {
            double actual = Summator.Average(new int[] { 5, 7 });

            double expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_AverageOnePositiveNumbers()
        {
            double actual = Summator.Average(new int[] { 7 });

            double expected = 7;
            Assert.That(expected == actual);
        }

        [Test]
        public void Test_AverageEmptyArray()
        {
            double actual = Summator.Average(new int[] { });

            double expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_AverageTwoNegativeNumbers()
        {
            double actual = Summator.Average(new int[] { -5, -7 });

            double expected = -6;
            Assert.AreEqual(expected, actual);
        }

    }
}