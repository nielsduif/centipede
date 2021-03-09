using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Centipede.GameObjects
{
    class Bullet : SpriteGameObject
    {
        int startSpeed = -200;
        public Bullet(Vector2 _startPos) : base("spr_bullet")
        {
            position = _startPos;
            velocity.Y = startSpeed;
            Origin = sprite.Center;
        }
    }
}
