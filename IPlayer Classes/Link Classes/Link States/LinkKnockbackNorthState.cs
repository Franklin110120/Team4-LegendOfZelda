﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkKnockbackNorthState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 16;
        private int timer;

        public LinkKnockbackNorthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Direction = 0;
            this.link.Velocity = 10;
            this.link.isAttacking = false;
            this.link.isKnocked = true;
            this.link.isDamaged = true;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingNorthSprite();
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
            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkDamagedNonMovingNorthState(link, Link.damage_timer);
            }
            else
            {
                link.Position = new Vector2(link.Position.X, link.Position.Y + link.Velocity);
                link.Rectangle = new Rectangle((int)link.Position.X, (int)link.Position.Y, (int)(link.Scale * width), (int)(link.Scale * height));

            }
        }
    }
}

