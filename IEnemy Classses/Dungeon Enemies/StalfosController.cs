﻿using Team4_LegendOfZelda.Random_Number_Generator;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class StalfosController : IController
    {
        private IEnemy enemy;
        private int directionCount;

        public StalfosController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = RandomIntGenerator.Instance.Next(UtilityClass.Instance.StalfosController_MIN_DIRECTION_COUNTS(), UtilityClass.Instance.StalfosController_MAX_DIRECTION_COUNTS());
        }

        public void Update()
        {
            directionCount--;
            if (directionCount <= 0)
            {
                switch (RandomIntGenerator.Instance.Next(0, 3))
                {
                    case 0:
                        enemy.North();
                        break;
                    case 1:
                        enemy.East();
                        break;
                    case 2:
                        enemy.South();
                        break;
                    case 3:
                        enemy.West();
                        break;
                    default:
                        // Do nothing
                        break;
                }
                directionCount = RandomIntGenerator.Instance.Next(UtilityClass.Instance.StalfosController_MIN_DIRECTION_COUNTS(), UtilityClass.Instance.StalfosController_MAX_DIRECTION_COUNTS());
            }
        }
    }
}
