﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseBlue_States
{
    class KeeseBlueSouthState : IState
    {
        private IEnemy enemy;
        private const int SPEED = 3;

        public KeeseBlueSouthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = SPEED;
            this.enemy.Velocity.Direction = Vector.Orientation.South;
        }

        public void North()
        {
            enemy.State = new KeeseBlueNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new KeeseBlueEastState(enemy);
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            enemy.State = new KeeseBlueWestState(enemy);
        }
        public void Freeze()
        {
            enemy.State = new KeeseBlueFreezeState(enemy);
        }
        public void Idle()
        {
            enemy.State = new KeeseBlueIdleState(enemy);
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y + enemy.Velocity.Magnitude, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
