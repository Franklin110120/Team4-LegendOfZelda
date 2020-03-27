﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseRed_States
{
    class KeeseRedEastState : IState
    {
        private IEnemy enemy;
        private static int MAX_DISPLACEMENT = 48, DELTA_DISPLACEMENT = 2;
        private int displacement;

        public KeeseRedEastState(IEnemy enemy)
        {
            this.enemy = enemy;
            displacement = MAX_DISPLACEMENT;
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
            enemy.State = new KeeseRedIdleState(enemy);
        }

        public void BeDamaged()
        {
            // TODO
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
            //enemy.DestinationRectangle = new Rectangle((enemy.DestinationRectangle.X + 2) % 800, enemy.DestinationRectangle.Y);
            if (displacement > 0)
            {
                enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                
            }
            else
            {
                Idle();
            }
        }
    }
}
