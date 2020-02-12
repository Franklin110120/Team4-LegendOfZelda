﻿using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingEastState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedMovingEastState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void South()
        {
            link.State = new LinkDamagedNonMovingSouthState(link);
        }
        public void North()
        {
            link.State = new LinkDamagedNonMovingNorthState(link);
        }
        public void East()
        {
            // no action
        }
        public void West()
        {
            link.State = new LinkDamagedNonMovingWestState(link);
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
            // move east
            // decrement damage timer
        }
    }
}
