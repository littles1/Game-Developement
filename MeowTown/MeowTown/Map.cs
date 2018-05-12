using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeowTown
{
    class Map
    {
        private static string _filename;
        private SpriteBatch _spriteBatch;
        private static ContentManager _content;
        private static Texture2D _texture;
        private static float _x;
        private static float _y;
        private static Vector2 _vector;

        private Texture2D map1;
        private Texture2D map2;
        private Texture2D map3;
        private Texture2D map4;

        public Map(string filename, float x, float y)
        {
            _filename = filename;
            _x = x;
            _y = y;
            _vector = new Vector2(_x, _y);
        }

        public void Load()
        {
            _content = Game1.ContentRoot;
            _spriteBatch = Game1.Batch;

            //===Load Maps===
            _texture = _content.Load<Texture2D>(_filename);
            map1 = _content.Load<Texture2D>("Map/map1");
            map2 = _content.Load<Texture2D>("Map/map2");
            map3 = _content.Load<Texture2D>("Map/map3");
            map4 = _content.Load<Texture2D>("Map/map4");
            //=================
        }

        public void Draw()
        {
            _spriteBatch.Draw(_texture, _vector, Game1.Viewport.Bounds, Color.White);
        }

        public static Texture2D Texture
        {
            get { return _texture; }
            set { _texture = value; }
        }

        public static float X
        {
            get { return _vector.X; }
            set { _vector.X = _x + value; }
        }

        public static float Y
        {
            get { return _vector.Y; }
            set { _vector.Y = _y + value; }
        }
    }
}