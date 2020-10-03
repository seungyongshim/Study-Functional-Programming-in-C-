using System;
using System.Text.Json;


namespace csharp
{
    public class Maze
    {
        MazeData MazeData { get; }
        public Maze(string fileName)
        {

        }

        public Position StartPosition { get; internal set; }

        public bool IsWall(Position desiredPosition)
        {
            
        }

        internal bool IsExit(Position currentPosition)
        {
            
        }
    }
}