using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake 
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            pList = new List<Point>();
            direction = _direction;
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        public bool IsHitTail()
        {
            Point head = pList.Last();
            for(int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }
        public bool Eat(FoodCreator foodCreator)
        {
            if (foodCreator.IsHitNumber())
                return true;
            else
                return false;
        }
        public Point GetNextPosition()
        {
            Point head = pList.Last();
            Point p = new Point(head);
            p.Move(1, direction);
            return p;
        }
        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point Head = GetNextPosition();
            tail.Clear();
            pList.Add(Head);            
            Head.Draw();
            
        }
        public void HandleKey(ConsoleKeyInfo key)
        {
            if(key.Key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
        }
    }
}
