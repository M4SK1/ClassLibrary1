using System;
using System.Collections.Generic;

namespace ShapesLibrary
{
    public class Shape  // Аналог прямоугольника
    {
        public double[] sides;
        
        public Shape(double[] get_sides)
        {
            sides = get_sides;
        }

        public double getArea()
        {
            if (sides.Length > 2)
            {
                return -1;
            }
            return sides[0] * sides[1];
        }
    }

    public class Triangle
    {
        public double[] sides;
        public Triangle(double[] get_sides)
        {
            sides = get_sides;
        }
        public double GetArea()
        {
            double[] CathAndHypo = getCathetus();
            if (isRight(CathAndHypo))
            {
                return CathAndHypo[0] * CathAndHypo[1] * 0.5f;
            }
            double p = (sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }

        private bool isRight(double[] CathAndHypo)
        {
            return Math.Pow(CathAndHypo[2], 2) == Math.Pow(CathAndHypo[0], 2) + Math.Pow(CathAndHypo[1], 2);
        }

        private double[] getCathetus()
        {
            double min1 = float.MaxValue;  // Наибольшее из двух минимальных катетов
            double min2 = float.MaxValue;  // Наименьшее из двух минимальных катетов
            double hypotenuse = 0;
            double[] CathAndHypo = new double[3];
            for (int i = 0; i < 3; i++)
            {
                if (sides[i] < min1)
                {
                    min1 = sides[i];
                }
                if (sides[i] < min2)
                {
                    min1 = min2;
                    min2 = sides[i];
                }
                else
                {
                    hypotenuse = sides[i];
                }
            }
            CathAndHypo[0] = min1;
            CathAndHypo[1] = min2;
            CathAndHypo[2] = hypotenuse;
            return CathAndHypo;
        }
    }
    
    public class Circle
    {
        double radius;
        public Circle(double get_radius)
        {
            radius = get_radius;
        }
        public double GetArea()
        {
            return radius * Math.PI;
        }
    }
}
