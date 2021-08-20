using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    class Point
    {
        public Point() { }
        public Point(int x_, int y_)
        {
            x = x_;
            y = y_;
        }
        public int x { get; set; }
        public int y { get; set; }  
    }
    // class Points<T> : IEunerable<T>.. 
     class Points :IEnumerable
    {
        public Points() { }
        public Points(int size)
        {
            pointArr = new Point[size];
        }

        public Point[] pointArr { get; set; }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < pointArr.Length; ++i)
                yield return pointArr[i];
        }
    }




    class IEumerable_foreach
    {
        static void Main(string[] args)
        {
            Points pts = new Points(5);

            for (int i = 0; i < pts.pointArr.Length; ++i)
                pts.pointArr[i] = new Point(i, 2 * i);

            foreach (Point point in pts)
            {
                Console.WriteLine($"x :{point.x }, y :{point.y}");
            }
           
        }
    }
}