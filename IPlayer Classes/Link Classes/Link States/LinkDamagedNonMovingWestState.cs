﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedNonMovingWestState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 16;
        private int timer;
        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedNonMovingWestState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedNonMovingWestSprite();
            this.link.Rectangle = new Rectangle((int)this.link.Position.X, (int)this.link.Position.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));
        }
        public void South()
        {
            link.State = new LinkDamagedMovingSouthState(link, timer);
        }
        public void North()
        {
            link.State = new LinkDamagedMovingNorthState(link, timer);
        }
        public void East()
        {
            link.State = new LinkDamagedMovingEastState(link, timer);
        }
        public void West()
        {
            link.State = new LinkDamagedMovingWestState(link, timer);
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
                link.State = new LinkNonMovingWestState(link);
                link.isDamaged = false;
            }
        }
    }
}
