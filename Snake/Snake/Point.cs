using System;

namespace Snake
{
    internal class Point
    {
        private int x;
        private int y;
        private char sym;
        private int number;
        public Point()
        {

        }
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public Point(int x, int y, int number)
        {
            this.x = x;
            this.y = y;
            this.number = number;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.DOWN)
            {
                y += offset;
            }
            else if(direction == Direction.UP)
            {
                y -= offset;
            }
            else if(direction == Direction.LEFT)
            {
                x -= offset;
            }
            else if(direction == Direction.RIGHT)
            {
                x += offset;
            }
        }
        public bool IsHit(Point p)
        {
            return x == p.x && y == p.y;
        }
    }
}