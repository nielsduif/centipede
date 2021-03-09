using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Centipede.GameObjects
{
    class Mushroom : SpriteGameObject
    {
        public Mushroom(Vector2 _startPos) : base("spr_mushroom")
        {
            position = _startPos;
        }
    }
}
