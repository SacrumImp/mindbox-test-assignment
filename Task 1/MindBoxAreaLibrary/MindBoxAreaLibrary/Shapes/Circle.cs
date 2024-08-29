namespace MindBoxAreaLibrary.Shapes
{
    public class Circle : IArea
    {
        public double Radius { get; set; }

        public Circle(double radius) {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
