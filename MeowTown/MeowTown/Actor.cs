using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeowTown
{
    class Actor
    {
        private string _filename;
        private SpriteBatch _spriteBatch;
        private static Vector2 _vector;
        private static ContentManager _content;
        private static Texture2D _texture;
        private static Rectangle _rect;
        private static float _x;
        private static float _y;
        private static int _frame;
        private static int _frameRow;
        private static int _frameCol;
        //private static double _timer;

        //===Load Images===
        public static Texture2D RightView;
        public static Texture2D FrontView;
        public static Texture2D LeftView;
        public static Texture2D BackView;
        //=================

        public Actor(string filename, float x, float y, int frameRow, int frameCol)
        {
            _filename = filename;
            _x = x;
            _y = y;
            _frameRow = frameRow;
            _frameCol = frameCol;
            _vector = new Vector2(_x, _y);
        }

        public void Load()
        {
            _content = Game1.ContentRoot;
            //===Load Images===
            _texture = _content.Load<Texture2D>(_filename);
            RightView = _content.Load<Texture2D>("RightView");
            LeftView = _content.Load<Texture2D>("LeftView");
            FrontView = _content.Load<Texture2D>("FrontView");
            BackView = _content.Load<Texture2D>("BackView");
            //=================

            _spriteBatch = Game1.Batch;
            SetFrameRow();
            SetFrameCol();
            _rect = new Rectangle(_frame, 0, 17, _frameCol);
        }

        public void Draw()
        {
            _spriteBatch.Draw(_texture, _vector, _rect, Color.White);
        }

        public static Texture2D Texture
        {
            get { return _texture; }
            set { _texture = value; }
        }

        public static float X
        {
            get { return _vector.X; }
            set { _vector.X = value; }
        }

        public static float Y
        {
            get { return _vector.Y; }
            set { _vector.Y = value; }
        }

        public static float StartX
        {
            get { return _x; }
        }

        public static float StartY
        {
            get { return _y; }
        }

        public static float Width
        {
            get { return _texture.Width;  }
        }

        public static float Height
        {
            get { return _texture.Height;  }
        }

        public static int FrameRow
        {
            get { return _frameRow; }
        }

        public static int FrameCol
        {
            get { return _frameCol;  }
        }

        private void SetFrameRow()
        {
            if (_frameRow > 0) { _frameRow = (_texture.Width / _frameRow); }
            else { _frameRow = _texture.Width; }
        }

        private void SetFrameCol()
        {
            if (_frameCol > 0) { _frameCol = (_texture.Height / _frameCol); }
            else { _frameCol = _texture.Height; }
        }

        public static void RectFrame()
        {
            if (_frame >= (_texture.Width / _frameRow) - 1)
            {
                _rect.X = _frameRow;
                _frame = 1;
            }
            else
            {
                _rect.X += (short)(_frameRow);
                //_timer += Game1.Timer;

                ////_timer -= Game1.Timer;
                ////
                //while (_timer >= 100)
                //{
                //    _timer -= 100;
                //    _frame = (_frame + 1) % 100;
                //}
                    _frame++;
            }
        }

        public static bool isNewMap()
        {
            if (Actor.X > 600 || Actor.X < 20 || Actor.Y > 600 || Actor.Y < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
