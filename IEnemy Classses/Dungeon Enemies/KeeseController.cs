﻿using Team4_LegendOfZelda.Random_Number_Generator;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class KeeseController : IController
    {
        private IEnemy enemy;
        private const int MIN_FLYING_COUNTS = 60, MAX_FLYING_COUNTS = 100, MIN_WAITING_COUNT = 20, MAX_WAITNG_COUNT = 80, MIN_DIRECTION_COUNT = 0, MAX_DIRECTION_COUNT = 15;
        private int flyingCount, waitingCount, directionCount;

        public KeeseController(IEnemy enemy)
        {
            this.enemy = enemy;
            flyingCount = RandomIntGenerator.Instance.Next(MIN_FLYING_COUNTS, MAX_FLYING_COUNTS);
            waitingCount = 0;
            directionCount = 0;
        }

        public void Update()
        {
            if (flyingCount <= 0)
            {
                if (enemy.Velocity.Magnitude > 0)
                {
                    enemy.Idle();
                }

                if (waitingCount <= 0)
                {
                    flyingCount = RandomIntGenerator.Instance.Next(MIN_FLYING_COUNTS, MAX_FLYING_COUNTS);
                    waitingCount = RandomIntGenerator.Instance.Next(MIN_WAITING_COUNT, MAX_WAITNG_COUNT);
                }
                else
                {
                    waitingCount--;
                }
            }
            else
            {
                if (directionCount <= 0)
                {
                    switch (RandomIntGenerator.Instance.Next(0, 3))
                    {
                        case 0:
                            if (enemy.Velocity.Direction != Vector.Orientation.South)
                            {
                                enemy.North();
                            }
                            break;
                        case 1:
                            if (enemy.Velocity.Direction != Vector.Orientation.West)
                            {
                                enemy.East();
                            }
                            break;
                        case 2:
                            if (enemy.Velocity.Direction != Vector.Orientation.North)
                            {
                                enemy.South();
                            }
                            break;
                        case 3:
                            if (enemy.Velocity.Direction != Vector.Orientation.East)
                            {
                                enemy.West();
                            }
                            break;
                        default:
                            // Do nothing, this is not supposed to happen
                            break;
                    }
                    directionCount = RandomIntGenerator.Instance.Next(MIN_DIRECTION_COUNT, MAX_DIRECTION_COUNT);
                }
                else
                {
                    directionCount--;
                }

                flyingCount--;
            }
        }
    }
}
