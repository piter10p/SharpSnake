using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    public class Logic
    {
        private Board board;

        public Logic(Settings settings)
        {
            board = new Board(settings.BoardSize);
        }
    }
}
