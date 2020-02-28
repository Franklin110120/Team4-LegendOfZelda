﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaBlue_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class GoriyaBlue : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle Rectangle { get; set; }
        public float Scale { get; set; }
        int count, maxCount;
        Random rand;

        public GoriyaBlue(ILevel level, Vector2 position)
        {
            Level = level;
            Position = position;
            Scale = 3f;
            State = new GoriyaBlueWestState(this);

            count = 0;
            maxCount = 10;
            rand = new Random();
        }

        public void North()
        {
            State.North();
        }

        public void East()
        {
            State.East();
        }

        public void South()
        {
            State.South();
        }

        public void West()
        {
            State.West();
        }

        public void Idle()
        {
            State.Idle();
        }

        public void BeDamaged()
        {
            State.BeDamaged();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void UseItem()
        {
            State.UseItem();
        }

        public void Update()
        {
            State.Update();
            Sprite.Update();

            count++;
            if (count > maxCount)
            {
                switch (rand.Next(0, 6))
                {
                    case 0:
                        State.North();
                        break;
                    case 1:
                        State.East();
                        break;
                    case 2:
                        State.South();
                        break;
                    case 3:
                        State.West();
                        break;
                    case 4:
                        State.Attack();
                        break;
                    case 5:
                        State.BeDamaged();
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
            Sprite.Draw(spriteBatch, Rectangle);
        }
    }
}