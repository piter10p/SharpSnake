using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    public class Logic
    {
        private Board board;
        private readonly TimeSpan stepTime = TimeSpan.FromMilliseconds(200);

        public Logic(Settings settings)
        {
            board = new Board(settings.BoardSize);
        }

        public void Update(float deltaTime, Input input)
        {
        }
    }
}
