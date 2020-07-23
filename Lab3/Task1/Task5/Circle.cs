using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Circle
    {
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public int Radius { get; set; }

        public Circle()
        {
            CenterX = 0;
            CenterY = 0;
            Radius = 1;
        }

        public Circle(int centerX, int centerY, int radius)
        {
            CenterX = centerX;
            CenterY = centerY;
            Radius = radius;
        }

        public double GetCircleLength()
        {
            return 2 * this.Radius + Math.PI;
        }

        public double GetCircleLength(int radius)
        {
            return 2 * radius + Math.PI;
        }

        public Circle GetCircle()
        {
            return new Circle(this.CenterX, this.CenterY, this.Radius);
        }

        public Circle GetCircle(int centerX, int centerY, int radius)
        {
            return new Circle(centerX, centerY, radius);
        }

        public bool IsInCircle(int dotX, int dotY)
        {
            //(x - x0)^2 + (y - y0)^2 <= R^2
            bool temp = (Math.Pow((dotX - this.CenterX), 2) + Math.Pow((dotY - this.CenterY), 2)) <=
                        Math.Pow(this.Radius, 2);
            if (temp)
            {
                return true;
            }

            return false;
        }

        public string AboughtCircle()
        {
            return $"Координаты центра x : {this.CenterX}, y : {this.CenterY}. Радиус R = {this.Radius}";
        }
    }
}