using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace TestGame
{
    class Tile
    {
        public Texture2D icon;
        public int layer;
        public Vector2 position;
        public int height;
        public int width;

        public Tile(string fname,ContentManager content)
        {
            icon = content.Load<Texture2D>(fname);
            layer = 0;
            height = icon.Height;
            width = icon.Width;
            
        }

        public void Draw(int x, int y, SpriteBatch spriteBatch)
        {
            Rectangle tile = new Rectangle(x,y,x+width,y+height);
            spriteBatch.Draw(icon,tile,Color.White);
        }

        public void DrawRel(int x, int y, SpriteBatch spriteBatch)
        {
            Rectangle tile = new Rectangle(x * width+1, y * height+1, x + width, y + height);
            spriteBatch.Draw(icon, tile, Color.White);
            //position = new Vector2(x , y);
            
        }

    }


}
