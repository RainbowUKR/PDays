using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsPhoneGame4.GameElements.Characters
{
    public class Character : GameElement
    {
        private const int STEP = 8;

        private const int TIME_TO_STEP = 500;

        private const int FRAME_COUNT = 4;

        private float currentTime;

        private int xStep;
        private int yStep;

        private Texture2D spriteImg;

        private int sourceWidth;
        private int sourceHeight;

        private Rectangle sourceRectangle;

        private Direction currentDirection;

        private bool move;

        public Rectangle DestRect { get; private set; } 

        public Vector2 Position { get; private set; }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public Character()
        {
            this.move = false;

            this.currentTime = 0;

            this.xStep = 0;
            this.yStep = 0;
        }

        public void Initialize(Vector2 possition, int width, int height, int sourceWidth, int sourceHeight)
        {
            this.Position = possition;
            
            this.Width = width;
            this.Height = height;

            this.sourceWidth = sourceWidth;
            this.sourceHeight = sourceHeight;

            this.sourceRectangle = new Rectangle(0, 0, width, height);

            int x = (int)possition.X - width / 2;
            int y = (int)possition.Y - height / 2;
            this.DestRect = new Rectangle(x, y, width, height);
        }

        public void Stop()
        {
            this.GoTo(Direction.Bottom);

            this.move = false;
        }

        public void GoTo(Direction direction)
        {
            this.currentDirection = direction;

            int yCoef = 0;

            switch (direction)
            {
                case Direction.Bottom:

                    yCoef = 0;

                    this.xStep = 0;
                    this.yStep = STEP;
                    break;

                case Direction.Left:

                    yCoef = 1;

                    this.xStep = -STEP;
                    this.yStep = 0;
                    break;

                case Direction.Right:

                    yCoef = 2;

                    this.xStep = STEP;
                    this.yStep = 0;
                    break;

                case Direction.Top:

                    yCoef = 3;

                    this.xStep = 0;
                    this.yStep = -STEP;
                    break;
            }

            this.sourceRectangle.Y = yCoef * this.sourceHeight;
            this.sourceRectangle.X = 0;

            this.move = true;
        }

        public void LoadContent(Texture2D spriteImg)
        {

        }

        public override void Update(GameTime gameTime)
        {
            if (this.move)
            {
                this.currentTime += gameTime.ElapsedGameTime.Milliseconds;

                if (this.currentTime >= TIME_TO_STEP)
                {
                    this.currentTime = 0;

                    this.sourceRectangle.X += this.sourceWidth;

                    bool fromeBegin = this.sourceRectangle.X >= this.sourceWidth * FRAME_COUNT;

                    if (fromeBegin)
                    {
                        this.sourceRectangle.X = 0;
                    }

                    this.DestRect.Offset(this.xStep, this.yStep);
                    this.Position = new Vector2(this.DestRect.X, this.Position.Y);
                }
            }

        }

        public override void UpdateTouch(TouchLocation touch)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.spriteImg, this.DestRect, this.sourceRectangle, Color.White);
        }
    }
}
