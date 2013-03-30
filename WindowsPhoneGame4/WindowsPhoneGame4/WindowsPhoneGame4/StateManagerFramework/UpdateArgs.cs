using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework;

namespace WindowsPhoneGame4.StateManagerFramework
{
    public struct UpdateArgs
    {
        public TouchLocation touchLocation;
        public GameTime gameTime;
    }
}
