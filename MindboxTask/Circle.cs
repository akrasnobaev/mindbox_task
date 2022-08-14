namespace MindboxTask
{
    public class Circle: IShape
    {
        private readonly double _radius = 0;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException(String.Format("Positive radius expected"));
            }
            _radius = radius;
        }

        public double GetArea() => Math.PI * Math.Pow(_radius, 2);
    }
}
