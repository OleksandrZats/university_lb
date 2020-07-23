namespace Task7
{
    public class Squere
    {
        public int sideLenth { get; set; }

        public Squere(int sideLenth)
        {
            this.sideLenth = sideLenth;
        }

        public virtual int Perim()
        {
            return sideLenth * 4;
        }
    }
}