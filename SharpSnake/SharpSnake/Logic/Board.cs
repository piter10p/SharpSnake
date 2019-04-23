using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    class Board
    {
        private Field[] fieldsArray;
        
        public Vector Size { get; private set; }

        public Board(Vector size)
        {
            if (size.X < 1 || size.Y < 1)
                throw new Exception("Board size can not be lesser than one in any dimension.");

            Size = size;
            fieldsArray = new Field[size.Area];
        }

        public Field GetField(Vector coordinates)
        {
            return fieldsArray[coordinates.Area];
        }
    }
}
