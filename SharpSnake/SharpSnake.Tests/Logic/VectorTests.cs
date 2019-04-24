using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SharpSnake.Logic;

namespace SharpSnake.Tests.Logic
{
    [TestFixture]
    class VectorTests
    {
        [TestCase(0, 0, 0, 0, ExpectedResult = true)]
        [TestCase(-35, -300000, -35, -300000, ExpectedResult = true)]
        [TestCase(35, 300000, 35, 300000, ExpectedResult = true)]
        [TestCase(0, 0, 1, 0, ExpectedResult = false)]
        public bool Equals(int ax, int ay, int bx, int by)
        {
            var a = new Vector(ax, ay);
            var b = new Vector(bx, by);

            return a.Equals(b);
        }

        [Test]
        public void AddingVector()
        {
            var a = new Vector(5, 20);
            var b = new Vector(5, 20);
            var c = a + b;

            var expected = new Vector(10, 40);

            Assert.AreEqual(true, c.Equals(expected));
        }

        [Test]
        public void SubtractingVector()
        {
            var a = new Vector(10, 50);
            var b = new Vector(5, 20);
            var c = a - b;

            var expected = new Vector(5, 30);

            Assert.AreEqual(true, c.Equals(expected));
        }

        [Test]
        public void MultiplyingVector()
        {
            var a = new Vector(-5, 20);
            var b = new Vector(5, 20);
            var c = a * b;

            var expected = new Vector(-25, 400);

            Assert.AreEqual(true, c.Equals(expected));
        }

        [Test]
        public void DividingVector()
        {
            var a = new Vector(-5, 40);
            var b = new Vector(5, 20);
            var c = a / b;

            var expected = new Vector(-1, 2);

            Assert.AreEqual(true, c.Equals(expected));
        }

        [Test]
        public void DividingByZeroVector()
        {
            try
            {
                var a = new Vector(-5, 40);
                var b = new Vector(0, 20);
                var c = a / b;
            }
            catch (DivideByZeroException e)
            {
                return;
            }
            catch
            {
                Assert.Fail("Dividing don't throw desired exception.");
            }

        }
    }
}
