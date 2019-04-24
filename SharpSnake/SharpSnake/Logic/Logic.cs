using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    public class Logic
    {
        private Board board;
        private readonly TimeSpan stepTime = TimeSpan.FromMilliseconds(200);
        private State state;

        public Logic(Settings settings)
        {
            board = new Board(settings.BoardSize);
            state = new State(settings.BoardSize / 2);
        }

        /// <summary>
        /// Updates all game logic.
        /// Method implements fixed time loop for all its operations.
        /// </summary>
        /// <param name="deltaTime">Delta time from last method calling</param>
        /// <param name="input">Player input for logic</param>
        /// <returns>New value of delta time</returns>
        public TimeSpan Update(TimeSpan deltaTime, Input input)
        {
            try
            {
                while (deltaTime > stepTime)
                {
                    UpdateHeadPosition(input);

                    deltaTime -= stepTime;
                }

                return deltaTime;
            }
            catch(Exception e)
            {
                throw new Exception("Logic exception.", e);
            }
        }

        private void UpdateHeadPosition(Input input)
        {
            if (input != Input.None)
                stats.HeadHeading = input;

            switch(stats.HeadHeading)
            {
                case Input.Up:
                    stats.HeadPosition += new Vector(0, -1);
                    break;
                case Input.Down:
                    stats.HeadPosition += new Vector(0, 1);
                    break;
                case Input.Left:
                    stats.HeadPosition += new Vector(-1, 0);
                    break;
                case Input.Right:
                    stats.HeadPosition += new Vector(1, 0);
                    break;
                default:
                    throw new Exception("HeadHeading cannot be None");
            }
        }
    }
}
