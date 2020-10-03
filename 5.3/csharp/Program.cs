using System;
using System.Threading.Tasks;


namespace csharp
{
    using static Helper;

    class Program
    {
        static async Task Main(string[] args)
        {
            var maze = new Maze("maze.data");
            await EventLoopAsync(maze, maze.StartPosition);
        }

        private static async Task EventLoopAsync(Maze maze, Position currentPosition)
        {
            if (maze.IsExit(currentPosition)) return;

            var direction = await InputKeyboard();

            DrawMazeAndPlayer(maze, currentPosition, direction);

            var newPosition = NextPosition(direction, currentPosition, maze);

            await EventLoopAsync(maze, newPosition);
        }

        private static void DrawMazeAndPlayer(Maze maze, Position currentPosition, Direction direction)
        {
            Console.SetCursorPosition(0, 0);

        }
        
        private static async Task<Direction> InputKeyboard()
        {
            var key = Console.ReadKey();

            return key.Key switch
            {
                ConsoleKey.LeftArrow => Direction.Left,
                ConsoleKey.RightArrow => Direction.Right,
                ConsoleKey.UpArrow => Direction.Up,
                ConsoleKey.DownArrow => Direction.Down,
                _ => await InputKeyboard(),
            };


        }
    }
}
