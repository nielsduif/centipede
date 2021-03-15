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
            if (position.X < 0 - sprite.Width)
            {
                Bounce(sprite.Width + position.X);
            }
            else if (position.X > GameEnvironment.Screen.X)
            {
                Bounce(GameEnvironment.Screen.X - position.X);
            }
            base.Update(gameTime);
        }

        public void Bounce(float _offset)
        {
            Debug.WriteLine(_offset);
            position.Y += shiftAmount;
            position.X += _offset;
            velocity.X *= -1;
        }
    }
}
