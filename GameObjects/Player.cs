using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Centipede.GameObjects
{
    class Player : SpriteGameObject
    {
        public Player() : base("spr_player")
        {
            Mouse.SetPosition(235, 500);
            Origin = new Vector2(sprite.Width * .5f, sprite.Height * .5f);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            position = inputHelper.MousePosition;
            base.HandleInput(inputHelper);
        }
    }
}
