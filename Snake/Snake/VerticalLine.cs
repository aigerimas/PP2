using System.Collections.Generic;

namespace Snake
{
    internal class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {                
                Point point = new Point(x, y, sym);
                pList.Add(point);
            }
        }
    }
}