using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_2
{
    public struct Coordinates
    {
        public double X;
        public double Y;
        public double Z;

        public Coordinates(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public double GetDistance(Coordinates other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            double dz = other.Z - Z;

            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
    }
}
