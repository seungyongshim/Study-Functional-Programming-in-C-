namespace csharp
{
    public struct Position
    {
        public Position(Position original, Direction direction) : this()
        {
            X = direction switch
            {
                Direction.Left => original.X - 1,
                Direction.Right => original.X + 1,
                _ => original.X,
            };

            Y = direction switch
            {
                Direction.Up => original.Y - 1,
                Direction.Down => original.Y + 1,
                _ => original.Y,
            };
        }

        public int X { get; }
        public int Y { get; }
        
    }
}