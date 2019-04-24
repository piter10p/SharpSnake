using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    class Head
    {
        public Vector Position { get; private set; }
        public Direction Heading { get; private set; } = Direction.Up;
    }
}
