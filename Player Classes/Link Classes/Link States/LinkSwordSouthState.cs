﻿using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkSwordSouthState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkSwordSouthState(Link link)
        {
            this.link = link;
            // contrust sprite
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
        public void GoWest()
        {
            // no action
        }
        public void BeDamaged()
        {
            link.State = new LinkDamagedNonMovingSouthState(link);
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
            // sword south
            link.State = new LinkNonMovingSouthState(link);
        }
    }
}
