using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TestGame
{
    class Map
    {
        public int x_size;
        public int y_size;
        public int[,] map;

        public Map(int x, int y)
        {
            x_size = x;
            y_size = y;
            map = new int[x_size,y_size];

        }

        public void Draw()
        {
            for (int y = 0; y < y_size; y++)
            {
                for (int x = 0; x < x_size; x++)
                {
                    //tile.Draw(x,y);
                }
            }

        }
    }


}
