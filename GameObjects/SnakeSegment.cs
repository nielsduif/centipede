using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
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
            if(position.X < 0 - sprite.Width || position.X - sprite.Width > GameEnvironment.Screen.X)
            {
                Bounce();
            }
            base.Update(gameTime);
        }
        void Bounce()
        {
            velocity.X *= -1;
            position.Y += shiftAmount;
        }
    }
}
