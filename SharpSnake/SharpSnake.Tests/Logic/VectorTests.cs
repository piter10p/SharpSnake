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
        public void Adding()
        {
            var a = new Vector(5, 20);
            var b = new Vector(5, 20);
            var c = a + b;

            var expected = new Vector(10, 40);

            Assert.AreEqual(true, c.Equals(expected));
        }
    }
}
