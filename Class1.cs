using System;
using System.Collections.Generic;

namespace ShapesLibrary
{
    public class Shape  // Аналог прямоугольника
    {
        public float[] sides;
        public void PutSides(float[] get_sides)
        {
            sides = get_sides;
        }

        public float Get_Area()
        {
            if (sides[0] == sides[1])
            {
                return sides[0] * sides[2];
            }
            return sides[0] * sides[1];
        }
    }

    public class Triangle: Shape
    {
        public float Get_Area()
        {

        }

        private bool is_right()
        {
            float min1 = float.MaxValue;  // Наибольшее из двух минимальных катетов
            float min2 = float.MaxValue;  // Наименьшее из двух минимальных катетов
            float hypotenuse = 0;
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
            return Math.Pow(hypotenuse, 2) == Math.Pow(min1, 2) + Math.Pow(min2, 2);
        }
    }
}
