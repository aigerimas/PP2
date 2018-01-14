using System.Collections.Generic;

namespace Snake
{
    internal class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorisontalLine upLine = new HorisontalLine(0, mapWidth - 2, 0, '#');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 2, 0, '#');
            HorisontalLine downLine = new HorisontalLine(0, mapWidth - 2, 24, '#');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 2, mapWidth - 2, '#');
            wallList.Add(upLine);
            wallList.Add(leftLine);
            wallList.Add(downLine);
            wallList.Add(rightLine);
        }
        public void Draw()
        {
            foreach(Figure f in wallList)
            {
                f.Draw();
            }
        }
        public bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }                
            }
            return false;
        }
        
    }
}