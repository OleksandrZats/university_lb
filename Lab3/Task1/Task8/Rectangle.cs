using System;

namespace Task8
{
    public class Rectangle
    {
        public int[] conerOne { get; set; }
        public int[] conerTwo { get; set; }

        public Rectangle(int[] conerOne, int[] conerTwo)
        {
            this.conerOne = conerOne;
            this.conerTwo = conerTwo;
        }

        public override bool Equals(object? obj)
        {
            Rectangle temp = (Rectangle) obj;
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this.conerOne == temp.conerOne && this.conerTwo == temp.conerTwo;
        }

        public override string ToString()
        {
            return $"Rectangle: x1 = {conerOne[0]}, y1 = {conerOne[1]}, x2 = {conerTwo[0]}, y2 = {conerTwo[1]}";
        }

        public override int GetHashCode()
        {
            return Tuple.Create(conerOne, conerTwo).GetHashCode();
        }
    }
}