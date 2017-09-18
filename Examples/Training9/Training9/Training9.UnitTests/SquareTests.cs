using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Training9.UnitTests
{
    [TestFixture]
    public class SquareTests
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Debug.WriteLine("Square Tests One Time Setup");
        }

        [SetUp]
        public void Setup()
        {
            Debug.WriteLine("Square Tests Setup");
        }

        [TearDown]
        public void TearDown()
        {
            Debug.WriteLine("Square Tests Tear Down");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Debug.WriteLine("Square Tests One Time Tear down");
        }

        [Test]
        [Category("Square")]
        public void Test1()
        {
            //Arrange
            double num = 2;

            //Act
            var result = Training9.Math.Square(num);

            //Assert
            Assert.That(result == 4);
        }

        [Test]
        [Category("Square")]
        public void Test2()
        {
            //Arrange
            double num = 3;

            //Act
            var result = Training9.Math.Square(num);

            //Assert
            Assert.That(result == 9);
        }

        [Test, TestCaseSource("SquareTestCases")]
        [Category("Square")]
        public double SquareTest(double n)
        {
            return Training9.Math.Square(n);
        }

        public static IEnumerable<TestCaseData> SquareTestCases()
        {
            yield return new TestCaseData(2).Returns(4);
            yield return new TestCaseData(3).Returns(9);
            yield return new TestCaseData(5).Returns(10);
        }
    }
}
