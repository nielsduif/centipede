using System;
using System.Collections.Generic;
using System.Text;

namespace Centipede.Content.GameStates
{
    class PlayingState : GameObjectList
    {
        public PlayingState()
        {
            Add(new SpriteGameObject("spr_background"));
        }
    }
}
