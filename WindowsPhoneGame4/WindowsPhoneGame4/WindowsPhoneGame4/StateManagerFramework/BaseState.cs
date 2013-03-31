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
    public abstract class BaseState
    {
        public abstract void Initialize();


        public abstract void LoadContent(ContentManager contentManager);


        public abstract void OnEntering();


        public abstract void OnLeaving();


        public abstract void Draw(SpriteBatch spriteBatch);

        public abstract void Update(GameTime gameTime);

    }
}
