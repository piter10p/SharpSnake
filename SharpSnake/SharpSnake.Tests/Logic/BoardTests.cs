using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SharpSnake.Logic;
using SharpSnake.Logic.Fields;

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

            for(int i = 0; i < size.Area; i++)
            {
                var field = board.GetField(i);
                Assert.AreEqual(typeof(Empty), field.GetType());
            }
        }

        [Test]
        public void ConstructorWithSizeLesserThan1()
        {
            try
            {
                var size = new Vector(0, 1);
                var board = new Board(size);
            }
            catch(Exception e)
            {
                Assert.AreEqual("Board size can not be lesser than one in any dimension.", e.Message);
                return;
            }

            Assert.Fail("Exception not occured");
        }
    }
}
