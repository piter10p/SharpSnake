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

        /// <summary>
        /// Updates all game logic.
        /// Method implements fixed loop for all its operations.
        /// </summary>
        /// <param name="deltaTime">Delta time from last method calling</param>
        /// <param name="input">Player input for logic</param>
        /// <returns>New value of delta time</returns>
        public TimeSpan Update(TimeSpan deltaTime, Input input)
        {
            while(deltaTime > stepTime)
            {
                UpdateLogic(input);

                deltaTime -= stepTime;
            }

            return deltaTime;
        }

        private void UpdateLogic(Input input)
        {

        }
    }
}
