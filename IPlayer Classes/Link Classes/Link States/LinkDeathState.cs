﻿namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDeathState : IState
    {
        private Link link;
        private int timer;
        public LinkDeathState(Link link)
        {
            this.link = link;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Direction = Vector.Orientation.East;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = false;
            this.link.IsDeath = true;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDeathSprite();
            timer = Link.DEATH_TIMER;
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
            // Do nothing
        }

        public void Update()
        {
            timer -= 1;
            if (timer == 0)
            {
                link.State = new LinkNonMovingSouthState(link);
            }
        }
    }
}
