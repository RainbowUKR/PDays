using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;
using WindowsPhoneGame4.StateManagerFramework;

namespace WindowsPhoneGame4
{
    /// <summary>
    /// Это главный тип игры
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        StateManager stateManager;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            this.stateManager = new StateManager();
            Content.RootDirectory = "Content";

            // Частота кадра на Windows Phone по умолчанию — 30 кадров в секунду.
            TargetElapsedTime = TimeSpan.FromTicks(333333);

            // Дополнительный заряд аккумулятора заблокирован.
            InactiveSleepTime = TimeSpan.FromSeconds(1);
        }

        /// <summary>
        /// Позволяет игре выполнить инициализацию, необходимую перед запуском.
        /// Здесь можно запросить нужные службы и загрузить неграфический
        /// контент.  Вызов base.Initialize приведет к перебору всех компонентов и
        /// их инициализации.
        /// </summary>
        protected override void Initialize()
        {
            // ЗАДАЧА: добавьте здесь логику инициализации

            base.Initialize();
            this.stateManager.Initialize();
        }

        /// <summary>
        /// LoadContent будет вызываться в игре один раз; здесь загружается
        /// весь контент.
        /// </summary>
        protected override void LoadContent()
        {
            // Создайте новый SpriteBatch, который можно использовать для отрисовки текстур.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            this.stateManager.LoadContent();

            // ЗАДАЧА: используйте здесь this.Content для загрузки контента игры
        }

        /// <summary>
        /// UnloadContent будет вызываться в игре один раз; здесь выгружается
        /// весь контент.
        /// </summary>
        protected override void UnloadContent()
        {
            // ЗАДАЧА: выгрузите здесь весь контент, не относящийся к ContentManager
        }

        /// <summary>
        /// Позволяет игре запускать логику обновления мира,
        /// проверки столкновений, получения ввода и воспроизведения звуков.
        /// </summary>
        /// <param name="gameTime">Предоставляет моментальный снимок значений времени.</param>
        protected override void Update(GameTime gameTime)
        {
            // Позволяет выйти из игры
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
            {
                this.Exit();
            }
            // ЗАДАЧА: добавьте здесь логику обновления

            base.Update(gameTime);
            TouchCollectionHandler.TouchCollectionObject = TouchPanel.GetState();

            this.stateManager.Update(gameTime);
        }

        /// <summary>
        /// Вызывается, когда игра отрисовывается.
        /// </summary>
        /// <param name="gameTime">Предоставляет моментальный снимок значений времени.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // ЗАДАЧА: добавьте здесь код отрисовки

            base.Draw(gameTime);
            this.stateManager.Draw(spriteBatch);
        }
    }
}
