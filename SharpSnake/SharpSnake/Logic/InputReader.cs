using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSnake.Logic
{
    public static class InputReader
    {
        public static Input ReadInput()
        {
            var input = Input.None;

            while(Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                input = GetInputFromKey(key);
            }

            return input;
        }
    }
}
