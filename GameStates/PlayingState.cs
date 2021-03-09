using Centipede.GameObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Centipede.Content.GameStates
{
    class PlayingState : GameObjectList
    {
        Player player;
        public PlayingState()
        {
            Add(new SpriteGameObject("spr_background"));
            player = new Player();
            Add(player);
        }
    }
}
