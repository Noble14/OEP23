namespace Circle_Point
{
    public class Point
    {
        double x, y;
        public Point(double a, double b)
        {
            x = a;
            y = b;
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
        public double distFromZero()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public double distance(Point p)
        {
            return Math.Sqrt((p.x - x) * (p.x - x) + (p.y - y) * (p.y - y));
        }
        public static double dist(Point p1, Point p2)
        {
            return Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
        }
    }
}
