using Centipede.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Centipede.Content.GameStates
{
    class PlayingState : GameObjectList
    {
        Player player;
        GameObjectList bullets;
        public PlayingState()
        {
            Add(new SpriteGameObject("spr_background"));
            player = new Player();
            Add(player);
            bullets = new GameObjectList();
            Add(bullets);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if(inputHelper.KeyPressed(Keys.Space))
            {
                bullets.Add(new Bullet(new Vector2(player.Position.X , player.Position.Y - 20)));
            }
            base.HandleInput(inputHelper);
        }
    }
}
