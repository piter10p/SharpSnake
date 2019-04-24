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

        private static Input GetInputFromKey(ConsoleKeyInfo key)
        {
            switch(key.Key)
            {
                case ConsoleKey.UpArrow:
                    return Input.Up;
                case ConsoleKey.DownArrow:
                    return Input.Down;
                case ConsoleKey.LeftArrow:
                    return Input.Left;
                case ConsoleKey.RightArrow:
                    return Input.Left;
            }

            return Input.None;
        }
    }
}
