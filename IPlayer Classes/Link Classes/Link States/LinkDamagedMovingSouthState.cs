﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingSouthState : IState
    {
        private Link link;
        private int timer;


        public LinkDamagedMovingSouthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 2;
            this.link.Velocity.Directon = Vector.Orientation.South;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = true;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingSouthSprite();
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
            // no action
        }
        public void West()
        {
            link.State = new LinkDamagedMovingWestState(link, timer);
        }
        public void Idle()
        {
            link.State = new LinkDamagedNonMovingSouthState(link, timer);
        }
        public void BeDamaged()
        {
            // no action
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
            link.Position = new Vector2(link.Position.X, link.Position.Y + link.Velocity.Magnitude);
            link.DestinationRectangle = new Rectangle((int)link.Position.X, (int)link.Position.Y, (int)(link.Scale * Link.linkWidth), (int)(link.Scale * Link.linkHeight));

            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkMovingSouthState(link);
                link.isDamaged = false;
            }
        }
    }
}
