using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Centipede.GameObjects
{
    class Score : TextGameObject
    {
        int score;
        public Score() : base("GameFont")
        {
            position = new Vector2(10, 10);
        }

        public override void Update(GameTime gameTime)
        {
            text = score.ToString();
            base.Update(gameTime);
        }

        public void Add(int _amount)
        {
            score += _amount;
        }
    }
}
