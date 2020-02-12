﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda
{
    public class Link : IPlayer
    {
        public ISprite Sprite { get; set; }
        public IPlayerState state { get; set; }
        public Vector2 Position { get; set; }

        public Link()
        {
            state = new LinkNonMovingSouthState(this);
        }
        public void South()
        {
            state.South();
        }
        public void North()
        {
            state.North();
        }
        public void East()
        {
            state.East();
        }
        public void West()
        {
            state.West();
        }
        public void BeDamaged()
        {
            state.BeDamaged();
        }
        public void UseItem()
        {
            state.UseItem();
        }
        public void UseSword()
        {
            state.UseSword();
        }
        public void Update()
        {
            // TODO
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Position);
        }
    }
}
