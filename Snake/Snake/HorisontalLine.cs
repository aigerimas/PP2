﻿using System.Collections.Generic;

namespace Snake
{
    internal class HorisontalLine : Figure
    {
        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point point = new Point(x, y, sym);
                pList.Add(point);
            }
        }
    }
}