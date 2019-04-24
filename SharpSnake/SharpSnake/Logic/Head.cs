using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    class Head
    {
        public Vector Position { get; private set; }
        public Direction Heading { get; private set; } = Direction.Up;

        public Head(Vector position)
        {
            Position = position;
        }

        /// <summary>
        /// Updates Head - heading and position.
        /// </summary>
        /// <param name="headingInput">Heading input to set. If none Heading will not change.</param>
        public void Update(Direction headingInput)
        {
            try
            {
                UpdateHeading(headingInput);
                ApplyMoving();
            }
            catch
            {
                throw;
            }
        }

        private void UpdateHeading(Direction headingInput)
        {
            if (headingInput != Direction.None)
                Heading = headingInput;
        }
    }
}
