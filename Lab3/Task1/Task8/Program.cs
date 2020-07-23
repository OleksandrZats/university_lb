using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new int[2] {1, 1};
            var point2 = new int[2] {2, 3};
            
            var rect1 = new Rectangle(point1, point2);

            Console.WriteLine(rect1.Equals(new Rectangle(point1, point2)));
            Console.WriteLine(rect1.ToString());
            Console.WriteLine(rect1.GetHashCode());
        }
    }
}