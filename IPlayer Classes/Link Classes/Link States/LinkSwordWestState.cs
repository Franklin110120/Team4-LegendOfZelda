﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkSwordWestState : IState
    {
        private Link link;
        private const int width = 27;
        private const int height = 16;
        private int timer;


        public LinkSwordWestState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Directon = Vector.Orientation.West;
            this.link.isAttacking = true;
            this.link.isKnocked = false;
            this.link.isDamaged = false;
            this.link.isDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkSwordWestSprite();
            this.link.LinkSwordRectangle = new Rectangle((int)(this.link.DestinationRectangle.X - this.link.Scale * (width - height)), (int)this.link.DestinationRectangle.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));
        }
        public void South()
        {
            // no action
        }
        public void North()
        {
            // no action
        }
        public void East()
        {
            // no action
        }
        public void West()
        {
            // no action
        }
        public void Idle()
        {
            // Do nothing
        }
        public void BeDamaged()
        {
            link.State = new LinkKnockbackWestState(link, Link.knockback_timer);
        }
        public void UseItem()
        {
            // no action
        }
        public void Attack()
        {
            // no action
        }
        public void Update()
        {
            this.timer -= 1;
            if (this.timer == 0)
            {
                link.LinkSwordRectangle = Rectangle.Empty;
                link.State = new LinkNonMovingWestState(link);
            }
        }
    }
}
