﻿using Team4_LegendOfZelda.Random_Number_Generator;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class StalfosController : IController
    {
        private IEnemy enemy;
        private static int MAX_DIRECTION_COUNTS = 30;
        private int directionCount;

        public StalfosController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = MAX_DIRECTION_COUNTS;
        }

        public void Update()
        {
            directionCount--;
            if (directionCount <= 0)
            {
                switch (RandomIntGenerator.Instance.Next(0, 3))
                {
                    case 0:
                        enemy.Idle();
                        enemy.North();
                        break;
                    case 1:
                        enemy.Idle();
                        enemy.East();
                        break;
                    case 2:
                        enemy.Idle();
                        enemy.South();
                        break;
                    case 3:
                        enemy.Idle();
                        enemy.West();
                        break;
                    default:
                        // Do nothing
                        break;
                }
                directionCount = MAX_DIRECTION_COUNTS;
            }
        }
    }
}