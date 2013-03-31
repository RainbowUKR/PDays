using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Content;

namespace WindowsPhoneGame4.StateManagerFramework
{
    public class SourceGameState : BaseState
    {
        private const string BG_PATH = "background";

        private Texture2D bg;
        private Rectangle bgRect = new Rectangle(0, 0, 800, 480);

        public override void Initialize()
        {
            
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bg, bgRect, Color.White);
        }

        public override void LoadContent(ContentManager contentManager)
        {
            bg = contentManager.Load<Texture2D>(BG_PATH);
        }

        public override void OnEntering()
        {
            
        }

        public override void OnLeaving()
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            
        }

    }
}
