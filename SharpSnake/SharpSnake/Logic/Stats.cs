using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    class Stats
    {
        public Vector HeadPosition { get; set; }
        public Input HeadHeading { get; set; } = Input.Up;

        public Stats(Vector headPosition)
        {
            HeadPosition = headPosition;
        }
    }
}
