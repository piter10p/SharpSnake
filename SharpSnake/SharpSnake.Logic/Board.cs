using System;
using System.Collections.Generic;
using System.Text;
using SharpSnake.Logic.Fields;

namespace SharpSnake.Logic
{
    public class Board
    {
        private Field[] fieldsArray;
        
        public Vector Size { get; private set; }

        public Board(Vector size)
        {
            if (size.X < 1 || size.Y < 1)
                throw new Exception("Board size can not be lesser than one in any dimension.");

            Size = size;
            fieldsArray = new Field[size.Area];
            FillBoardWithEmptyFields();
        }

        public Field GetField(Vector coordinates)
        {
            return fieldsArray[coordinates.Area];
        }

        public Field GetField(int index)
        {
            return fieldsArray[index];
        }

        public void SetField(Vector coordinates, Field field)
        {
            fieldsArray[coordinates.Area] = field;
        }

        public void SetField(int index, Field field)
        {
            fieldsArray[index] = field;
        }

        private void FillBoardWithEmptyFields()
        {
            for(int i = 0; i < Size.Area; i++)
            {
                fieldsArray[i] = new Empty();
            }
        }
    }
}
