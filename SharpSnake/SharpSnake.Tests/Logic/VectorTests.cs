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
    }
}
