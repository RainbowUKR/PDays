using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Content;
using WindowsPhoneGame4.GameElements.Characters;

namespace WindowsPhoneGame4.StateManagerFramework
{
    public class SourceGameState : BaseState
    {
        private const string BG_PATH = "background";

        private Texture2D bg;
        private Rectangle bgRect = new Rectangle(0, 0, 800, 480);

        private PersonalComputer pc;

        public SourceGameState()
        {
            var pcRect = new Rectangle(400, 240, 77, 55);
            this.pc = new PersonalComputer();
        }

        public override void Initialize()
        {
            var pos = new Vector2(400,240);
            this.pc.Initialize(pos, 77, 55);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bg, bgRect, Color.White);
            this.pc.Draw(spriteBatch);
        }

        public override void LoadContent(ContentManager contentManager)
        {
            bg = contentManager.Load<Texture2D>(BG_PATH);
            this.pc.LoadContent(contentManager);
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
