using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Area
        {
            get
            {
                return X * Y;
            }
        }

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

        public bool Equals(Vector vector)
        {
            if (X == vector.X && Y == vector.Y)
                return true;
            return false;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            var vector = new Vector();
            vector.X = a.X + b.X;
            vector.Y = a.Y + b.Y;
            return vector;
        }

        public static Vector operator -(Vector a, Vector b)
        {
            var vector = new Vector();
            vector.X = a.X - b.X;
            vector.Y = a.Y - b.Y;
            return vector;
        }

        public static Vector operator *(Vector a, Vector b)
        {
            var vector = new Vector();
            vector.X = a.X * b.X;
            vector.Y = a.Y * b.Y;
            return vector;
        }

        public static Vector operator /(Vector a, Vector b)
        {
            try
            {
                if (b.X == 0 || b.Y == 0)
                    throw new DivideByZeroException();

                var vector = new Vector();
                vector.X = a.X / b.X;
                vector.Y = a.Y / b.Y;
                return vector;
            }
            catch
            {
                throw;
            }
        }
    }
}
