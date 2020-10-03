using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    public static class Helper
    {
        public static Position NextPosition(Direction direction, Position prevPosition, Maze maze)
        {
            var desiredPosition = new Position(prevPosition, direction);
            return maze.IsWall(desiredPosition) ? prevPosition : desiredPosition;
        }
    }
}
