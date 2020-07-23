using System;

namespace Task6
{
    public class Triangle : GeometricFigure
    {
        public int[] cornerTwo { get; set; }
        public int[] cornerThree { get; set; }



        public Triangle(int[] cornerOne ,int[] cornerTwo,int[] cornerThree) : base(cornerOne)
        {
            this.cornerTwo = cornerTwo;
            this.cornerThree = cornerThree;
        }

        public void Draw()
        {
            Console.SetCursorPosition(coner[0],coner[1]);
            Console.Write("*");
            
            Console.SetCursorPosition(cornerTwo[0],cornerTwo[1]);
            Console.Write("*");

            Console.SetCursorPosition(cornerThree[0],cornerThree[1]);
            Console.Write("*");
        }
    }
}