﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkSwordEastState : IState
    {
        private Link link;
        private const int width = 27;
        private const int height = 16;
        private int timer;


        public LinkSwordEastState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Direction = Vector.Orientation.East;
            this.link.IsAttacking = true;
            this.link.IsKnocked = false;
            this.link.IsDamaged = false;
            this.link.IsDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkSwordEastSprite();
            this.link.LinkSwordRectangle = new Rectangle((int)this.link.DestinationRectangle.X, (int)this.link.DestinationRectangle.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));
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
            link.State = new LinkKnockbackEastState(link, Link.KNOCKBACK_TIMER);
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
                link.State = new LinkNonMovingEastState(link);
            }
        }
    }
}
