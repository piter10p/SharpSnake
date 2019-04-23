using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SharpSnake.Logic;

namespace SharpSnake.Tests.Logic
{
    [TestFixture]
    class BoardTests
    {
        [Test]
        public void Constructor()
        {
            var size = new Vector(5, 5);
            var board = new Board(size);
            Assert.AreEqual(25, board.Size.Area);
        }

    }
}
