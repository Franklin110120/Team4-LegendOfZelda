﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkKnockbackEastState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 16;
        private int timer;

        public LinkKnockbackEastState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingEastSprite();
            this.link.Rectangle = new Rectangle((int)this.link.Position.X, (int)this.link.Position.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));
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
            link.Position = new Vector2(link.Position.X - (Link.knockback_distance / Link.knockback_timer), link.Position.Y);
            link.Rectangle = new Rectangle((int)link.Position.X, (int)link.Position.Y, (int)(link.Scale * width), (int)(link.Scale * height));

            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkDamagedNonMovingEastState(link, Link.damage_timer);
            }
        }
    }
}