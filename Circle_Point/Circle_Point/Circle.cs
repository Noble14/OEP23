namespace Circle_Point
{
    class Circle
    {
        Point c;
        double r;

        public class WrongRadiusException : Exception { }

        public Circle(Point c, double r)
        {
            if (r <= 0)
            {
                throw new WrongRadiusException();
            }
            this.c = c;
            this.r = r;
        }

        public bool includes(Point p)
        {
            return r >= c.distance(p);
        }
    }
}
