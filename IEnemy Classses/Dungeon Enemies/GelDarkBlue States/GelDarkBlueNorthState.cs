﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GelDarkBlue_States
{
    class GelDarkBlueNorthState : IState
    {
        private IEnemy enemy;
        private const int SPEED = 2;

        public GelDarkBlueNorthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = SPEED;
            this.enemy.Velocity.Direction = Vector.Orientation.North;
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
        public void Freeze()
        {
            enemy.State = new GelDarkBlueFreezeState(enemy);
        }
        public void Idle()
        {
            enemy.State = new GelDarkBlueIdleState(enemy);
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y - SPEED, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
