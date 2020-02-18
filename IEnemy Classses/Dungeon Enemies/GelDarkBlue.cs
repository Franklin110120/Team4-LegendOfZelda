﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class GelDarkBlue : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        int count, maxCount;
        Random rand;

        public GelDarkBlue(ILevel level, Vector2 position)
        {
            Level = level;
            Sprite = EnemySpriteFactory.Instance.CreateGelDarkBlueSprite();
            State = new NullState();
            Position = position;

            count = 0;
            maxCount = 60;
            rand = new Random();
        }

        public void Update()
        {
            count++;
            if (count > maxCount)
            {
                switch (rand.Next(0, 4))
                {
                    case 0:
                        Position = new Vector2(Position.X, ((int)Position.Y - 10) % 600);
                        break;
                    case 1:
                        Position = new Vector2(((int)Position.X + 10) % 800, Position.Y);
                        break;
                    case 2:
                        Position = new Vector2(Position.X, ((int)Position.Y + 10) % 600);
                        break;
                    case 3:
                        Position = new Vector2(((int)Position.X - 10) % 800, Position.Y);
                        break;
                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                count = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Position);
        }
    }
}
