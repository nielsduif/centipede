using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Centipede.GameStates
{
    class GameObjectGridState : GameObjectList
    {
        GameObjectGrid GOGrid;
        DrawingHelper DH;

        public GameObjectGridState()
        {
            GOGrid = new GameObjectGrid(5, 5, 0);
            Add(GOGrid);
            GOGrid.CellHeight = 50;
            GOGrid.CellWidth = 50;
            for (int i = 0; i < GOGrid.Rows; i++)
            {
                for (int x = 0; x < GOGrid.Columns; x++)
                {
                    GOGrid.Add(new SpriteGameObject("spr_player"), i, x);
                }
            }

            DH = new DrawingHelper();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
            
        }
    }
}
