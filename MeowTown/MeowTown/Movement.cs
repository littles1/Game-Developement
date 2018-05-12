using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeowTown
{
    class Movement
    {
        public static void KeyPress()
        {
            KeyboardState _keys = Keyboard.GetState(PlayerIndex.One);
            GamePadState _pad = GamePad.GetState(PlayerIndex.One);
            if (_keys.IsKeyDown(Keys.Left) || _pad.ThumbSticks.Left.X < 0)
            {
                Actor.X -= 1; 
                Actor.Texture = Actor.LeftView;
                Actor.RectFrame();
            }
            if (_keys.IsKeyDown(Keys.Right)|| _pad.ThumbSticks.Left.X > 0)
            {
                Actor.X += 1;
                Actor.Texture = Actor.RightView;
                Actor.RectFrame();
            }
            if (_keys.IsKeyDown(Keys.Up) || _pad.ThumbSticks.Left.Y > 0)
            {
                Actor.Y -= 1;
                Actor.Texture = Actor.BackView;
                Actor.RectFrame(); ;
            }
            if (_keys.IsKeyDown(Keys.Down) || _pad.ThumbSticks.Left.Y < 0)
            {
                Actor.Y += 1;
                Actor.Texture = Actor.FrontView;
                Actor.RectFrame();
            }

            // two directional keys does not work!!!!!

            //if (_keys.IsKeyDown(Keys.Left) || _keys.IsKeyDown(Keys.Up))//|| pad.ThumbSticks.Left.X < 0)//&& spritePos.X > 0)
            //{
            //    Map.X += 1; // Only affects last created map object, will break
            //    Actor.Texture = Actor.FrontView; // Same?
            //    Actor.RectFrame();
            //}
            //if (_keys.IsKeyDown(Keys.Right) || _keys.IsKeyDown(Keys.Up)) // || pad.ThumbSticks.Left.X > 0)//&& actor.getActorX < ac.GraphicsDevice.Viewport.Width - (sprite.Width / 4))
            //{
            //    Map.X -= 1;
            //    Actor.Texture = Actor.FrontView;
            //    Actor.RectFrame();
            //}
            //if (_keys.IsKeyDown(Keys.Left) || _keys.IsKeyDown(Keys.Down)) //|| pad.ThumbSticks.Left.Y > 0)//  && actor.getActorY > 0)
            //{
            //    Map.Y += 1;
            //    Actor.Texture = Actor.BackView;
            //    Actor.RectFrame(); ;
            //}
            //if (_keys.IsKeyDown(Keys.Down) || _keys.IsKeyDown(Keys.Down))// || pad.ThumbSticks.Left.Y < 0)//&& actor.getActorY < graphics.GraphicsDevice.Viewport.Height - sprite.Height)
            //{
            //    Map.Y -= 1;
            //    Actor.Texture = Actor.BackView;
            //    Actor.RectFrame();
            //}
        }
    }
}
