using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Centipede.GameObjects
{
    class Bullet : SpriteGameObject
    {
        int startspeed = -200;
        public Bullet(Vector2 _startpos) : base("spr_bullet")
        {
            position = _startpos;
            velocity.Y = startspeed;
            Origin = sprite.Center;
        }
    }
}
