using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector()
        {
            X = 0;
            Y = 0;
        }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
