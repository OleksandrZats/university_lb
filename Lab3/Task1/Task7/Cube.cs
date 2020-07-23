namespace Task7
{
    public class Cube : Squere 
    {
        public Cube(int sideLenth) : base(sideLenth) { }

        public override int Perim()
        {
            return sideLenth * 12;
        }
    }
}