using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    class State
    {
        public Head Head { get; private set; }

        public State(Vector headPosition)
        {
            Head = new Head(headPosition);
        }
    }
}
