using System;

namespace Task6
{
    public class Square : GeometricFigure
    {
        public int sideLenth { get; set; }

        public Square(int[] conerOne, int sideLenth) : base(conerOne)
        {
            this.sideLenth = sideLenth;
        }

        public void Draw()
        {
            Console.SetCursorPosition(coner[0],coner[1]);
            Console.Write("*");
            
            Console.SetCursorPosition(coner[0]+sideLenth*2,coner[1]);
            Console.Write("*");
            
            Console.SetCursorPosition(coner[0]+sideLenth*2,coner[1]+sideLenth);
            Console.Write("*");
            
            Console.SetCursorPosition(coner[0],coner[1]+sideLenth);
            Console.Write("*");
        }
    }
}