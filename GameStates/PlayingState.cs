using Centipede.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        Score score;
        int scoreSnakeHit = 10, scoreMushroomHit = 1;

        public PlayingState()
        {
            Add(new SpriteGameObject("spr_background"));
            player = new Player();
            Add(player);
            bullets = new GameObjectList();
            Add(bullets);
            snake = new GameObjectList();
            Add(snake);
            mushrooms = new GameObjectList();
            Add(mushrooms);
            score = new Score();
            Add(score);
            Init();
        }

        void Init()
        {
            for (int i = 0; i < snakeSegments - 1; i++)
            {
                snake.Add(new SnakeSegment("spr_snakebody", new Vector2(i * snakeSpacing, 0)));
            }
            snake.Add(new SnakeSegment("spr_snakehead", new Vector2(snakeSpacing * snakeSegments - snakeSpacing, 0)));
            for (int i = 0; i < mushroomAmount; i++)
            {
                Random r = new Random();
                int x = r.Next(randomMushroom[0], randomMushroom[1]);
                int y = r.Next(randomMushroom[2], randomMushroom[3]);
                mushrooms.Add(new Mushroom(new Vector2(x, y)));
            }
        }

        public override void Update(GameTime gameTime)
        {
            bool _gameOver = false;
            for (int i = snake.Children.Count - 1; i >= 0; i--)
            {
                SnakeSegment s = snake.Children[i] as SnakeSegment;
                for (int x = bullets.Children.Count - 1; x >= 0; x--)
                {
                    Bullet b = bullets.Children[x] as Bullet;
                    if (s.CollidesWith(b))
                    {
                        score.Add(scoreSnakeHit);
                        mushrooms.Add(new Mushroom(s.Position));
                        bullets.Remove(b);
                        snake.Remove(s);
                    }
                }
                for (int x = mushrooms.Children.Count - 1; x >= 0; x--)
                {
                    Mushroom m = mushrooms.Children[x] as Mushroom;
                    if (s.CollidesWith(m))
                    {
                        s.Bounce();
                    }
                }
                if (s.CollidesWith(player))
                {
                    _gameOver = true;
                }
            }
            if (_gameOver)
            {
                Reset();
            }
            for (int i = bullets.Children.Count - 1; i >= 0; i--)
            {
                Bullet b = bullets.Children[i] as Bullet;
                for (int x = mushrooms.Children.Count - 1; x >= 0; x--)
                {
                    Mushroom m = mushrooms.Children[x] as Mushroom;
                    if (b.CollidesWith(m))
                    {
                        score.Add(scoreMushroomHit);
                        mushrooms.Remove(m);
                        bullets.Remove(b);
                    }
                }
            }
            base.Update(gameTime);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Space))
            {
                bullets.Add(new Bullet(new Vector2(player.Position.X, player.Position.Y - spacingBulletPlayer)));
            }
            base.HandleInput(inputHelper);
        }

        public override void Reset()
        {
            base.Reset();
            player.Reset();
            score.Reset();
            bullets.Children.Clear();
            snake.Children.Clear();
            mushrooms.Children.Clear();
            Init();
            GameEnvironment.GameStateManager.SwitchTo("gameOverState");
        }
    }
}
