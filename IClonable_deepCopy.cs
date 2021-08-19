using System;
using System.Collections.Generic;

namespace CSharp
{
    class IClonable_deepCopy
    {
        class Point : ICloneable
        {
            public Point()
            {
                x = 0;
                y = 0;
            }

            public Point(int x_, int y_)
            {
                x = x_;
                y = y_;
            }

            public void Print()
            {
                Console.WriteLine($"x : {this.x}, y : {this.y}");
            }

            //deep copy (custom)
            public Point deepCopy()
            {
                return new Point(this.x, this.y);
            }

            //.NET rule
            public object Clone()
            {
                return new Point(this.x, this.y);
            }

            public int x { get; set; }
            public int y { get; set; }
        }


        static void Main(string[] args)
        {
   
            Point pt1 = new Point(1, 2);
            Point pt2 = pt1;    //shallow copy. pt2 refer pt1.


            Point pt3 = (Point)pt1.Clone();
            pt1.x = 100;
            pt1.y = 100;

            pt1.Print();
            pt2.Print();
            pt3.Print();

        }
    }
}
