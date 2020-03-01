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
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkSwordWestSprite();
            this.link.Rectangle = new Rectangle((int)(this.link.Position.X - this.link.Scale * (width - height)), (int)this.link.Position.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));
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
                link.State = new LinkNonMovingWestState(link);
                link.attackDirection = -1;
            }
        }
    }
}
