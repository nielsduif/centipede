using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Centipede.GameObjects
{
    class SnakeSegment : SpriteGameObject
    {
        int startSpeed = 200;
        int shiftAmount = 32;
        public SnakeSegment(string _assetName, Vector2 _startPos) : base(_assetName)
        {
            position = _startPos;
            velocity.X = startSpeed;
        }

        public override void Update(GameTime gameTime)
        {
            if (position.X < 0 - sprite.Width || position.X > GameEnvironment.Screen.X)
            {
                Bounce();
            }
            position.X += velocity.X * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void Bounce()
        {
            position.Y += shiftAmount;
            velocity.X *= -1;
        }
    }
}
