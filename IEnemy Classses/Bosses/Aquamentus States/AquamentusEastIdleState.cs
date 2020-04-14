﻿using Team4_LegendOfZelda.Utility_Classes;
namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses.Aquamentus_States

{
    class AquamentusEastIdleState : IState
    {
        private IEnemy enemy;

        public AquamentusEastIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusWestIdleSprite();
            this.enemy.Velocity.Magnitude = UtilityClass.Instance.Aquamentus_Velocity();
            this.enemy.Velocity.Direction = Vector.Orientation.East;
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
            enemy.State = new AquamentusWestIdleState(enemy);
        }

        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // TODO
        }

        public void Attack()
        {
            enemy.State = new AquamentusEastAttackState(enemy, UtilityClass.Instance.Aquamentus_MAX_ATTACK_COUNTER());
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            // Do nothing
        }
    }
}
