using System;

namespace FigureLibrary
{
    public class Triangle : IFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;


        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double perim = (sideA + sideB + sideC) / 2;
            double prevArea = perim * (perim - sideA) * (perim - sideB) * (perim - sideC);
            double result = (prevArea <= 0) ? 0 : Math.Sqrt(prevArea);

            return Math.Round(result, 2);
        }

        public bool IsRightTriangle()
        {
            double hypotenuse = Math.Max(sideA, Math.Max(sideB, sideC));
            return Math.Pow(hypotenuse, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(hypotenuse, 2);
        }

        public override string ToString()
        {
            return "Треугольник";
        }
    }
}
