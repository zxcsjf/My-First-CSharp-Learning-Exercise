namespace HelloWorldCSharp
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point nexLocation)
        {
            this.X = nexLocation.X;
            this.Y = nexLocation.Y;
        }

        public string MyPiont { get; set; }
    }

}
