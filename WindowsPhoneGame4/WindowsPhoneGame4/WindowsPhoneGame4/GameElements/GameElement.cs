using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;

namespace WindowsPhoneGame4.GameElements
{
    public class GameElement
    {
        public Rectangle DestRect;

        public Vector2 Position { get; private set; }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public void Initialize(Vector2 possition, int width, int height);

        public void Update(GameTime gameTime);

        public void UpdateTouch(TouchLocation touch);

        public void Draw(SpriteBatch spriteBatch);
    }
}
