﻿namespace Team4_LegendOfZelda.Vector
{
    public class VelocityVector : IVector
    {
        public int Magnitude { get; set; }
        public Orientation Direction { get; set ; }

        public VelocityVector(int magnitude, Orientation Direction)
        {
            Magnitude = magnitude;
            Direction = Direction;
        }
    }
}
