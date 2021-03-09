using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
            GOText.Position = new Vector2(GameEnvironment.Screen.X * .5f - GOText.Size.X * .5f, GameEnvironment.Screen.Y * .5f);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Space))
            {
                GameEnvironment.GameStateManager.SwitchTo("playingState");
            }
            base.HandleInput(inputHelper);
        }
    }
}
