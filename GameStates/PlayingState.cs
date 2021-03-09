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
        int spacingBulletPlayer = 20;
        GameObjectList snake;
        int snakeSegments = 10;
        int snakeSpacing = 32;
        GameObjectList mushrooms;
        int[] randomMushroom = { 20, 450, 25, 450 };
        int mushroomAmount = 20;
        public PlayingState()
        {
            Add(new SpriteGameObject("spr_background"));
            player = new Player();
            Add(player);
            bullets = new GameObjectList();
            Add(bullets);
            snake = new GameObjectList();
            Add(snake);
            for (int i = 0; i < snakeSegments - 1; i++)
            {
                snake.Add(new SnakeSegment("spr_snakebody", new Vector2(i * snakeSpacing, 0)));
            }
            snake.Add(new SnakeSegment("spr_snakehead", new Vector2(snakeSpacing * snakeSegments - snakeSpacing, 0)));
            mushrooms = new GameObjectList();
            Add(mushrooms);
            for (int i = 0; i < mushroomAmount; i++)
            {
                Random r = new Random();
                int x = r.Next(randomMushroom[0], randomMushroom[1]);
                int y = r.Next(randomMushroom[2], randomMushroom[3]);
                mushrooms.Add(new Mushroom(new Vector2(x, y)));
            }
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Space))
            {
                bullets.Add(new Bullet(new Vector2(player.Position.X, player.Position.Y - spacingBulletPlayer)));
            }
            base.HandleInput(inputHelper);
        }
    }
}
