using System;

namespace Task6
{
    public class Circel : GeometricFigure 
    {
        public int radius { get; set; }

        public Circel(int[] center, int radius):base(center)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Action<int, int> write = (xp, yp) => { Console.SetCursorPosition(xp, yp); Console.Write("*"); };
 
            int x = -radius;
            while (x < radius)
            {
                var y = (int)Math.Floor(Math.Sqrt(radius * radius - x * x));
 
                write(x + coner[0], y + coner[1]);
                y = -y;
                write(x + coner[0], y + coner[1]);
                x++;
            }
        }
    }
}