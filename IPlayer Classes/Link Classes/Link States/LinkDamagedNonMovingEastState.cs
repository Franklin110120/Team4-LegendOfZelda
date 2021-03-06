﻿namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedNonMovingEastState : IState
    {
        private Link link;
        private int timer;

        public LinkDamagedNonMovingEastState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Direction = Vector.Orientation.East;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = true;
            this.link.IsDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedNonMovingEastSprite();
        }

        public void North()
        {
            link.State = new LinkDamagedMovingNorthState(link, timer);
        }

        public void East()
        {
            link.State = new LinkDamagedMovingEastState(link, timer);
        }

        public void South()
        {
            link.State = new LinkDamagedMovingSouthState(link, timer);
        }

        public void West()
        {
            link.State = new LinkDamagedMovingWestState(link, timer);
        }
        public void Freeze()
        {
            // Do nothing
        }
        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Attack()
        {
            link.State = new LinkDamagedAttackEastState(link, Link.SWORD_TIMER, timer);
        }

        public void Update()
        {
            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkNonMovingEastState(link);
                link.IsDamaged = false;
            }
        }
    }
}
