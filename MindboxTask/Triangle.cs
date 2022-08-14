namespace MindboxTask
{
    public class Triangle: IShape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        private readonly double _tolerance;

        public Triangle(double a, double b, double c, double tolerance = 0.000001)
        {
            if (new[] { a, b, c, tolerance }.Min() <= 0)
            {
                throw new ArgumentException(String.Format("Positive values expected: {0} {1} {2} {3}", a, b, c, tolerance));
            }
            _a = a;
            _b = b;
            _c = c;
            _tolerance = tolerance;
        }

        public double GetArea() => Math.Sqrt(
                Math.Pow(2 * _a * _b, 2) - Math.Pow((Math.Pow(_a, 2) + Math.Pow(_b, 2) - Math.Pow(_c, 2)), 2)
            ) / 4;

        public bool IsRightAngled()
        {
            var sortedSides = new [] {_a, _b, _c};
            Array.Sort(sortedSides);
            return Math.Abs(Math.Pow(sortedSides[2], 2) - Math.Pow(sortedSides[1], 2) - Math.Pow(sortedSides[0], 2)) <= _tolerance;
        }
    }
}
