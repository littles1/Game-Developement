using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace MeowTown
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private static GraphicsDeviceManager _graphics;
        private static Viewport _viewport;
        private static SpriteBatch _spriteBatch;
        private static int _windowWidth;
        private static int _windowHeight;
        private static double _timer;

        static ContentManager _content;

        static Map _map = new Map("Map/map4", 0.0f, 0.0f);

        //===Load player images==========
        static Actor _player = new Actor("FrontView", 400.0f, 300, 4, 0);
        //===============================

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _content = Content;
        }

        protected override void Initialize()
        {
            _viewport = GraphicsDevice.Viewport;

            base.Initialize();
        }
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _windowWidth = _viewport.Width;
            _windowHeight = _viewport.Height;
            _map.Load();
            _player.Load();
            HUD.Load();
            Audio.Load();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Escape) || GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            _timer = gameTime.ElapsedGameTime.TotalMilliseconds;

            Movement.KeyPress();
            Camera2D.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, Camera2D.Transform);
            //_spriteBatch.Begin();
            _map.Draw();
            _player.Draw();

            if (Actor.isNewMap())
            {
                Map.Texture = _content.Load<Texture2D>("Map/map3");
                Actor.X = Actor.StartX;
                Actor.Y = Actor.StartY;
            }
            HUD.Draw();

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        public static GraphicsDeviceManager Graphics
        {
            get { return _graphics; }
        }

        public static ContentManager ContentRoot
        {
            get { return _content; }
        }

        public static SpriteBatch Batch
        {
            get { return _spriteBatch; }
        }

        public static Viewport Viewport
        {
            get { return _viewport; }
        }

        public static int WindowWidth
        {
            get { return _windowWidth; }
        }

        public static int WindowHeight
        {
            get { return _windowHeight; }
        }

        public static double Timer
        {
            get { return _timer; }
        }
    }
}
