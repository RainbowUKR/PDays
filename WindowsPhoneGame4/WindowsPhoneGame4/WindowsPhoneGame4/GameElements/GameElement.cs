using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;

namespace WindowsPhoneGame4.GameElements
{
    public abstract class GameElement
    {
        public Rectangle DestRect { get; set; }

        public Vector2 Position { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Update(GameTime gameTime);

        public abstract void UpdateTouch(TouchLocation touch);

        public abstract void Draw(SpriteBatch spriteBatch);


    }
}
