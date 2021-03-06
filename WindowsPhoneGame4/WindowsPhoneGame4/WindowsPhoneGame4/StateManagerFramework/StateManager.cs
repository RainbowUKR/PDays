using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace WindowsPhoneGame4.StateManagerFramework
{
    public class StateManager
    {
        private SourceGameState sourceGameState;

        private BaseState activeState;

        public StateManager()
        {
            this.sourceGameState = new SourceGameState();
            this.activeState = this.sourceGameState;
        }

        public void Initialize()
        {
            this.sourceGameState.Initialize();
        }

        public void LoadContent(ContentManager contentManager)
        {
            this.sourceGameState.LoadContent(contentManager);
        }

        public void OnEntering()
        {
        }

        public void OnLeaving()
        {
        }

        public void Update(GameTime gameTime)
        {
            this.activeState.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.activeState.Draw(spriteBatch);
        }

    }
}
