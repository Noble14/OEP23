using System;
using TextFile;

namespace Circle_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Point p0 = new Point(0,0);
            //Point p1 = new Point(1,2);
            //p1.distFromZero();
            //p1.distance(p0);
            //p0.distance(p1);

            //Point.dist(p1, p0);
            TextFileReader reader = new TextFileReader("input.txt");
            reader.ReadDouble(out double a);
            reader.ReadDouble(out double b);
            reader.ReadDouble(out double r);
            //Point center = new Point(a, b);
            try
            {
                Circle k = new Circle(new Point(a, b), r);
                reader.ReadInt(out int n);
                Point[] points = new Point[n];
                for (int i = 0; i < n;i++)
                {
                    reader.ReadDouble(out double x);
                    reader.ReadDouble(out double y);
                    points[i] = new Point(x,y);
                }
                int counter = 0;
                for (int i = 0; i < n; i++)
                {
                    if (k.includes(points[i]))
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
            }
            catch (Circle.WrongRadiusException)
            {                
                Console.WriteLine("nem lehet kisebb mint a nulla a sugár");
            }
        }
    }
}