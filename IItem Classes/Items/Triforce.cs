﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class Triforce : IItem
    {
        private const int width = 10;
        private const int height = 10;
        private ISprite itemSprite;
        public Rectangle Rectangle;
        public float Scale { get; set; }
        public Vector2 itemLocation { get; set; }

        public Triforce(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateTriforce();
            itemLocation = location;
            Scale = 3f;
            Rectangle = new Rectangle((int)location.X, (int)location.Y, (int)(width * Scale), (int)(height * Scale));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            itemSprite.Draw(spriteBatch, Rectangle);
        }

        public void Update()
        {
            Rectangle = new Rectangle((int)itemLocation.X, (int)itemLocation.Y, (int)(width * Scale), (int)(height * Scale));
        }

        public void UseItem()
        {
            //TODO
        }
    }
}