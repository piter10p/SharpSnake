using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    class State
    {
        public Vector HeadPosition { get; set; }
        public Input HeadHeading { get; set; } = Input.Up;

        public State(Vector headPosition)
        {
            HeadPosition = headPosition;
        }
    }
}
