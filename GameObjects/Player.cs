using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Centipede.GameObjects
{
    class Player : SpriteGameObject
    {
        public Player() : base("spr_player")
        {
            Reset();
            Origin = sprite.Center;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            position = inputHelper.MousePosition;
            base.HandleInput(inputHelper);
        }

        public override void Reset()
        {
            Mouse.SetPosition(235, 500);
            Debug.WriteLine(Mouse.GetState().Position);
            position = new Vector2(Mouse.GetState().Position.X, Mouse.GetState().Position.Y);
            base.Reset();
        }
    }
}
