using System;
using System.Collections.Generic;

namespace Snake
{
    internal class FoodCreator : Figure
    {       
        int mapWidth;
        int mapHeight;
        // char sym;
        List<Point> foodList;
        Random random = new Random();
        int current;
        public FoodCreator(int mapWidth, int mapHeight)//, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            current = 0;
           // this.sym = sym;
        }

        public void FoodCreate()
        {
            foodList = new List<Point>();           
            for (int i = 1+48; i <= 5+48; i++)
            {
                int x = random.Next(2, mapWidth - 2);
                int y = random.Next(2, mapHeight - 2);
                char ch = (char)i;
                Point p = new Point(x, y, ch);
                foodList.Add(p);
                pList = foodList;
                
            }
            Draw();
        }
        public bool IsHitNumber()
        {
            
        }
    }
}