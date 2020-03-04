﻿namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IRoom
    {
        IPlayer Player { get; set; }
        System.Collections.Generic.List<IEnemy> Enemies { get; set; }
        System.Collections.Generic.List<IItem> Items { get; set; }
        System.Collections.Generic.List<IProjectile> PlayerProjectiles { get; set; }
        System.Collections.Generic.List<IProjectile> EnemyProjectiles { get; set; }
        System.Collections.Generic.List<IBlock> Blocks { get; set; }
        //List<IBoundary> Boundaries { get; set; }
        IRoom North { get; set; }
        IRoom East { get; set; }
        IRoom South { get; set; }
        IRoom West { get; set; }
        IRoom Other { get; set; }

        void Initialize(IPlayer player, System.Collections.Generic.List<IEnemy> enemies, System.Collections.Generic.List<IItem> items, System.Collections.Generic.List<IBlock> blocks);
        void Update();
        void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}