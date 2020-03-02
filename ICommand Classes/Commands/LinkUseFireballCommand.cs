﻿namespace Team4_LegendOfZelda
{
    public class LinkUseFireballCommand : ICommand
    {
        private IPlayer player;
        private ILevel level;

        public LinkUseFireballCommand(IPlayer player, ILevel level)
        {
            this.player = player;
            this.level = level;
        }
        public void Execute()
        {
            player.currentUseItemID = 2;
            player.UseItem();
            level.CurrentRoom.Projectiles.Add(player.currentProjectile);

        }
    }
}
