using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeowTown
{
    class Camera2D
    {
        private static Matrix _transform;
        private static Vector2 _start;

        public static void Update()
        {
            _start = new Vector2(0,0);
            _transform = Matrix.CreateScale(new Vector3(1,1,0)) * Matrix.CreateTranslation(new Vector3(_start.X, _start.Y, 0));        
        }

        public static Matrix Transform
        {
            get { return _transform; }
        }
    }
}
