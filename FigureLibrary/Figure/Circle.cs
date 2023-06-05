using System;

namespace FigureLibrary
{   
    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        public override string ToString()
        {
            return "Круг";
        }
    }
}