﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.Item_Classes
{
    class Arrow : IItem
    {
       
        private ISprite itemSprite;
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        public Vector2 itemLocation { get; set; }

        public Arrow(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateArrow();
            itemLocation = location;
            Scale = UtilityClass.Instance.Scale();
            DestinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)(UtilityClass.Instance.Arrow_WIDTH() * Scale), (int)(UtilityClass.Instance.Arrow_HEIGHT() * Scale));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            itemSprite.Draw(spriteBatch, DestinationRectangle);
        }
        public void Update()
        {
            DestinationRectangle = new Rectangle((int)itemLocation.X, (int)itemLocation.Y, (int)(UtilityClass.Instance.Arrow_WIDTH() * Scale), (int)(UtilityClass.Instance.Arrow_HEIGHT() * Scale));
        }

        public void UseItem()
        {
            //TODO
        }
    }
}
