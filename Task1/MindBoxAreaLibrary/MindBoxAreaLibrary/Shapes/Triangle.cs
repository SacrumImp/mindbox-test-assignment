namespace MindBoxAreaLibrary.Shapes
{
    public class Triangle : IArea
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public double GetArea()
        {
            if (FirstSide + SecondSide < ThirdSide || FirstSide + ThirdSide < SecondSide || SecondSide + ThirdSide < FirstSide)
            {
                throw new ArgumentException("There is no such triangle");
            }

            var sides = new double[] { FirstSide, SecondSide, ThirdSide };
            Array.Sort(sides);
            if (Math.Pow(sides[0],2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
            {
                return sides[0] * sides[1] / 2;
            }

            var p = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(p*(p-FirstSide)*(p-SecondSide)*(p-ThirdSide));
        }
    }
}
