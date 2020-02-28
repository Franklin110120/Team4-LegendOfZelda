﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoEastDamagedState : IState
    {
        IEnemy enemy;
        private const int width = 32;
        private const int height = 16;
        int count, maxCount;

        public DodongoEastDamagedState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoEastDamagedSprite();
            this.enemy.Rectangle = new Rectangle((int)this.enemy.Position.X, (int)this.enemy.Position.Y, (int)(this.enemy.Scale * width), (int)(this.enemy.Scale * height));

            count = 0;
            maxCount = 120;
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            // TODO
        }

        public void BeDamaged()
        {
            // Do nothing
        }

        public void Attack()
        {
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            count++;
            if (count > maxCount)
            {
                enemy.State = new DodongoEastWalkingState(enemy);
            }
        }
    }
}