using System;
using System.Collections.Generic;
using System.Text;

namespace Centipede.GameStates
{
    class GameOverState : GameObjectList
    {
        public GameOverState()
        {
            TextGameObject GOText = new TextGameObject("GameFont");
            Add(GOText);
            GOText.Text = "Game Over";
        }
    }
}
