using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeowTown
{
    class HUD
    {
        private static ContentManager _content;
        private static SpriteBatch _sprite;
        private static SpriteFont _font;
        private static int _health = 100;

        public static void Load()
        {
            _content = Game1.ContentRoot;
            _sprite = Game1.Batch;
            _font = _content.Load<SpriteFont>("Font/SpriteFont1");
        }

        public static void Draw()
        {
            _sprite.DrawString(_font, "Health: " + Convert.ToString(_health), new Vector2(Game1.WindowWidth - 125, 20), Color.Red);
        }
    }
}
