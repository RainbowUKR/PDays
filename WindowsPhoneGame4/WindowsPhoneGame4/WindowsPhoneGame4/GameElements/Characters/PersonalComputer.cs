using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace WindowsPhoneGame4.GameElements.Characters
{
    public class PersonalComputer : GameElement
    {
        private const string TEX_PATH = "old-pc";

        private Texture2D texture;

        public void LoadContent(ContentManager contentManager)
        {
            this.texture = contentManager.Load<Texture2D>(TEX_PATH);
        }

        public void Initialize(Vector2 position, int width, int height)
        {
            this.Position = position;

            this.Width = width;
            this.Height = height;
                       
            int x = (int)position.X - width / 2;
            int y = (int)position.Y - height / 2;
            this.DestRect = new Rectangle(x, y, width, height);
        }

        public override void Update(GameTime gameTime)
        {
            
        }

        public override void UpdateTouch(Microsoft.Xna.Framework.Input.Touch.TouchLocation touch)
        {
            
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.DestRect, Color.White);
        }
    }
}
